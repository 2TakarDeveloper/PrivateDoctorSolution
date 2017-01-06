using System.Windows.Forms;
using DTD.PDS.Entity.DatabaseTableClasses;

namespace PrivateDoctorSolution.Controls.Prescription
{
    public partial class MedicineControl : UserControl
    {
        public MedicineControl(Medication medication)
        {
            InitializeComponent();
            NameBox.Text = medication.MedicineName;
            IntervalTextBox.Text = medication.Interval.ToString();
            StartDate.Value = medication.StartDate;
            EndDate.Value = medication.EndDate;
        }

        public MedicineControl()
        {
            InitializeComponent();

        }

        private void buttonAdv1_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }
    }
}
