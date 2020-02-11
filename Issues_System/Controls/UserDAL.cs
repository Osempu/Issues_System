using Issues_System.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Issues_System.Controls
{
    class UserDAL
    {
        private static string connstring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public int Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                int connected = 0;

                try
                {
                    using (SqlCommand cmd = new SqlCommand("splogin", connection))
                    {
                        connection.Open();

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
                        var result = cmd.Parameters.Add("@result", SqlDbType.Int);
                        result.Direction = ParameterDirection.ReturnValue;
                        cmd.ExecuteNonQuery();

                        connected = Convert.ToInt32(result.Value);

                        if (connected == 1)
                        {
                            MessageBox.Show("Login Succesfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            connection.Close();
                            return connected;
                        }
                        else
                        {
                            MessageBox.Show("Username or password is inccorect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    return connected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        public User GetLogedUser(string username, string password)
        {
            User logedUser = new User();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                try
                {
                    string sql = "Select * from Users where Username = @username and Password = @password";

                    using (SqlCommand comd = new SqlCommand(sql, conn))
                    {
                        conn.Open();

                        comd.Parameters.AddWithValue("@username", username);
                        comd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = comd.ExecuteReader())
                            while (reader.Read())
                            {
                                logedUser.Id = Convert.ToInt32(reader["Id"]);
                                logedUser.Username = reader["Username"].ToString();
                                logedUser.Name = reader["Name"].ToString();
                                logedUser.LastName = reader["LastName"].ToString();
                                logedUser.Role = (Role)Enum.Parse(typeof(Role), reader["Role"].ToString());
                            }
                        return logedUser;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public List<string> AllUsersNames()
        {
            List<string> users = new List<string>();

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                string sqlCmd = "Select Id, Name, LastName from Users where Role = 'user'";

                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sqlCmd, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add($"{reader["Name"]} {reader["LastName"]}");
                        }
                    }
                }
            }

            return users;
        }
    }
}
