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
        private int Id { get; set; }
        private List<DTD.PDS.Entity.DatabaseTableClasses.Prescription > Prescriptions { get; set; }
        private DTD.PDS.Entity.DatabaseTableClasses.Prescription Prescription { get; set; }
        private List<Test> Tests { get; set; }

       

        public PrescriptionControl(NavigationDrawer navigationDrawer, int id)
        {
            InitializeComponent();
            NavigationDrawer = navigationDrawer;
            Id = id;

            LoadPrescription(id);



        }

        private void LoadPrescription(int patientid)
        {
            Prescriptions = new PrescriptionRepo().GetAll(patientid);
            foreach (var prescription in Prescriptions)
            {
                PrescriptionID.Items.Add(prescription.Id);
            }

            if (Prescriptions.Count > 0)
            {
                Prescription = Prescriptions[0];
                PrescriptionID.Text = Prescription.Id.ToString();
                DateTime.Value = Prescription.IssueDate;
                LoadTests();
                LoadMedications();
            }
            else
            {
                Prescription = new DTD.PDS.Entity.DatabaseTableClasses.Prescription();

            }
        }

        private void LoadTests()
        {
            Tests = new TestRepo().GetAll(Prescription.Id);
            TestPanel.Controls.Clear();
            foreach (var test in Tests)
            {
                TestPanel.Controls.Add(new TestControl(test));
            }
        }

        private void LoadMedications()
        {
            Medications = new MedicationRepo().GetAll(Prescription.Id);
            MedicinePanel.Controls.Clear();
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

        private void PrescriptionID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Prescription = Prescriptions[PrescriptionID.SelectedIndex];
                PrescriptionID.Text = Prescription.Id.ToString();
                DateTime.Value = Prescription.IssueDate;
                LoadTests();
                LoadMedications();
            }
            catch (Exception)
            {
                TestPanel.Controls.Clear();
                MedicinePanel.Controls.Clear();
            }
           
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Prescription = new DTD.PDS.Entity.DatabaseTableClasses.Prescription
            {
                Id = PrescriptionID.Items.Count + 1,
                IssueDate = System.DateTime.Now
            };
            PrescriptionID.Items.Add(Prescription.Id);
            PrescriptionID.Text = Prescription.Id.ToString();

            TestPanel.Controls.Clear();
            MedicinePanel.Controls.Clear();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //Prescription
            Prescription.PatientId = Id;
            
            if (!new PrescriptionRepo().Update(Prescription))
            {
                if (!new PrescriptionRepo().Add(Prescription))
                {
                    MessageBox.Show("Failed");
                }
            }
           
          
            //medication
            foreach (MedicineControl medicineControl in MedicinePanel.Controls)
            {

                Medication medication = medicineControl.Medication;
                if (medication.Id == 0)
                {
                    medication.PrescriptionId = Prescription.Id;
                    new MedicationRepo().Add(medication);
                }
                else
                {
                    new MedicationRepo().Update(medication);
                }


            }
            //Test
            foreach (TestControl testControl in TestPanel.Controls)
            {

                Test test = testControl.Test;
                if (test.Id == 0)
                {
                    test.PrescriptionId = Prescription.Id;
                    new TestRepo().Add(test);
                }
                else
                {
                    new TestRepo().Update(test);
                }


            }


        }

        private void PrintButton_Click(object sender, EventArgs e)
        {

        }
    }
}
