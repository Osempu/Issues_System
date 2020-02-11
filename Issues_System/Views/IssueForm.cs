using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Issues_System.Controls;
using Issues_System.Models;

namespace Issues_System.Views
{
    public partial class IssueForm : UserControl
    {
        public User LogedUser { get; set; }
        public IssueForm()
        {
            InitializeComponent();

            LoadUsersCb();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbLine.Text == "" || cbEquipment.Text == "" || txtDetails.Text == "" || cbAssignedTo.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Missing Fields",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (LogedUser.Role == Role.admin)
                {
                    IssueDAL iDal = new IssueDAL();
                    //Filling issue with form data.
                    Issue issue = new Issue()
                    {
                        OpenBy = $"{this.LogedUser.Name} {this.LogedUser.LastName}",
                        AssignedTo = cbAssignedTo.Text,
                        Line = cbLine.Text,
                        Equipment = cbEquipment.Text,
                        Details = txtDetails.Text,
                        OpenAt = DateTime.Now.TimeOfDay,
                    };

                    if (iDal.Insert(issue) > 0)
                    {
                        ClearFields();
                        MessageBox.Show("Issue Submited.", "Issue Submited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The issue was not submited due to an error", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Only admins can open issues", "Not authorized",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            cbLine.SelectedIndex = -1;
            cbEquipment.SelectedIndex = -1;
            txtDetails.Text = "";
            cbAssignedTo.SelectedIndex = -1;
        }

        private void LoadUsersCb()
        {
            UserDAL userDAL = new UserDAL();
            cbAssignedTo.DataSource = userDAL.AllUsersNames();
            cbAssignedTo.SelectedIndex = -1;
        }
    }
}
