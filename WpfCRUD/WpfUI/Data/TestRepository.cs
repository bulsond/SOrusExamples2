﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WpfUI.Models;

namespace WpfUI.Data
{
    class TestRepository : IEmployeeRepository
    {
        private List<Employee> _employees;
        public TestRepository()
        {
            _employees = new List<Employee>
            {
                new Employee(1, "Иван", "Голунов", "+7561234567"),
                new Employee(2, "Сергей", "Смирнов", "+77861234567"),
                new Employee(3, "Дарья", "Смирнова", "+798475563"),
                new Employee(4, "Кристина", "Семяжко", "+7304985023"),
                new Employee(5, "Владимир", "Драгунов", "+73431234567"),
            };
        }

        public Task<List<Employee>> GetEmployees()
        {
            var result = new List<Employee>();
            foreach (var e in _employees)
            {
                var emp = new Employee(e.Id, e.FirstName, e.LastName, e.Phone);
                result.Add(emp);
            }

            return Task.FromResult(result);
        }

        public Task<int> AddEmployee(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));
            if (String.IsNullOrWhiteSpace(employee.FirstName)
                || String.IsNullOrEmpty(employee.FirstName))
            {
                return Task.FromResult(0);
            }
            if (String.IsNullOrWhiteSpace(employee.LastName)
                || String.IsNullOrEmpty(employee.LastName))
            {
                return Task.FromResult(0);
            }

            if (employee is null || employee.Id > 0)
                throw new ArgumentNullException(nameof(employee));

            if (_employees.Count > 0)
            {
                employee.Id = _employees.Max(e => e.Id) + 1;
            }
            else
            {
                employee.Id = 1;
            }
            _employees.Add(employee);

            return Task.FromResult(employee.Id);
        }

        public Task<int> RemoveEmployee(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp != null)
            {
                _employees.Remove(emp);
            }

            return Task.FromResult(id);
        }

        public Task<int> UpdateEmployee(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));
            if (String.IsNullOrWhiteSpace(employee.FirstName)
                || String.IsNullOrEmpty(employee.FirstName))
            {
                return Task.FromResult(0);
            }
            if (String.IsNullOrWhiteSpace(employee.LastName)
                || String.IsNullOrEmpty(employee.LastName))
            {
                return Task.FromResult(0);
            }

            var emp = _employees.FirstOrDefault(e => e.Id == employee.Id);
            if (emp != null)
            {
                emp.FirstName = employee.FirstName;
                emp.LastName = employee.LastName;
                emp.Phone = employee.Phone;
            }

            return Task.FromResult(employee.Id);
        }
    }
}
