using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrivateDoctorSolution.Forms;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class PrescriptionControl : UserControl
    {
        public PrescriptionControl()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPrescription AP = new AddPrescription("Prescription");
            AP.ShowDialog(this);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            AddPrescription AP = new AddPrescription("Test");
            AP.ShowDialog(this);
        }
    }
}
