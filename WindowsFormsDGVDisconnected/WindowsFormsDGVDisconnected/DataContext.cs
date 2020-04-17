using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDGVDisconnected
{
    public class DataContext
    {
        private const string _cnnString = @"Data Source=(localdb)\MSSQLLocalDB;" +
            "Initial Catalog=DatabaseDGVDisconnected;Integrated Security=True;" +
            "Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;" +
            "ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


    }
}
