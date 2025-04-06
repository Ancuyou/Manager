using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Database
{
    public abstract class DbConnection
    {
        private readonly string connectionString;
        public DbConnection()
        {
            connectionString = "Data Source =.; Initial Catalog = CoffeeShopManagement_Demo1; Persist Security Info = True; User ID = sa; Password = 123; TrustServerCertificate = True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
