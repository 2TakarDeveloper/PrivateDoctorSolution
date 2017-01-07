using System;
using System.Windows.Forms;
using DTD.PDS.BLL.Repo;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class MedicineControl : UserControl
    {
        public Medication Medication { get; set; }

        public MedicineControl(Medication medication)
        {
            InitializeComponent();
            Medication = medication;
            NameBox.Text = medication.MedicineName;
            IntervalTextBox.Text = medication.Interval.ToString();
            StartDate.Value = medication.StartDate;
            EndDate.Value = medication.EndDate;
        }

        public MedicineControl()
        {
            Medication=new Medication();
            InitializeComponent();
            Medication.StartDate = StartDate.Value;
            Medication.EndDate = EndDate.Value;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            new MedicationRepo().Remove(Medication);
            Dispose();
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Medication.MedicineName = NameBox.Text;
        }

        private void StartDate_ValueChanged(object sender, EventArgs e)
        {
            Medication.StartDate = StartDate.Value;
        }

        private void EndDate_ValueChanged(object sender, EventArgs e)
        {
            Medication.EndDate = EndDate.Value;
        }

        private void IntervalTextBox_TextChanged(object sender, EventArgs e)
        {
            Medication.Interval = Convert.ToInt32(IntervalTextBox.Text);
        }
    }
}
