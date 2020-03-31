using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Data
{
    public class AppData
    {
        private List<Model> _models;

        public AppData()
        {
            var listY = new List<Car>();
            listY.Add(new Car("Yaris L", 2020, "Manual", "FWD", "Fuel", 106, 15650));
            listY.Add(new Car("Yaris XLE", 2020, "Automatic", "FWD", "Fuel", 106, 18750));

            var listYH = new List<Car>();
            listYH.Add(new Car("Yaris LE Hatchback", 2020, "Automatic", "FWD", "Fuel", 106, 17750));

            var listC = new List<Car>();
            listC.Add(new Car("Corolla L", 2020, "Automatic", "FWD", "Fuel", 139, 19600));
            listC.Add(new Car("Corolla LE", 2020, "Automatic", "FWD", "Fuel", 139, 20050));
            listC.Add(new Car("Corolla Hybrid LE", 2020, "Automatic", "FWD", "Fuel", 169, 23100));
            listC.Add(new Car("Corolla LE", 2018, "Automatic", "AWD", "Fuel", 139, 21500));
            listC.Add(new Car("Corolla", 2019, "Manual", "AWD", "Fuel", 139, 22500));
            listC.Add(new Car("Corolla L", 2017, "Manual", "AWD", "Fuel", 139, 18500));

            _models = new List<Model>
            {
                new Model("Yaris ", "Sedan", "2020", "from 15,650$", listY),
                new Model("Yaris Hatchback", "Hatchback", "2020", "from 17,750$", listYH),
                new Model("Cororlla", "Coupe", "2020", "from 19,600$", listC)
            };
        }

        public IEnumerable<Model> GetModels() => _models.AsEnumerable();

        public IEnumerable<string> GetModelsTypes() => _models.Select(m => m.Type);

        public IEnumerable<Model> GetModelsByType(string type) =>
            _models.Where(m => m.Type.Equals(type));

    }
}
