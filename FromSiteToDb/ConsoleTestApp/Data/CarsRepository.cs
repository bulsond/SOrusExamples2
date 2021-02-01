using ConsoleTestApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleTestApp.Data
{
    public class CarsRepository
    {
        public async Task<int> SaveCarsAsync(IEnumerable<Car> cars)
        {
            int result = 0;
            using (var context = new AppDataContext())
            {
                context.Cars.AddRange(cars);
                result = await context.SaveChangesAsync();
            }

            return result;
        }
    }
}
