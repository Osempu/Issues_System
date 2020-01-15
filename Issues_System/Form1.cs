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
        }

        private void btnOpenIssue_Click(object sender, EventArgs e)
        {
            btnSelector.Height = btnOpenIssue.Height;
            btnSelector.Top = btnOpenIssue.Top;
        }

        private void btnAttendIssue_Click(object sender, EventArgs e)
        {
            btnSelector.Height = btnAttendIssue.Height;
            btnSelector.Top = btnAttendIssue.Top;
        }

        private void btnIssueHistory_Click(object sender, EventArgs e)
        {
            btnSelector.Height = btnIssueHistory.Height;
            btnSelector.Top = btnIssueHistory.Top;
        }
    }
}
