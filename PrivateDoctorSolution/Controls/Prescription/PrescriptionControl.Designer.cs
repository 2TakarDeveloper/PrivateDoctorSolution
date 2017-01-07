namespace PrivateDoctorSolution.Controls.Prescription
{
    partial class PrescriptionControl
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButtonMedicine = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButtonTest = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TestPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MedicinePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.flowLayoutPanel1.Controls.Add(this.AddButtonMedicine);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdv2);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddButtonMedicine
            // 
            this.AddButtonMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButtonMedicine.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.AddButtonMedicine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AddButtonMedicine.BeforeTouchSize = new System.Drawing.Size(74, 37);
            this.AddButtonMedicine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddButtonMedicine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddButtonMedicine.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.AddButtonMedicine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButtonMedicine.IsBackStageButton = false;
            this.AddButtonMedicine.KeepFocusRectangle = false;
            this.AddButtonMedicine.Location = new System.Drawing.Point(3, 3);
            this.AddButtonMedicine.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AddButtonMedicine.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.AddButtonMedicine.Name = "AddButtonMedicine";
            this.AddButtonMedicine.Size = new System.Drawing.Size(74, 37);
            this.AddButtonMedicine.TabIndex = 8;
            this.AddButtonMedicine.Text = "Add";
            this.AddButtonMedicine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButtonMedicine.UseVisualStyle = true;
            this.AddButtonMedicine.Click += new System.EventHandler(this.AddButtonMedicine_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(478, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(300, 0, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Medicine";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TestPanel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.MedicinePanel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 1000);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.flowLayoutPanel2.Controls.Add(this.AddButtonTest);
            this.flowLayoutPanel2.Controls.Add(this.buttonAdv3);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 528);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(794, 44);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // AddButtonTest
            // 
            this.AddButtonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButtonTest.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.AddButtonTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AddButtonTest.BeforeTouchSize = new System.Drawing.Size(74, 37);
            this.AddButtonTest.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddButtonTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddButtonTest.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.AddButtonTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButtonTest.IsBackStageButton = false;
            this.AddButtonTest.KeepFocusRectangle = false;
            this.AddButtonTest.Location = new System.Drawing.Point(3, 3);
            this.AddButtonTest.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AddButtonTest.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.AddButtonTest.Name = "AddButtonTest";
            this.AddButtonTest.Size = new System.Drawing.Size(74, 37);
            this.AddButtonTest.TabIndex = 8;
            this.AddButtonTest.Text = "Add";
            this.AddButtonTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButtonTest.UseVisualStyle = true;
            this.AddButtonTest.Click += new System.EventHandler(this.AddButtonTest_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(478, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(300, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.buttonAdv5);
            this.panel1.Controls.Add(this.buttonAdv4);
            this.panel1.Controls.Add(this.buttonAdv1);
            this.panel1.Controls.Add(this.DateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 44);
            this.panel1.TabIndex = 3;
            // 
            // DateTime
            // 
            this.DateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.DateTime.Enabled = false;
            this.DateTime.Location = new System.Drawing.Point(607, 10);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(184, 20);
            this.DateTime.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(268, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prescription ";
            // 
            // BackButton
            // 
            this.BackButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BackButton.BeforeTouchSize = new System.Drawing.Size(84, 44);
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.BackButton.Image = global::PrivateDoctorSolution.Properties.Resources.Previous;
            this.BackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackButton.IsBackStageButton = false;
            this.BackButton.KeepFocusRectangle = false;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BackButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(84, 44);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackButton.UseVisualStyle = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TestPanel
            // 
            this.TestPanel.AutoScroll = true;
            this.TestPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestPanel.Location = new System.Drawing.Point(3, 578);
            this.TestPanel.Name = "TestPanel";
            this.TestPanel.Size = new System.Drawing.Size(794, 419);
            this.TestPanel.TabIndex = 5;
            // 
            // MedicinePanel
            // 
            this.MedicinePanel.AutoScroll = true;
            this.MedicinePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicinePanel.Location = new System.Drawing.Point(3, 103);
            this.MedicinePanel.Name = "MedicinePanel";
            this.MedicinePanel.Size = new System.Drawing.Size(794, 419);
            this.MedicinePanel.TabIndex = 4;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(63, 44);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(84, 0);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(63, 44);
            this.buttonAdv1.TabIndex = 14;
            this.buttonAdv1.Text = "New";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv2.BeforeTouchSize = new System.Drawing.Size(78, 37);
            this.buttonAdv2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv2.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.buttonAdv2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv2.IsBackStageButton = false;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(90, 3);
            this.buttonAdv2.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(78, 37);
            this.buttonAdv2.TabIndex = 12;
            this.buttonAdv2.Text = "Save";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(78, 37);
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv3.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.buttonAdv3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(90, 3);
            this.buttonAdv3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(78, 37);
            this.buttonAdv3.TabIndex = 13;
            this.buttonAdv3.Text = "Save";
            this.buttonAdv3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv3.UseVisualStyle = true;
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv4.BeforeTouchSize = new System.Drawing.Size(54, 44);
            this.buttonAdv4.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdv4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv4.IsBackStageButton = false;
            this.buttonAdv4.KeepFocusRectangle = false;
            this.buttonAdv4.Location = new System.Drawing.Point(147, 0);
            this.buttonAdv4.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(54, 44);
            this.buttonAdv4.TabIndex = 15;
            this.buttonAdv4.Text = "Save";
            this.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv4.UseVisualStyle = true;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv5.BeforeTouchSize = new System.Drawing.Size(54, 44);
            this.buttonAdv5.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAdv5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv5.IsBackStageButton = false;
            this.buttonAdv5.KeepFocusRectangle = false;
            this.buttonAdv5.Location = new System.Drawing.Point(201, 0);
            this.buttonAdv5.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(54, 44);
            this.buttonAdv5.TabIndex = 16;
            this.buttonAdv5.Text = "Print";
            this.buttonAdv5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv5.UseVisualStyle = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 29);
            this.comboBox1.TabIndex = 17;
            // 
            // PrescriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PrescriptionControl";
            this.Size = new System.Drawing.Size(800, 1000);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv AddButtonMedicine;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv AddButtonTest;
        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.ButtonAdv BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateTime;
        private System.Windows.Forms.FlowLayoutPanel TestPanel;
        private System.Windows.Forms.FlowLayoutPanel MedicinePanel;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private System.Windows.Forms.ComboBox comboBox1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv4;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
    }
}
