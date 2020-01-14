using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues_System.Controls
{
    class IssueDAL
    {
        private static string connstring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DataTable Select()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                DataTable dt = new DataTable(); ;

                conn.Open();

                string sqlCmd = "select * from Issues";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                return dt;
            }
        }

        public int Insert(string Line, string Equipment, string Details, DateTime time)
        {
            int succes = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string sqlCmd = "Insert into Issues(Line, Equipment, Details, IssueTime ) values (@Line, @Equipment, @Details, @IssueTime)";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@Line", Line);
                    cmd.Parameters.AddWithValue("@Equipment", Equipment);
                    cmd.Parameters.AddWithValue("@Details", Details);
                    cmd.Parameters.AddWithValue("@IssueTime", time);

                    succes = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            return succes;
        }
    }
}
