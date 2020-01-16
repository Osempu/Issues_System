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
    public partial class IssuesHistory : UserControl
    {
        public IssuesHistory()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            IssueDAL iDal = new IssueDAL();

            if (dgvIssuesHistory.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvIssuesHistory.CurrentRow.Cells[0].Value);

                Issue issue = iDal.FIndById(id);

                IssuesHistoryForm closeForm = new IssuesHistoryForm(issue);
                closeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row first", "Row not selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
