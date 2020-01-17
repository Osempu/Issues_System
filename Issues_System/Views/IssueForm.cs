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
        public IssueForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cbLine.Text == "" || cbEquipment.Text == "" || txtDetails.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Missing Fields",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IssueDAL iDal = new IssueDAL();
                //Filling issue with form data.
                Issue issue = new Issue()
                {
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
        }

        private void ClearFields()
        {
            cbLine.SelectedIndex = -1;
            cbEquipment.SelectedIndex = -1;
            txtDetails.Text = "";
        }
    }
}
