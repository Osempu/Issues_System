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

        public User Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connstring))
            {
                User logedUser = new User();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand("splogin", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    var result = cmd.Parameters.Add("@result", SqlDbType.Int);
                    result.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();

                    int connected = Convert.ToInt32(result.Value);
                    if (connected == 1)
                    {
                        MessageBox.Show("Login Succesfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        string sql = "Select * from Users where Username = @username and Password = @password";

                        using (SqlCommand comd = new SqlCommand(sql, connection))
                        {
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
                        }
                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or password inccorect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return logedUser;
            }
        }
    }
}
