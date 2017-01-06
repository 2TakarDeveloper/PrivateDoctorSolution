#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using PrivateDoctorSolution.Controls;
using PrivateDoctorSolution.Controls.Prescription;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Forms
{
    public partial class AddPrescription : Syncfusion.Windows.Forms.MetroForm
    {
        public AddPrescription(String type)
        {
            InitializeComponent();



            if (type.Equals("Prescription")) LoadMedicine();
            if (type.Equals("Test")) LoadTest();
        }
        private void LoadMedicine()
        {
            MedicineControl mc = new MedicineControl();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(mc);
        }
        private void LoadTest()
        {
            TestControl tc = new TestControl();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.Add(tc);
        }
    }
}
