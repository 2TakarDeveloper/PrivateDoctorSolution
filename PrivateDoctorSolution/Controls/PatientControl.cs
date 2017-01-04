using PrivateDoctorSolution.Forms;
using System;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Controls
{
    public partial class PatientControl : UserControl
    {
        public PatientControl()
        {
            InitializeComponent();
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddPatientForm aform = new AddPatientForm();
            aform.ShowDialog(this);
        }
    }
}
