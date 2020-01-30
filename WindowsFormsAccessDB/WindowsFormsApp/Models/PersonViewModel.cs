using System;
using System.ComponentModel;

namespace WindowsFormsApp.Models
{
    public class PersonViewModel : IDataErrorInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Fio =>
            $"{LastName} {FirstName?.Substring(0, 1)}.{MiddleName?.Substring(0, 1)}.";
        public string Login { get; set; }
        public string Password { get; set; }
        public string Password2 { get; set; }

        #region реализация IDataErrorInfo
        public string _Error;
        public string Error => _Error;
        public string this[string columnName] => CheckProperties(columnName);

        /// <summary>
        /// Проверка значений свойств на валидность значений
        /// </summary>
        /// <param name="columnName">имя проверяемого свойства</param>
        /// <returns></returns>
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

            if (columnName.Equals(nameof(MiddleName)) && String.IsNullOrEmpty(MiddleName))
            {
                _Error = "Укажите отчество";
                return _Error;
            }

            if (columnName.Equals(nameof(MiddleName)) && MiddleName?.Trim().Length < 2)
            {
                _Error = "Отчество не может быть короче двух символов";
                return _Error;
            }

            if (columnName.Equals(nameof(Login)) && String.IsNullOrEmpty(Login))
            {
                _Error = "Укажите логин";
                return _Error;
            }

            if (columnName.Equals(nameof(Login)) && Login?.Trim().Length < 4)
            {
                _Error = "Логин не может быть короче четырех символов";
                return _Error;
            }

            if (columnName.Equals(nameof(Password)) && String.IsNullOrEmpty(Password))
            {
                _Error = "Укажите пароль";
                return _Error;
            }

            if (columnName.Equals(nameof(Password)) && Password?.Trim().Length < 6)
            {
                _Error = "Пароль не может быть короче шести символов";
                return _Error;
            }

            if (columnName.Equals(nameof(Password2)) && String.IsNullOrEmpty(Password2))
            {
                _Error = "Укажите повторно пароль";
                return _Error;
            }

            if (columnName.Equals(nameof(Password2)) && Password2 != Password)
            {
                _Error = "Пароль и повторный пароль не совпадают!";
                return _Error;
            }

            _Error = String.Empty;
            return _Error;
        }

        #endregion
    }
}
