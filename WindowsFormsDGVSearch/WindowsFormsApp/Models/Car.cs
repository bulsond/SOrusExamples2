namespace WindowsFormsApp.Models
{
    public class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Transmission { get; set; }
        public string Drive { get; set; }
        public int Hp { get; set; }
        public string Engine { get; set; }
        public int Price { get; set; }

        public Car(string model, int year, string transmission, string drive, string engine,
        int hp, int price)
        {
            Model = model; Year = year; Transmission = transmission;
            Drive = drive; Hp = hp; Engine = engine; Price = price;
        }
    }
}
