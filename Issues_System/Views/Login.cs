using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Issues_System.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connstring = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connstring))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("splogin",connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output;
                    var result = cmd.Parameters.Add("@result", SqlDbType.Int);
                    result.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();

                    int connected = Convert.ToInt32(result.Value);
                    if (connected == 1)
                    {
                        MessageBox.Show("Login Succesfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm mainForm = new MainForm();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or password inccorect!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
