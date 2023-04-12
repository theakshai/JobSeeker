using Microsoft.Data.SqlClient;
public class DB
{
    static private string CONNECTION_STRING = "Data Source=DESKTOP-AC9THNH;Initial Catalog=Practice;Integrated Security=True;Encrypt=False;";
    static public SqlConnection Connection = new SqlConnection(CONNECTION_STRING);
}
