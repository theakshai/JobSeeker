using Microsoft.Data.SqlClient;

namespace JobSeeker.Models
{

    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Salary { get; set; }
        public string Company { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }

        /*
    public Job(SqlDataReader reader)
        {
            Id = Convert.ToInt32(reader["Id"]);
            Name = reader["Name"].ToString();
            Description = reader["Description"].ToString();
            Salary = Convert.ToDecimal(reader["Salary"]);
            Company = reader["Company"].ToString();
            Area = reader["Area"].ToString();
            Category = reader["Category"].ToString();
        }
  }

    public class JobManager
    {

        public static List<Job> SearchJobs(string query)
        {
            List<Job> jobs = new List<Job>();

            SqlConnection connection = DB.GetConnection();
            

            string sqlQuery = "SELECT * FROM dbo.Job " +
                                "WHERE Name LIKE '%' + @Query + '%' OR " +
                                "Description LIKE '%' + @Query + '%' OR " +
                                "Company LIKE '%' + @Query + '%' OR " +
                                "Area LIKE '%' + @Query + '%' OR " +
                                "Category LIKE '%' + @Query + '%';";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sqlQuery;

            cmd.Parameters.AddWithValue("@Query", query);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Job job = new Job(reader);
                    jobs.Add(job);
                }
            }
            connection.Close();
            return jobs;
        }

        public static List<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>();

            SqlConnection connection = DB.GetConnection();


            string sqlQuery = "SELECT * FROM dbo.Job ";
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sqlQuery;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Job job = new(reader);
                    jobs.Add(job);
                }
            }
            connection.Close();
            return jobs;
        }

    }
        */
    }
}
