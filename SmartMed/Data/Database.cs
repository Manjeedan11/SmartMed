using System.Configuration;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class Database
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["SmartMed"].ConnectionString;

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
