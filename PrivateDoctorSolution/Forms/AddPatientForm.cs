#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.Linq;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DTD.PDS.BLL.Repo;
using DTD.PDS.Entity.DatabaseTableClasses;
using Syncfusion.Windows.Forms;

namespace PrivateDoctorSolution
{
    public partial class AddPatientForm : Syncfusion.Windows.Forms.MetroForm
    {
        private bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

       
        public AddPatientForm()
        {
            InitializeComponent();
        }

        public AddPatientForm(Patient selectedPatient)
        {
            InitializeComponent();
            NameTextBox.Text = selectedPatient.Name;
            EmailTextBox.Text = selectedPatient.Email;
            MobileTextBox.Text = selectedPatient.Mobile.ToString();
            dateTimePickerAdv1.Value = selectedPatient.AppointmentDateTime;


        }

        private void Addbutton_Click(object sender, System.EventArgs e)
        {
            Patient patient= new Patient();

            try
            {
                string name = NameTextBox.Text;
                string email=EmailTextBox.Text;
                if (!IsValid(email))
                {
                    throw new Exception("Invalid Email");
                }
                string mobileNumber = MobileTextBox.Text;
              
                if (!mobileNumber.All(char.IsDigit))
                {
                    throw  new Exception("Invalid Number");
                }
                DateTime appointmenDateTime = dateTimePickerAdv1.Value;


                patient.Name = name;
                patient.Email = email;
                patient.Mobile = Convert.ToInt32(mobileNumber);
                patient.AppointmentDateTime = appointmenDateTime;

                if (!new PatientRepo().Add(patient))
                {
                    throw new Exception("Database Error");
                }
                MessageBoxAdv.Show(this, "Operation Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult=DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBoxAdv.Show(this, ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
