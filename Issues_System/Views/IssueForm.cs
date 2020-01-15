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
            IssueDAL iDal = new IssueDAL();
            //Filling issue with form data.
            Issue issue = new Issue()
            {
                Line = cbLine.Text,
                Equipment = cbEquipment.Text,
                Details = txtDetails.Text,
                OpenAt = DateTime.Now.TimeOfDay,
            };

            iDal.Insert(issue);
        }
    }
}
