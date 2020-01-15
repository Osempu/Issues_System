using Issues_System.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Issues_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnSelector.Hide();
            HideViews();
        }

        IssueDAL iDal = new IssueDAL();


        private void btnOpenIssue_Click(object sender, EventArgs e)
        {
            ButtonGeneralFunction(btnOpenIssue, issueForm);
        }

        private void btnAttendIssue_Click(object sender, EventArgs e)
        {
            ButtonGeneralFunction(btnAttendIssue, openIssues);

            openIssues.dgvOpenIssues.DataSource = iDal.Select();
        }

        private void btnIssueHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void HideViews()
        {
            issueForm.Hide();
            openIssues.Hide();
        }

        private void ButtonGeneralFunction(Button btn, UserControl uc)
        {
            issueForm.Hide();
            openIssues.Hide();

            uc.Show();

            btnSelector.Height = btn.Height;
            btnSelector.Top = btn.Top;
            btnSelector.Show();
        }
    }
}
