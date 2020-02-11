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

        public DataTable OpenIssues()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                DataTable dt = new DataTable(); ;

                conn.Open();

                string sqlCmd = "select * from Issues where IsClosed = @IsClosed";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@IsClosed", false);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    conn.Close();
                }
                return dt;
            }
        }

        public DataTable ClosedIssues()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                DataTable dt = new DataTable(); ;

                conn.Open();

                string sqlCmd = "select * from Issues where IsClosed = @IsClosed";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@IsClosed", true);

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
                string sqlCmd = "Insert into Issues(OpenBy, AssignedTo, Line, Equipment, Details, OpenAt, IsClosed) values (@OpenBy, @AssignedTo,@Line, @Equipment, @Details, @OpenAt, @IsClosed)";

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@OpenBy", issue.OpenBy);
                    cmd.Parameters.AddWithValue("@AssignedTo", issue.AssignedTo);
                    cmd.Parameters.AddWithValue("@Line", issue.Line);
                    cmd.Parameters.AddWithValue("@Equipment", issue.Equipment);
                    cmd.Parameters.AddWithValue("@Details", issue.Details);
                    cmd.Parameters.AddWithValue("@OpenAt", issue.OpenAt);
                    cmd.Parameters.AddWithValue("@IsClosed", false);

                    succes = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return succes;
        }

        public Issue FIndById(int id)
        {
            Issue returnedIssue = new Issue();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string sqlString = "Select * from Issues where id = @id";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlString, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            returnedIssue.Id = Convert.ToInt32(reader["Id"]);
                            returnedIssue.Line = reader["Line"].ToString();
                            returnedIssue.Equipment = reader["Equipment"].ToString();
                            returnedIssue.Details = reader["Details"].ToString();
                            returnedIssue.Solution = reader["Solution"].ToString();
                            returnedIssue.OpenAt = TimeSpan.Parse(reader["OpenAt"].ToString());

                            if (TimeSpan.TryParse(reader["TimeOpen"].ToString(), out TimeSpan TimeOpen) && 
                                TimeSpan.TryParse(reader["ClosedAt"].ToString(), out TimeSpan ClosedAt))
                            {
                                returnedIssue.TimeOpen = TimeOpen;
                                returnedIssue.ClosedAt = ClosedAt;
                            }
                        }
                }
                conn.Close();
            }
            return returnedIssue;
        }

        public int Close(int id, string solution, TimeSpan timeOpen, TimeSpan closedAt)
        {
            int succes = 0;

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string sqlCmd = "update issues set Solution = @Solution, TimeOpen = @TimeOpen, " +
                    "ClosedAt = @ClosedAt, IsClosed = @IsClosed where Id = @Id";
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    cmd.Parameters.AddWithValue("@Solution", solution);
                    cmd.Parameters.AddWithValue("@TimeOpen", timeOpen);
                    cmd.Parameters.AddWithValue("@ClosedAt", closedAt);
                    cmd.Parameters.AddWithValue("@IsClosed", true);
                    cmd.Parameters.AddWithValue("@Id", id);

                    succes = cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
            return succes;
        }

    }
}

