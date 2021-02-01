using ConsoleTestApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleTestApp.Service
{
    public class WebCarsApiService
    {
        private static readonly HttpClient _client = new HttpClient();
        private readonly string _url;

        public WebCarsApiService(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException(nameof(url));
            }

            _url = url;
        }

        public async Task<IEnumerable<Car>> GetCarsAsync()
        {
            var result = new List<Car>();
            WebCars webCars = null;

            try
            {
                using (var response = await _client.GetAsync(_url))
                using (var stream = await response.Content.ReadAsStreamAsync())
                {
                    webCars = await JsonSerializer.DeserializeAsync<WebCars>(stream);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            if (webCars != null && webCars.data.Count > 0)
            {
                foreach (var wc in webCars.data)
                {
                    var car = new Car
                    {
                        Id = int.Parse(wc.id),
                        CreateDate = DateTime.Parse(wc.create_date),
                        CarNumber = wc.car_num,
                        LicenceNumber = wc.licence_num,
                        Photo = wc.photo
                    };
                    result.Add(car);
                }
            }

            return result;
        }
    }
}
