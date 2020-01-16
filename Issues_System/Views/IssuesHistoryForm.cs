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
    public partial class IssuesHistoryForm : Form
    {
        public IssuesHistoryForm(Issue issue)
        {
            InitializeComponent();

            LoadData(issue);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(Issue issue)
        {
            txtId.Text = issue.Id.ToString();
            txtLine.Text = issue.Line;
            txtEquipment.Text = issue.Equipment;
            txtDetails.Text = issue.Details;
            txtSolution.Text = issue.Solution;
            txtTime.Text = issue.OpenAt.ToString(@"hh\:mm\:ss");
        }
    }
}
