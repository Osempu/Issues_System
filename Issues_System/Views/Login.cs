using Issues_System.Controls;
using Issues_System.Models;
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
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            UserDAL uDal = new UserDAL();

            if (uDal.Login(username, password) > 0)
            {
                User loguedUser = uDal.GetLogedUser(username, password);

                MainForm mainForm = new MainForm(loguedUser);
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
