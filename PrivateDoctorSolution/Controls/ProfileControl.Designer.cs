namespace PrivateDoctorSolution.Controls
{
    partial class ProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TextItem textItem1 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem2 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem3 = new Syncfusion.Windows.Forms.Tools.TextItem();
            Syncfusion.Windows.Forms.Tools.TextItem textItem4 = new Syncfusion.Windows.Forms.Tools.TextItem();
            this.hubTile2 = new Syncfusion.Windows.Forms.Tools.HubTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EditButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.backbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hubTile2
            // 
            textItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem1.HubTile = this.hubTile2;
            this.hubTile2.Banner = textItem1;
            textItem2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem2.HubTile = this.hubTile2;
            this.hubTile2.Body = textItem2;
            this.hubTile2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem3.HubTile = this.hubTile2;
            this.hubTile2.Footer = textItem3;
            this.hubTile2.ImageSource = global::PrivateDoctorSolution.Properties.Resources.profile;
            this.hubTile2.Location = new System.Drawing.Point(15, 54);
            this.hubTile2.Margin = new System.Windows.Forms.Padding(1);
            this.hubTile2.MinimumSize = new System.Drawing.Size(100, 100);
            this.hubTile2.Name = "hubTile2";
            this.hubTile2.Size = new System.Drawing.Size(160, 160);
            this.hubTile2.TabIndex = 0;
            textItem4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            textItem4.HubTile = this.hubTile2;
            this.hubTile2.Title = textItem4;
            this.hubTile2.Click += new System.EventHandler(this.hubTile2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 468);
            this.panel1.TabIndex = 0;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.White;
            this.emailLbl.Location = new System.Drawing.Point(227, 197);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 22;
            this.emailLbl.Text = "Email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.emailLbl);
            this.panel2.Controls.Add(this.EditButton);
            this.panel2.Controls.Add(this.EditPanel);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.hubTile2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 468);
            this.panel2.TabIndex = 25;
            // 
            // EditButton
            // 
            this.EditButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.EditButton.BackColor = System.Drawing.Color.Orange;
            this.EditButton.BeforeTouchSize = new System.Drawing.Size(50, 30);
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.IsBackStageButton = false;
            this.EditButton.KeepFocusRectangle = false;
            this.EditButton.Location = new System.Drawing.Point(15, 227);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.EditButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 30);
            this.EditButton.TabIndex = 24;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyle = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.textBox1);
            this.EditPanel.Controls.Add(this.textBox7);
            this.EditPanel.Controls.Add(this.textBox6);
            this.EditPanel.Controls.Add(this.textBox5);
            this.EditPanel.Controls.Add(this.textBox4);
            this.EditPanel.Controls.Add(this.textBox3);
            this.EditPanel.Controls.Add(this.label20);
            this.EditPanel.Controls.Add(this.label17);
            this.EditPanel.Controls.Add(this.label18);
            this.EditPanel.Controls.Add(this.label19);
            this.EditPanel.Controls.Add(this.label16);
            this.EditPanel.Controls.Add(this.backbtn);
            this.EditPanel.Controls.Add(this.label1);
            this.EditPanel.Controls.Add(this.buttonAdv2);
            this.EditPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EditPanel.Location = new System.Drawing.Point(365, 0);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(414, 468);
            this.EditPanel.TabIndex = 25;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox7.Location = new System.Drawing.Point(151, 84);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(171, 22);
            this.textBox7.TabIndex = 40;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox6.Location = new System.Drawing.Point(151, 115);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(171, 22);
            this.textBox6.TabIndex = 39;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox5.Location = new System.Drawing.Point(151, 148);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(171, 22);
            this.textBox5.TabIndex = 38;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox4.Location = new System.Drawing.Point(151, 176);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(171, 22);
            this.textBox4.TabIndex = 37;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox3.Location = new System.Drawing.Point(151, 204);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(171, 22);
            this.textBox3.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(20, 237);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(128, 17);
            this.label20.TabIndex = 34;
            this.label20.Text = "Confirm Password :";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(20, 117);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 17);
            this.label17.TabIndex = 33;
            this.label17.Text = "Email :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(20, 209);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 17);
            this.label18.TabIndex = 32;
            this.label18.Text = "New Password :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(20, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 17);
            this.label19.TabIndex = 31;
            this.label19.Text = "Old Password :";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(20, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Edit Profile :";
            // 
            // backbtn
            // 
            this.backbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.backbtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.backbtn.BackColor = System.Drawing.Color.Orange;
            this.backbtn.BeforeTouchSize = new System.Drawing.Size(55, 30);
            this.backbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtn.IsBackStageButton = false;
            this.backbtn.KeepFocusRectangle = false;
            this.backbtn.Location = new System.Drawing.Point(3, 3);
            this.backbtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.backbtn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(55, 30);
            this.backbtn.TabIndex = 29;
            this.backbtn.Text = "Back";
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backbtn.UseVisualStyle = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Name :";
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.Orange;
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(54, 30);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv2.ForeColor = System.Drawing.Color.White;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(268, 268);
            this.buttonAdv2.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(54, 30);
            this.buttonAdv2.TabIndex = 26;
            this.buttonAdv2.Text = "Save";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(179, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(11, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Dr. Something Something";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox1.Location = new System.Drawing.Point(151, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 22);
            this.textBox1.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Email Password :";
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ProfileControl";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(819, 508);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.Tools.HubTile hubTile2;
        private Syncfusion.Windows.Forms.ButtonAdv EditButton;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.ButtonAdv backbtn;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}
