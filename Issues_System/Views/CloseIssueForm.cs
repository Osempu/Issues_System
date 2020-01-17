using Issues_System.Controls;
using Issues_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Issues_System.Views
{
    public partial class CloseIssueForm : Form
    {
        public CloseIssueForm(Issue issue)
        {
            InitializeComponent();

            LoadData(issue);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtSolution.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Missing Fields",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IssueDAL iDal = new IssueDAL();
                TimeSpan timeOpen = DateTime.Now.TimeOfDay - TimeSpan.Parse(txtTime.Text);
                TimeSpan closedAt = DateTime.Now.TimeOfDay;

                int error = iDal.Close(Convert.ToInt32(txtId.Text), txtSolution.Text, timeOpen, closedAt);

                if (error > 0)
                {
                    MessageBox.Show("Issue closed succesfully.", "Issue Closed", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Issue was not closed due to an error.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadData(Issue issue)
        {
            txtId.Text = issue.Id.ToString();
            txtLine.Text = issue.Line;
            txtEquipment.Text = issue.Equipment;
            txtDetails.Text = issue.Details;
            txtTime.Text = issue.OpenAt.ToString(@"hh\:mm\:ss");
        }
    }
}
