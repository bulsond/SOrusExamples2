using System.Collections.Generic;
using ToExcelUI.Models;

namespace ToExcelUI.Data
{
    public interface IRepository
    {
        int AddPerson(Person person);
        List<Person> GetPeople();
        Person GetPerson(int id);
        bool RemovePerson(int id);
        bool UpdatePerson(Person person);
    }
}