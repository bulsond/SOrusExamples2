using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace WindowsFormsDGVDisconnected
{
    public class DataContext
    {
        private const string _cnnString = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=DatabaseDGVDisconnected;Integrated Security=True;" +
            "Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DataTable GetRealEstatesOrNull()
        {
            DataTable table = null;
            try
            {
                using (var cnn = new SqlConnection(_cnnString))
                using (var cmd = cnn.CreateCommand())
                using (var adp = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = "SELECT * FROM RealEstates";
                    table = new DataTable();
                    int affected = adp.Fill(table);
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return table;
        }

        public DataTable UpdateRealEstatesOrNull(DataTable dataTable)
        {
            DataTable resultTable = null;
            try
            {
                using (var cnn = new SqlConnection(_cnnString))
                using (var cmd = cnn.CreateCommand())
                using (var adp = new SqlDataAdapter(cmd))
                {
                    cmd.CommandText = "SELECT * FROM RealEstates";
                    using (var bld = new SqlCommandBuilder(adp))
                    {
                        int affected = adp.Update(dataTable);
                        resultTable = dataTable;
                    }
                }
            }
            catch (SqlException ex)
            {
                Debug.WriteLine(ex.Message);
            }

            return resultTable;
        }
    }
}
