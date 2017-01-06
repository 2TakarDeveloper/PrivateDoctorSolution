using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using DTD.PDS.Entity.DatabaseTableClasses;
using System.Windows.Forms;
using DTD.PDS.BLL.Repo;
using PrivateDoctorSolution.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class PrescriptionControl : UserControl
    {
        private NavigationDrawer NavigationDrawer { get; set; }
        private List<Medication> Medications { get; set; }
        private List<DTD.PDS.Entity.DatabaseTableClasses.Prescription > Prescriptions { get; set; }
        private DTD.PDS.Entity.DatabaseTableClasses.Prescription Prescription { get; set; }
        private List<Test> Tests { get; set; }

        public PrescriptionControl(NavigationDrawer navigationDrawer, int id)
        {
            InitializeComponent();
            NavigationDrawer = navigationDrawer;
            Prescriptions = new PrescriptionRepo().GetAll(id);


            if (Prescriptions.Count <= 0) return;
            Prescription = Prescriptions[0];
            DateTime.Value = Prescription.IssueDate;
            LoadTests();
            LoadMedications();
        }

        private void LoadTests()
        {
            Tests = new TestRepo().GetAll(Prescription.Id);
            foreach (var test in Tests)
            {
                TestPanel.Controls.Add(new TestControl(test));
            }
        }

        private void LoadMedications()
        {
            Medications = new MedicationRepo().GetAll(Prescription.Id);
            foreach (var medication in Medications)
            {
                MedicinePanel.Controls.Add(new MedicineControl(medication));
            }


        }

       

     

        private void BackButton_Click(object sender, EventArgs e)
        {
            NavigationDrawer.ContentViewContainer.Controls.Clear();
            PatientControl pc = new PatientControl(NavigationDrawer) { Dock = DockStyle.Fill };
            NavigationDrawer.ContentViewContainer.Controls.Add(pc);
        }

        private void AddButtonTest_Click(object sender, EventArgs e)
        {
            TestPanel.Controls.Add(new TestControl());
        }

        private void AddButtonMedicine_Click(object sender, EventArgs e)
        {
            MedicinePanel.Controls.Add(new MedicineControl());
        }
    }
}
