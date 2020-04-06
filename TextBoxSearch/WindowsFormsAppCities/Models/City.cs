namespace WindowsFormsAppCities.Models
{
    public class City
    {
        public int Id { get; }
        public string Name { get; }

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"{Id}-{Name}";
        
    }
}
