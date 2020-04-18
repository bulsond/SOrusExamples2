namespace ConsoleAppRecords.Models
{
    class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public string Position { get; }

        public Employee(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public override string ToString() => $"{Id}: {Name}, {Position}";
    }
}
