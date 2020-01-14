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
    public partial class IssueForm : UserControl
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IssueDAL iDal = new IssueDAL();

            DateTime issueTime = DateTime.Now;

            iDal.Insert(cbLine.Text, cbEquipment.Text, txtDetails.Text, issueTime);
        }
    }
}
