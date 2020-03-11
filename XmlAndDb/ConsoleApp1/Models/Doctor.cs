using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Profession { get; set; }
        public int Category { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();
    }
}
