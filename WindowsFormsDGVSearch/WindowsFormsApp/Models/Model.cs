using System.Collections.Generic;

namespace WindowsFormsApp.Models
{
    public class Model
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public List<Car> Cars { get; } = new List<Car>();

        public Model(string title, string type, string year,
        string price, List<Car> cars)
        {
            Title = title; Year = year; Type = type;
            Price = price; Cars = cars;
        }
    }
}
