using Microsoft.Data.SqlClient;

namespace JobSeeker.Models
{
    public class DB
    {
        static private string CONNECTION_STRING = "Data Source=DESKTOP-AC9THNH;Initial Catalog=Practice;Integrated Security=True;Encrypt=False;";
        static private SqlConnection Connection = new SqlConnection(CONNECTION_STRING);

        public static SqlConnection GetConnection()
        {
            Connection.Open();
            return Connection;
        }
    }
}
