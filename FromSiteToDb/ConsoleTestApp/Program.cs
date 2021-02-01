using ConsoleTestApp.Data;
using ConsoleTestApp.Service;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("ConsoleTestApp");

            //получаем данные
            string url = "http://solutions2019.hakta.pro/api/getFines?participant=01";
            var service = new WebCarsApiService(url);
            var cars = await service.GetCarsAsync();

            Console.WriteLine($"Получено {cars.Count()} авто");

            //сохраняем данные в БД
            var repository = new CarsRepository();
            int result = await repository.SaveCarsAsync(cars);

            Console.WriteLine($"Сохранено {result.ToString()} авто в БД");

            Console.ReadLine();
        }
    }
}
