using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();
        }

        public TestControl(Test test )
        {
            InitializeComponent();
            NameTextBox.Text = test.TestName;
            IssueDate.Value = test.IssueDate;
            StatusComboBox.Text = test.Status.ToString();
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
