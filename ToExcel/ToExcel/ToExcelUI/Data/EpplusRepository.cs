using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using ToExcelUI.Models;

namespace ToExcelUI.Data
{
    public class EpplusRepository : IRepository
    {
        private const string _FILE_NAME = @"Data\Phonebook.xlsx";
        private readonly string _pathToFile;
        private FileInfo _workingFile;

        //ctor
        public EpplusRepository()
        {
            _pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _FILE_NAME);
        }

        /// <summary>
        /// Получение ссылки на файл
        /// </summary>
        /// <returns></returns>
        private FileInfo GetFileInfo()
        {
            if (_workingFile == null)
            {
                if (!File.Exists(_pathToFile)) throw new Exception($"Файл не найден: {_pathToFile}");
                _workingFile = new FileInfo(_pathToFile);
            }

            return _workingFile;
        }

        /// <summary>
        /// Получение полного списка людей
        /// </summary>
        /// <returns></returns>
        public List<Person> GetPeople()
        {
            List<Person> result = new List<Person>();

            using (var pck = new ExcelPackage(GetFileInfo()))
            using (ExcelWorksheet ws = pck.Workbook.Worksheets[1])
            {
                //регион заполненных ячеек
                var dim = ws.Dimension;
                //читаем строки, наполняем коллекцию людей
                var columns = new List<string>();
                //пропускаем первую строку, т.к. она содержит заголовки
                for (int row = dim.Start.Row + 1; row <= dim.End.Row; row++)
                {
                    //читаем строку
                    columns.Clear();
                    for (int column = dim.Start.Column; column <= dim.End.Column; column++)
                    {
                        var value = ws.Cells[row, column].Value?.ToString();

                        if (String.IsNullOrEmpty(value)) value = "<?>";
                        columns.Add(value);
                    }

                    //добавляем нового в коллекцию
                    var person = new Person
                    {
                        Id = row,
                        FirstName = columns[0],
                        LastName = columns[1],
                        Address = columns[2],
                        Phone = columns[3]
                    };
                    result.Add(person);
                }
            }

            return result;
        }

        /// <summary>
        /// Получение записи по Id  равному номеру строки в файле
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person GetPerson(int id)
        {
            Person person = null;

            using (var pck = new ExcelPackage(GetFileInfo()))
            using (ExcelWorksheet ws = pck.Workbook.Worksheets[1])
            {
                //регион заполненных ячеек
                var dim = ws.Dimension;
                //пропускаем первую строку, т.к. она содержит заголовки
                if (id > dim.Start.Row && id <= dim.End.Row)
                {
                    //читаем строку
                    var columns = new List<string>();
                    for (int column = dim.Start.Column; column <= dim.End.Column; column++)
                    {
                        var value = ws.Cells[id, column].Value.ToString();
                        columns.Add(value);
                    }

                    //присваиваем значения свойствам
                    person = new Person();
                    person.Id = id;
                    person.FirstName = columns[0];
                    person.LastName = columns[1];
                    person.Address = columns[2];
                    person.Phone = columns[3];
                }

            }

            return person;
        }

        /// <summary>
        /// Вставка новой записи
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public int AddPerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));

            int result = 0;

            using (var pck = new ExcelPackage(GetFileInfo()))
            using (ExcelWorksheet ws = pck.Workbook.Worksheets[1])
            {
                //регион заполненных ячеек
                var dim = ws.Dimension;
                //вычисляем номера строк и столбцов
                result = dim.End.Row + 1;
                int cFirstName = dim.Start.Column;
                int cLastName = dim.Start.Column + 1;
                int cAddress = dim.Start.Column + 2;
                int cPhone = dim.Start.Column + 3;

                //присваиваем значения
                ws.Cells[result, cFirstName].Value = person.FirstName;
                ws.Cells[result, cLastName].Value = person.LastName;
                ws.Cells[result, cAddress].Value = person.Address;
                ws.Cells[result, cPhone].Value = person.Phone;

                //сохраняем
                pck.Save();
            }

            return result;
        }

        /// <summary>
        /// Обновление нужной записи
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool UpdatePerson(Person person)
        {
            if (person == null) throw new ArgumentNullException(nameof(person));

            bool result = false;

            using (var pck = new ExcelPackage(GetFileInfo()))
            using (ExcelWorksheet ws = pck.Workbook.Worksheets[1])
            {
                //регион заполненных ячеек
                var dim = ws.Dimension;

                if (person.Id > dim.Start.Row && person.Id <= dim.End.Row)
                {
                    //вычисляем номера столбцов
                    int cFirstName = dim.Start.Column;
                    int cLastName = dim.Start.Column + 1;
                    int cAddress = dim.Start.Column + 2;
                    int cPhone = dim.Start.Column + 3;

                    //присваиваем значения
                    ws.Cells[person.Id, cFirstName].Value = person.FirstName;
                    ws.Cells[person.Id, cLastName].Value = person.LastName;
                    ws.Cells[person.Id, cAddress].Value = person.Address;
                    ws.Cells[person.Id, cPhone].Value = person.Phone;

                    //сохраняем
                    pck.Save();
                    result = true;
                }
            }

            return result;
        }

        /// <summary>
        /// Удаление строки из файла по ее номеру
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemovePerson(int id)
        {
            bool result = false;

            using (var pck = new ExcelPackage(GetFileInfo()))
            using (ExcelWorksheet ws = pck.Workbook.Worksheets[1])
            {
                //регион заполненных ячеек
                var dim = ws.Dimension;

                if (id > dim.Start.Row && id <= dim.End.Row)
                {
                    //удаляем строку с нужным номером
                    ws.DeleteRow(id);

                    result = true;
                }

                //сохраняем
                pck.Save();
            }

            return result;
        }

    }
}
