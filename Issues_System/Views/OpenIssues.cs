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

namespace Issues_System.Views
{
    public partial class OpenIssues : UserControl
    {
        public OpenIssues()
        {
            InitializeComponent();
        }

        private void OpenIssues_Load(object sender, EventArgs e)
        {
            IssueDAL iDal = new IssueDAL();

            dgvOpenIssues.DataSource = iDal.Select();
        }
    }
}
