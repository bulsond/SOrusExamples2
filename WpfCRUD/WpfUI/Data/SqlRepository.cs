using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using WpfUI.Models;

namespace WpfUI.Data
{
    class SqlRepository : IEmployeeRepository
    {
        private readonly SqlConnection _connection;

        public SqlRepository()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"(localdb)\MSSQLLocalDB";
            builder.InitialCatalog = "WpfCRUDDatabase";
            builder.IntegratedSecurity = true;

            _connection = new SqlConnection(builder.ConnectionString);
        }

        public async Task<int> AddEmployee(Employee employee)
        {
            int result = 0;
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Employees (LastName, FirstName, Phone)" +
                        " VALUES(@lastName, @firstName, @phone)";

                    cmd.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar, 100)
                    { Value = employee.FirstName });

                    cmd.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar, 150)
                    { Value = employee.LastName });

                    cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 100)
                    {
                        Value = employee.Phone ?? (object)System.DBNull.Value
                    });

                    if (_connection.State == ConnectionState.Closed)
                     await _connection.OpenAsync();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return result;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var list = new List<Employee>();

            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Employees";
                    if (_connection.State == ConnectionState.Closed)
                        await _connection.OpenAsync();
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var emp = new Employee(reader.GetInt32(0));
                            emp.FirstName = reader.GetString(1);
                            emp.LastName = reader.GetString(2);
                            emp.Phone = reader.GetString(3);

                            list.Add(emp);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return list;
        }

        public async Task<int> RemoveEmployee(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            int result = 0;
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Employees WHERE Id =@id";

                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)
                    { Value = id });

                    if (_connection.State == ConnectionState.Closed)
                        await _connection.OpenAsync();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return result;
        }

        public async Task<int> UpdateEmployee(Employee emp)
        {
            int result = 0;
            try
            {
                using (var cmd = _connection.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Employees" +
                        " SET FirstName = @firstName, LastName = @lastName, Phone = @phone" +
                        " WHERE Id =@id";

                    cmd.Parameters.Add(new SqlParameter("@firstName", SqlDbType.NVarChar, 100)
                    { Value = emp.FirstName });

                    cmd.Parameters.Add(new SqlParameter("@lastName", SqlDbType.NVarChar, 150)
                    { Value = emp.LastName });

                    cmd.Parameters.Add(new SqlParameter("@phone", SqlDbType.NVarChar, 100)
                    {
                        Value = emp.Phone ?? (object)System.DBNull.Value
                    });

                    cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)
                    { Value = emp.Id });

                    if (_connection.State == ConnectionState.Closed)
                        await _connection.OpenAsync();
                    result = await cmd.ExecuteNonQueryAsync();
                }

            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return result;
        }
    }
}
