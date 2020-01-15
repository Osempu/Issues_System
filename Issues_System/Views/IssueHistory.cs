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
    public partial class IssueHistory : UserControl
    {
        public IssueHistory()
        {
            InitializeComponent();
        }

        private void IssueHistory_Load(object sender, EventArgs e)
        {
            IssueDAL iDal = new IssueDAL();

            dgvIssuesHistory.DataSource = iDal.Select();
        }
    }
}
