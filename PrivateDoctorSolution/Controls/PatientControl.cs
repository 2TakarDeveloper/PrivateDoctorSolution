using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTD.PDS.BLL.Repo;
using DTD.PDS.Entity.DatabaseTableClasses;
using PrivateDoctorSolution.Controls.Prescription;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace PrivateDoctorSolution.Controls
{
    public partial class PatientControl : UserControl
    {
        private List<Patient> SelectedPatients { get; set; }
        private NavigationDrawer NavigationDrawer { get; set; }
        public PatientControl(NavigationDrawer navigationDrawer)
        {
            InitializeComponent();
            NavigationDrawer = navigationDrawer;
            SelectedPatients =new List<Patient>();
            LoadPatientList();
        }

        private void LoadPatientList()
        {
            PatientDataGrid.DataSource=new PatientRepo().GetAll();
        }
      

        private void Addbtn_Click(object sender, EventArgs e)
        {
            AddPatientForm aform = new AddPatientForm();
            if (aform.ShowDialog(this) == DialogResult.OK)
            {
                LoadPatientList();
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            PatientDataGrid.DataSource = null;
            PatientDataGrid.DataSource = new PatientRepo().GetAllByName(SearchBox.Text);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            AddPatientForm aform = new AddPatientForm(SelectedPatients[0]);
            if (aform.ShowDialog(this) == DialogResult.OK)
            {
                LoadPatientList();
            }



        }

        private void PatientDataGrid_Click(object sender, EventArgs e)
        {
            var length = PatientDataGrid.SelectedRows.Count;
            SelectedPatients = new List<Patient>();
            for (var i = 0; i < length; i++)
            {
                SelectedPatients.Add((Patient)PatientDataGrid.SelectedRows[i].DataBoundItem);
            }
            PrescriptionButton.Enabled = length > 0;


        }

        private void DeletetButton_Click(object sender, EventArgs e)
        {
            if (SelectedPatients != null)
            {
                if (new PatientRepo().Remove(SelectedPatients))
                {
                    LoadPatientList();
                }
                else
                {
                    
                    MessageBoxAdv.Show(this, "Database Error!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrescriptionButton_Click(object sender, EventArgs e)
        {
            NavigationDrawer.ContentViewContainer.Controls.Clear();
            PrescriptionControl pc = new PrescriptionControl(NavigationDrawer, SelectedPatients[0].Id) { Dock = DockStyle.Fill };
            NavigationDrawer.ContentViewContainer.Controls.Add(pc);
        }
    }
}
