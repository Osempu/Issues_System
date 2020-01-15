using Issues_System.Models;
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
                    conn.Close();
                }
                return dt;
            }
        }

        public int Insert(Issue issue)
        {
            int succes = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string sqlCmd = "Insert into Issues(Line, Equipment, Details, OpenAt ) values (@Line, @Equipment, @Details, @OpenAt)";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@Line", issue.Line);
                    cmd.Parameters.AddWithValue("@Equipment", issue.Equipment);
                    cmd.Parameters.AddWithValue("@Details", issue.Details);
                    cmd.Parameters.AddWithValue("@OpenAt", issue.OpenAt);

                    succes = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return succes;
        }
    }
}
