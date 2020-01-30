using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading.Tasks;
using WindowsFormsApp.Models;

namespace WindowsFormsApp.Data
{
    /// <summary>
    /// Класс работы с БД Access
    /// </summary>
    public class AccessDataContext : IDataContext
    {
        public AccessDataContext()
        { }

        /// <summary>
        /// Создание экземпляра соединения
        /// </summary>
        /// <returns></returns>
        private OleDbConnection GetConnection()
        {
            var connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=Data\\People.accdb;Persist Security Info=True";

            return new OleDbConnection(connectionString);
        }

        /// <summary>
        /// Получение полного списка людей с их логинами
        /// </summary>
        /// <returns></returns>
        public async Task<List<PersonViewModel>> LoadPeopleAsync()
        {
            List<PersonViewModel> result = new List<PersonViewModel>();

            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT Личные_данные.Код, Личные_данные.Имя, Личные_данные.Фамилия, Личные_данные.Отчество, Пользователи.Логин, Пользователи.Пароль " +
                                      "FROM Личные_данные " +
                                      "INNER JOIN Пользователи " +
                                      "ON Личные_данные.Код = Пользователи.Личные_данные_Код;";
                    con.Open();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var person = new PersonViewModel
                            {
                                Id = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                MiddleName = reader.GetString(3),
                                Login = reader.GetString(4),
                                Password = reader.GetString(5),
                            };
                            //
                            result.Add(person);
                        }
                    }
                }
            }
            catch (OleDbException ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Внесение записи о новом человеке
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<int> AddPersonAsync(PersonViewModel person)
        {
            int result = 0;

            try
            {
                //Вносим данные в таблицу Личные_данные
                result = await InsertPrivatePersonData(person);
                //Получаем значение поля код только что сделанной записи в тб.Личные_данные
                int id = await GetIdLastInsertedPrivatePersonData();
                //Вносим данные в тб. Пользователи
                result = await InsertLoginPersonData(person, id);
            }
            catch (OleDbException ex)
            {
                Trace.WriteLine(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Добавление записи в тб. Пользователи
        /// </summary>
        /// <param name="person"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task<int> InsertLoginPersonData(PersonViewModel person, int id)
        {
            int result = 0;
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Пользователи (Личные_данные_Код, Логин, Пароль) " +
                                      "VALUES (@Id, @Login, @Passwd);";

                cmd.Parameters.Add(new OleDbParameter("@Id",
                    OleDbType.Integer)
                { Value = id });

                cmd.Parameters.Add(new OleDbParameter("@Login",
                    OleDbType.VarWChar)
                { Value = person.Login });

                cmd.Parameters.Add(new OleDbParameter("@Passwd",
                    OleDbType.VarWChar)
                { Value = person.Password });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }
            return result;
        }

        /// <summary>
        /// Получение Id последней записи в тб. Личные_данные
        /// </summary>
        /// <returns></returns>
        private async Task<int> GetIdLastInsertedPrivatePersonData()
        {
            int id = 0;

            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT TOP 1  Личные_данные.Код FROM Личные_данные " +
                                  "ORDER BY Личные_данные.Код DESC";
                con.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        id = reader.GetInt32(0);
                    }
                }
            }

            return id;
        }
        
        /// <summary>
        /// Добавление записи в тб. Личные_данные
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        private async Task<int> InsertPrivatePersonData(PersonViewModel person)
        {
            int result = 0;

            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Личные_данные (Имя, Фамилия, Отчество) " +
                                  "VALUES (@FName, @LName, @MName);";

                cmd.Parameters.Add(new OleDbParameter("@FName",
                    OleDbType.VarWChar)
                { Value = person.FirstName });

                cmd.Parameters.Add(new OleDbParameter("@LName",
                    OleDbType.VarWChar)
                { Value = person.LastName });

                cmd.Parameters.Add(new OleDbParameter("@MName",
                    OleDbType.VarWChar)
                { Value = person.MiddleName });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

            return result;
        }

        /// <summary>
        /// Удаление человека
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<int> RemovePersonAsync(PersonViewModel person)
        {
            int result = 0;
            try
            {
                using (var con = GetConnection())
                using (var cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Личные_данные WHERE Личные_данные.Код = @Id";

                    cmd.Parameters.Add(new OleDbParameter("@Id",
                    OleDbType.Integer)
                    { Value = person.Id });

                    con.Open();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (OleDbException ex)
            {
                Trace.WriteLine(ex);
            }
            
            return result;
        }

        /// <summary>
        /// Изменение записи о пользователе
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<int> UpdatePersonAsync(PersonViewModel person)
        {
            int result = 0;
            try
            {
                //обновляем в тб. Личные_данные
                result = await UpdatePrivatePersonData(person);
                //обновляем в тб. Пользователи
                result = await UpdateLoginPersonData(person);
            }
            catch (OleDbException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            return result;
        }

        /// <summary>
        /// Обновление записи в тб. Личные_данные
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        private async Task<int> UpdatePrivatePersonData(PersonViewModel person)
        {
            int result = 0;
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE Личные_данные" +
                    " SET Имя = @FName, Фамилия = @LName, Отчество = @MName" +
                    " WHERE Личные_данные.Код = @Id";

                cmd.Parameters.Add(new OleDbParameter("@FName",
                OleDbType.VarWChar)
                { Value = person.FirstName });

                cmd.Parameters.Add(new OleDbParameter("@LName",
                    OleDbType.VarWChar)
                { Value = person.LastName });

                cmd.Parameters.Add(new OleDbParameter("@MName",
                    OleDbType.VarWChar)
                { Value = person.MiddleName });

                cmd.Parameters.Add(new OleDbParameter("@Id",
                OleDbType.Integer)
                { Value = person.Id });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

            return result;
        }

        /// <summary>
        /// Обновление записи в тб. Пользователи
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        private async Task<int> UpdateLoginPersonData(PersonViewModel person)
        {
            int result = 0;
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE Пользователи" +
                    " SET Логин = @Login, Пароль = @Passwd" +
                    " WHERE Пользователи.Личные_данные_Код = @Id";

                cmd.Parameters.Add(new OleDbParameter("@Login",
                    OleDbType.VarWChar)
                { Value = person.Login });

                cmd.Parameters.Add(new OleDbParameter("@Passwd",
                    OleDbType.VarWChar)
                { Value = person.Password });

                cmd.Parameters.Add(new OleDbParameter("@Id",
                OleDbType.Integer)
                { Value = person.Id });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

            return result;
        }
    }
}
