using ConsoleAppRecords.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppRecords.Services
{
    class UiService
    {
        private readonly RecordsService _records;
        private readonly string _menu;
        private readonly Dictionary<int, Action> _commands;
        private Action _currentCommand;

        public UiService(RecordsService recordsService)
        {
            _records = recordsService;
            _menu = GetMenu();
            _commands = GetCommands();
        }

        private string GetMenu()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Программа кадрового учета");
            sb.AppendLine("-------------------------");
            sb.AppendLine("Выберете пункт меню:");
            sb.AppendLine("1 - Добавить новое досье");
            sb.AppendLine("2 - Вывести все досье");
            sb.AppendLine("3 - Удалить досье");
            sb.AppendLine("4 - Поиск по фамилии");
            sb.AppendLine("5 - Выход из программы");
            return sb.ToString();
        }

        private Dictionary<int, Action> GetCommands()
        {
            return new Dictionary<int, Action>
            {
                [1] = AddRecord,
                [2] = PrintAllRecords,
                [3] = RemoveRecord,
                [4] = FindByLastName,
                [5] = delegate { }
            };
        }

        /// <summary>
        /// Отображение меню программы
        /// </summary>
        /// <returns></returns>
        internal bool PrintMenu()
        {
            _currentCommand = null;

            Console.Clear();
            Console.WriteLine(_menu);

            var input = Console.ReadLine();
            int point = 0;
            if (!int.TryParse(input, out point))
            {
                PrintInputError();
                return true;
            }

            if (!_commands.ContainsKey(point))
            {
                PrintInputError();
                return true;
            }

            if (point == 5)
            {
                PrintBye();
                return false;
            }

            _currentCommand = _commands[point];
            return true;

        }

        /// <summary>
        /// Выполнение выбранной пользователем команды
        /// </summary>
        internal void Execute()
        {
            _currentCommand?.Invoke();
        }

        

        /// <summary>
        /// Команда добавления досье
        /// </summary>
        private void AddRecord()
        {
            Console.WriteLine("Введите ФИО:");
            var name = Console.ReadLine();
            Console.WriteLine("Введите должность:");
            var position = Console.ReadLine();

            int number = _records.Add(name, position);
            if (number == 0)
            {
                PrintInputError();
                return;
            }

            Console.WriteLine($"Сохранено под номером {number}");
            PrintContinue();
        }

        /// <summary>
        /// Команда отображения всех досье
        /// </summary>
        private void PrintAllRecords()
        {
            PrintEmploees();
            PrintContinue();
        }

        /// <summary>
        /// Команда удаления досье
        /// </summary>
        private void RemoveRecord()
        {
            PrintEmploees();
            Console.WriteLine("Введите номер досье для удаления:");

            var input = Console.ReadLine();
            int id = 0;
            if (!int.TryParse(input, out id))
            {
                PrintInputError();
                return;
            }

            var employee = _records.GetById(id);
            if (employee == null)
            {
                Console.WriteLine($"Досье с номером {id} не найдено!");
                PrintInputError();
                return;
            }

            if (IsAgreedDeleteEmployee(employee))
            {
                _records.Remove(employee);
                Console.WriteLine($"Досье с номером {id} удалено!");
            }
            else
            {
                Console.WriteLine($"{employee} сохранен.");
            }

            PrintContinue();
        }

        /// <summary>
        /// Команда поиска по фамилии
        /// </summary>
        private void FindByLastName()
        {
            Console.WriteLine("Введите фамилию сотрудника:");
            var lastName = Console.ReadLine();

            Employee[] employees = _records.GetByLastName(lastName);
            if (employees.Length == 0)
            {
                Console.WriteLine($"Досье с фамилией \"{lastName}\" не найдено.");
            }
            else
            {
                Array.ForEach(employees, Console.WriteLine);
            }

            PrintContinue();
        }

        private bool IsAgreedDeleteEmployee(Employee employee)
        {
            int answer = 0;
            do
            {
                Console.WriteLine($"Вы согласны удалить \"{employee}\"?");
                Console.WriteLine("1 - удалить, 0 - не удалять.");
                var input = Console.ReadLine();
                if (int.TryParse(input, out answer))
                {
                    if (answer >= 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод!");
                }
            } while (true);

            return answer >= 1;
        }

        private void PrintBye()
        {
            Console.WriteLine("Выходим... нажмите ввод.");
            Console.ReadLine();
        }

        private void PrintInputError()
        {
            Console.WriteLine("Ошибка ввода, для продолжения нажмите ввод.");
            Console.ReadLine();
        }

        private static void PrintContinue()
        {
            Console.WriteLine("Для продолжения нажмите ввод.");
            Console.ReadLine();
        }

        private void PrintEmploees()
        {
            var employees = _records.GetAll();
            Array.ForEach(employees, Console.WriteLine);
        }
    }
}
