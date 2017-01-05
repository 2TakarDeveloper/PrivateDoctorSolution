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
using Syncfusion.Windows.Forms.Tools;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class PrescriptionControl : UserControl
    {
        private NavigationDrawer NavigationDrawer { get; set; }

        public PrescriptionControl(NavigationDrawer navigationDrawer, int id)
        {
            InitializeComponent();
            NavigationDrawer = navigationDrawer;
         
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddPrescription ap = new AddPrescription("Prescription");
            ap.ShowDialog(this);
        }

        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            AddPrescription ap = new AddPrescription("Test");
            ap.ShowDialog(this);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            NavigationDrawer.ContentViewContainer.Controls.Clear();
            PatientControl pc = new PatientControl(NavigationDrawer) { Dock = DockStyle.Fill };
            NavigationDrawer.ContentViewContainer.Controls.Add(pc);
        }
    }
}
