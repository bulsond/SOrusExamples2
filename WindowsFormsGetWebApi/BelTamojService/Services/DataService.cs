using BelTamojService.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BelTamojService.Services
{
    class DataService
    {
        private readonly HttpClient _httpClient;

        public DataService()
        {
            //настройка клиента
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://mon.declarant.by");
            _httpClient.Timeout = new TimeSpan(0, 0, 30);
        }

        public async Task<Page> GetPageAsync(int pageNumber)
        {
            Page result = new Page();

            var response = await _httpClient.GetAsync($"/api/pto-recs?page={pageNumber}");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<Page>(json);
            }
            else
            {
                result.StatusCode = response.StatusCode.ToString();
            }
            return result;
        }
    }
}
