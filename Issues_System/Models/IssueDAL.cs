using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Issues_System.Models
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
    }
}
