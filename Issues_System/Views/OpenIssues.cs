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
    public partial class OpenIssues : UserControl
    {
        public OpenIssues()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            IssueDAL iDal = new IssueDAL();

            if (dgvOpenIssues.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvOpenIssues.CurrentRow.Cells[0].Value);

                Issue issue = iDal.FIndById(id);

                issue.TimeOpen = TimeSpan.Zero;
                issue.ClosedAt = TimeSpan.Zero;

                CloseIssueForm closeForm = new CloseIssueForm(issue);
                closeForm.ShowDialog();

                dgvOpenIssues.DataSource = iDal.OpenIssues();
            }
            else
            {
                MessageBox.Show("Please select a row first", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
