using System;
using System.ComponentModel;

namespace WindowsFormsApp.Models
{
    public class Person : IDataErrorInfo
    {
        public int OrderNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #region Реализация IDataErrorInfo
        public string _Error;
        public string Error => _Error;
        public string this[string columnName] => CheckProperties(columnName);

        /// <summary>
        /// Проверка значений свойств на валидность
        /// </summary>
        /// <param name="columnName">имя проверяемого свойства</param>
        /// <returns>строка с описанием ошибки</returns>
        private string CheckProperties(string columnName)
        {
            if (columnName.Equals(nameof(FirstName)) && String.IsNullOrEmpty(FirstName))
            {
                _Error = "Укажите имя";
                return _Error;
            }

            if (columnName.Equals(nameof(FirstName)) && FirstName?.Trim().Length < 2)
            {
                _Error = "Имя не может быть короче двух символов";
                return _Error;
            }

            if (columnName.Equals(nameof(LastName)) && String.IsNullOrEmpty(LastName))
            {
                _Error = "Укажите фамилию";
                return _Error;
            }

            if (columnName.Equals(nameof(LastName)) && LastName?.Trim().Length < 2)
            {
                _Error = "Фамилия не может быть короче двух символов";
                return _Error;
            }

            _Error = String.Empty;
            return _Error;
        }
        #endregion
    }
}
