using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Data
{
    public interface IDataContext
    {
        /// <summary>
        /// Добавить нового пользователя
        /// </summary>
        /// <param name="person">экземпляр пользователя</param>
        /// <returns>1 если успешно</returns>
        Task<int> AddPersonAsync(PersonViewModel person);

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        /// <param name="person">экземпляр пользователя</param>
        /// <returns>1 если успешно</returns>
        Task<int> RemovePersonAsync(PersonViewModel person);

        /// <summary>
        /// Получение полного списка пользователей
        /// </summary>
        /// <returns>список пользователей с их логинами и паролями</returns>
        Task<List<PersonViewModel>> LoadPeopleAsync();

        /// <summary>
        /// Обновление данных по пользователю
        /// </summary>
        /// <param name="person">экземпляр пользователя</param>
        /// <returns>1 если успешно</returns>
        Task<int> UpdatePersonAsync(PersonViewModel person);
    }
}
