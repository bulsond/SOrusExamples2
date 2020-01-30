using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Data
{
    /// <summary>
    /// Тестовый контекст данных приложения
    /// </summary>
    public class TestDataContext : IDataContext
    {
        private readonly List<PersonViewModel> _data;
        
        public TestDataContext()
        {
            _data = new List<PersonViewModel>
            {
                new PersonViewModel { Id = 1, FirstName = "Семен", LastName = "Рудаков", MiddleName = "Михайлович" },
                new PersonViewModel { Id = 2, FirstName = "Мария", LastName = "Рязанцева", MiddleName = "Ивановна" },
                new PersonViewModel { Id = 3, FirstName = "Константин", LastName = "Кудрявцев", MiddleName = "Петрович" }
            };
        }
        public Task<List<PersonViewModel>> LoadPeopleAsync()
        {
            return Task.FromResult(_data);
        }

        public Task<int> AddPersonAsync(PersonViewModel person)
        {
            int id = 1;
            if (_data.Any())
            {
                id = _data.Max(p => p.Id) + 1;
            }
            person.Id = id;
            _data.Add(person);

            return Task.FromResult(1);
        }

        public Task<int> RemovePersonAsync(PersonViewModel person)
        {
            var forDel = _data.FirstOrDefault(p => p.Id == person.Id);
            if (forDel == null)
            {
                return Task.FromResult(0);
            }

            _data.Remove(forDel);
            return Task.FromResult(1);
        }

        public Task<int> UpdatePersonAsync(PersonViewModel person)
        {
            return Task.FromResult(1);
        }
    }
}
