using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birthdate { get; set; }
        public string Category { get; set; }
        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
