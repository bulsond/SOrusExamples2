using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfUI.Commands;
using WpfUI.Data;
using WpfUI.Models;
using WpfUI.Utils;

namespace WpfUI.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private Employee _selectedEmployee;
        private Employee _editableEmployee = new Employee(0);
        private List<Employee> _people;

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel(IEmployeeRepository employeeRepository)
        {

            EmployeeRepository = employeeRepository;
            Add = new AddEmployeeCommand(this);
            Save = new SaveEmployeeCommand(this);
            Delete = new DeleteEmployeeCommand(this);
            Next = new SelectNextCommand(this);
            Prev = new SelectPreviosCommand(this);

            LoadPeople().Await(HandleException);
        }

        //Загрузка из БД списка сотрудников
        public async Task LoadPeople()
        {
            var employees = await EmployeeRepository.GetEmployees();

            int id = 0;
            employees.ForEach(e => e.OrderNumber = ++id);
            People = employees;
        }

        //Обработка ошибки в случае LoadPeople()
        private void HandleException(Exception ex)
        {
            People = new List<Employee>();
        }

        //Ссылка на класс репозитория для работы с БД
        public IEmployeeRepository EmployeeRepository { get; }

        //--Команды для кнопок
        public ICommand Add { get; }
        public ICommand Save { get; }
        public ICommand Delete { get; }
        public ICommand Next { get; }
        public ICommand Prev { get; }

        //--Свойства
        //Отображаемая в DataGrid коллекция сотрудников
        public List<Employee> People
        {
            get => _people;
            set
            {
                _people = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(People)));
            }
        }

        //Выделенный в DataGrid сотрудник
        public Employee SelectedEmployee
        {
            get => _selectedEmployee;
            set
            {
                if (value == _selectedEmployee)
                    return;
                _selectedEmployee = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedEmployee)));
                //Делаем копию для редактируемого сотрудника
                if (_selectedEmployee != null)
                {
                    EditableEmployee = Employee.GetClone(_selectedEmployee);
                }
            }
        }

        //Редактируемый сотрудник
        public Employee EditableEmployee
        {
            get => _editableEmployee;
            set
            {
                _editableEmployee = value;
                //оповещаем View об изменении значений свойств
                //c помощью вызова события PropertyChanged для каждого привязанного свойства
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(FirstName)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(LastName)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Phone)));
            }
        }

        //Имя редактируемого
        public string FirstName
        {
            get => _editableEmployee.FirstName;
            set => _editableEmployee.FirstName = value;
        }

        //Фамилия редактируемого
        public string LastName
        {
            get => _editableEmployee.LastName;
            set => _editableEmployee.LastName = value;
        }

        //Телефон редактируемого
        public string Phone
        {
            get => _editableEmployee.Phone;
            set => _editableEmployee.Phone = value;
        }
    }
}
