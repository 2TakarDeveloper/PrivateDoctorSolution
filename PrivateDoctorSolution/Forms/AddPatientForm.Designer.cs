#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PrivateDoctorSolution.Forms
{
    partial class AddPatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerAdv1 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt3 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Addbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label2.Location = new System.Drawing.Point(29, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mobile No :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.label4.Location = new System.Drawing.Point(29, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Appointment Date :";
            // 
            // dateTimePickerAdv1
            // 
            this.dateTimePickerAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dateTimePickerAdv1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateTimePickerAdv1.CalendarForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv1.CalendarSize = new System.Drawing.Size(189, 176);
            this.dateTimePickerAdv1.DropDownImage = null;
            this.dateTimePickerAdv1.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.dateTimePickerAdv1.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.dateTimePickerAdv1.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(175)))), ((int)(((byte)(67)))));
            this.dateTimePickerAdv1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dateTimePickerAdv1.Location = new System.Drawing.Point(185, 135);
            this.dateTimePickerAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.dateTimePickerAdv1.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv1.Name = "dateTimePickerAdv1";
            this.dateTimePickerAdv1.Size = new System.Drawing.Size(268, 23);
            this.dateTimePickerAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.dateTimePickerAdv1.TabIndex = 4;
            this.dateTimePickerAdv1.Value = new System.DateTime(2017, 1, 4, 0, 35, 4, 416);
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(268, 29);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.Location = new System.Drawing.Point(185, 97);
            this.textBoxExt1.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(268, 29);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 11;
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(268, 29);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt2.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.Location = new System.Drawing.Point(185, 57);
            this.textBoxExt2.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Size = new System.Drawing.Size(268, 29);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt2.TabIndex = 12;
            // 
            // textBoxExt3
            // 
            this.textBoxExt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.textBoxExt3.BeforeTouchSize = new System.Drawing.Size(268, 29);
            this.textBoxExt3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxExt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt3.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt3.Location = new System.Drawing.Point(185, 17);
            this.textBoxExt3.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.textBoxExt3.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt3.Name = "textBoxExt3";
            this.textBoxExt3.Size = new System.Drawing.Size(268, 29);
            this.textBoxExt3.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt3.TabIndex = 13;
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Addbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Addbtn.BeforeTouchSize = new System.Drawing.Size(74, 37);
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Addbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Addbtn.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.Addbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbtn.IsBackStageButton = false;
            this.Addbtn.KeepFocusRectangle = false;
            this.Addbtn.Location = new System.Drawing.Point(379, 170);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Addbtn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(74, 37);
            this.Addbtn.TabIndex = 14;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addbtn.UseVisualStyle = true;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderThickness = 5;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(496, 219);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textBoxExt3);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.dateTimePickerAdv1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Name = "AddPatientForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dateTimePickerAdv1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt3;
        private Syncfusion.Windows.Forms.ButtonAdv Addbtn;
    }
}