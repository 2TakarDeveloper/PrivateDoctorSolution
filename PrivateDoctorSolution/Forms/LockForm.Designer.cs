#region Copyright Syncfusion Inc. 2001 - 2016
// Copyright Syncfusion Inc. 2001 - 2016. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PrivateDoctorSolution
{
    partial class LockForm
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
            this.Loginbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.passwordtext = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtext)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Loginbtn.BeforeTouchSize = new System.Drawing.Size(74, 37);
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Loginbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loginbtn.IsBackStageButton = false;
            this.Loginbtn.KeepFocusRectangle = false;
            this.Loginbtn.Location = new System.Drawing.Point(293, 104);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Loginbtn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(74, 37);
            this.Loginbtn.TabIndex = 17;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyle = true;
            this.Loginbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // passwordtext
            // 
            this.passwordtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.passwordtext.BeforeTouchSize = new System.Drawing.Size(268, 29);
            this.passwordtext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.passwordtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordtext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtext.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.passwordtext.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtext.Location = new System.Drawing.Point(99, 69);
            this.passwordtext.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.passwordtext.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(268, 29);
            this.passwordtext.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.passwordtext.TabIndex = 16;
            this.passwordtext.Text = "system";
            this.passwordtext.TextChanged += new System.EventHandler(this.textBoxExt3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Password :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "System is Locked.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderThickness = 5;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockForm";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.LockForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordtext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.ButtonAdv Loginbtn;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt passwordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}