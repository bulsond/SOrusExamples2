namespace WindowsFormsApp.Models
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Fio =>
            $"{LastName} {FirstName?.Substring(0, 1)}.{MiddleName?.Substring(0, 1)}.";
        public string Login { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }
    }
}
