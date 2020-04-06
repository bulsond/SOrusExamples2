using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppCities.Models;

namespace WindowsFormsAppCities.Services
{
    public class CitiesService
    {
        private const string _fileName = @"Data\rucities.txt";
        private readonly CultureInfo _cultureInfo = new CultureInfo("ru-Ru");

        public IReadOnlyList<City> Cities { get; private set; }

        public async Task InitAsync()
        {
            var cities = new List<City>();
            
            try
            {
                int index = 0;
                using (var fs = File.OpenRead(_fileName))
                using (var sr = new StreamReader(fs, Encoding.GetEncoding("windows-1251")))
                {
                    while (sr.Peek() >= 0)
                    {
                        var name = await sr.ReadLineAsync();
                        var c = new City(++index, name);
                        cities.Add(c);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            Cities = cities.AsReadOnly();
        }

        public List<City> GetCitiesStartsWith(string input)
        {
            if (input is null)
                throw new ArgumentNullException(nameof(input));

            var result = Cities.Where(c => c.Name.StartsWith(input, true, _cultureInfo))
                               .ToList();
            return result;
        }
        
    }
}
