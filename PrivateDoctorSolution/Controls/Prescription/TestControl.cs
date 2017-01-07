using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.PDS.BLL.Repo;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class TestControl : UserControl
    {
      public  Test Test { get; set; }

        public TestControl()
        {
            
            InitializeComponent();
            Test = new Test();
            Test.IssueDate = IssueDate.Value;
        }

        public TestControl(Test test )
        {
            InitializeComponent();
            Test = test;
            NameTextBox.Text = test.TestName;
            IssueDate.Value = test.IssueDate;
            StatusComboBox.Text = test.Status.ToString();
        }


        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            new TestRepo().Remove(Test);
            Dispose();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Test.TestName = NameTextBox.Text;
            
        }

        private void IssueDate_ValueChanged(object sender, EventArgs e)
        {
            Test.IssueDate = IssueDate.Value;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (StatusComboBox.Text)
            {
                case "Pending":
                    Test.Status=Status.Pending;
                    break;
                case "Complete":
                    Test.Status = Status.Complete;
                    break;
                case "Redo":
                    Test.Status = Status.Redo;
                    break;
                default:
                    Test.Status = Status.Pending;
                    break;
            }
        }
    }
}
