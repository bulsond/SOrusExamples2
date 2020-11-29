using System.Collections.Generic;
using System.Threading.Tasks;
using WpfUI.Models;

namespace WpfUI.Data
{
    public interface IEmployeeRepository
    {
        //получение всех
        Task<List<Employee>> GetEmployees();
        //добавление
        Task<int> AddEmployee(Employee employee);
        //удаление
        Task<int> RemoveEmployee(int id);
        //обновление
        Task<int> UpdateEmployee(Employee emp);
    }
}
