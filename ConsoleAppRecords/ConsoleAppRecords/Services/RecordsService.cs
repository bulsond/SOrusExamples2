using ConsoleAppRecords.Models;
using System;
using System.Linq;

namespace ConsoleAppRecords.Services
{
    class RecordsService
    {
        private Employee[] _employees;

        public RecordsService()
        {
            _employees = new Employee[0];
        }

        /// <summary>
        /// Добавление новог досье
        /// </summary>
        /// <param name="name">имя сотрудника</param>
        /// <param name="position">должность сотрудника</param>
        /// <returns>Id сотрудника</returns>
        internal int Add(string name, string position)
        {
            int id = _employees.Length + 1;
            Employee[] temp = new Employee[id];
            Array.Copy(_employees, temp, _employees.Length);

            var employee = new Employee(id, name, position);
            temp[temp.Length - 1] = employee;

            _employees = temp;
            return id;
        }

        /// <summary>
        /// Получение полного списка досье
        /// </summary>
        /// <returns></returns>
        internal Employee[] GetAll() => _employees;

        /// <summary>
        /// Получение досье сотрудника по Id
        /// </summary>
        /// <param name="id">Id сотрудника</param>
        /// <returns>сотрудник</returns>
        internal Employee GetById(int id)
            => _employees.SingleOrDefault(e => e.Id == id);

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="employee">сотрудник</param>
        internal void Remove(Employee employee)
        {
            int length = _employees.Length - 1;
            Employee[] temp = new Employee[length];

            int index = 0;
            foreach (var emp in _employees)
            {
                if (emp.Id == employee.Id)
                {
                    continue;
                }

                var newEmp = new Employee(index + 1, emp.Name, emp.Position);
                temp[index] = newEmp;
                ++index;
            }

            _employees = temp;
        }

        /// <summary>
        /// Досье с нужной фамилией
        /// </summary>
        /// <param name="lastName">искомая фамилия</param>
        /// <returns></returns>
        internal Employee[] GetByLastName(string lastName)
            => _employees.Where(e => e.Name.StartsWith(lastName)).ToArray();
    }
}
