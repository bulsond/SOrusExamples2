using System.Collections.Generic;

namespace ConsoleTestApp.Models
{
    public class WebCar
    {
        public string id { get; set; }
        public string car_num { get; set; }
        public string licence_num { get; set; }
        public string create_date { get; set; }
        public string photo { get; set; }
    }

    public class WebCars
    {
        public List<WebCar> data { get; set; }
        public bool success { get; set; }
    }
}
