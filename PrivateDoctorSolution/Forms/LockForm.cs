#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using DTD.PDS.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Forms
{
    public partial class LockForm : Syncfusion.Windows.Forms.MetroForm
    {
        public LockForm()
        {
            InitializeComponent();
            ActiveUser.isLocked = true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            e.Cancel = ActiveUser.isLocked;
        }

        private void textBoxExt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LockForm_Load(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            if(passwordtext.Text.Equals("system"))
            {
                ActiveUser.isLocked = false;
                this.Close();
            }
        }
    }
}
