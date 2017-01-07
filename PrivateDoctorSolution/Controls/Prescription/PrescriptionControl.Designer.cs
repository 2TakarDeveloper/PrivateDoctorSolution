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
            this.PrescriptionID = new System.Windows.Forms.ComboBox();
            this.PrintButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SaveButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.NewButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.DateTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TestPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MedicinePanel = new System.Windows.Forms.FlowLayoutPanel();
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
            this.label4.Location = new System.Drawing.Point(387, 11);
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
            this.label5.Location = new System.Drawing.Point(387, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(300, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tests";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.PrescriptionID);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.DateTime);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 44);
            this.panel1.TabIndex = 3;
            // 
            // PrescriptionID
            // 
            this.PrescriptionID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PrescriptionID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PrescriptionID.FormattingEnabled = true;
            this.PrescriptionID.Location = new System.Drawing.Point(380, 7);
            this.PrescriptionID.Name = "PrescriptionID";
            this.PrescriptionID.Size = new System.Drawing.Size(170, 29);
            this.PrescriptionID.TabIndex = 17;
            this.PrescriptionID.SelectedIndexChanged += new System.EventHandler(this.PrescriptionID_SelectedIndexChanged);
            // 
            // PrintButton
            // 
            this.PrintButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.PrintButton.BeforeTouchSize = new System.Drawing.Size(54, 44);
            this.PrintButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PrintButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PrintButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrintButton.IsBackStageButton = false;
            this.PrintButton.KeepFocusRectangle = false;
            this.PrintButton.Location = new System.Drawing.Point(201, 0);
            this.PrintButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PrintButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(54, 44);
            this.PrintButton.TabIndex = 16;
            this.PrintButton.Text = "Print";
            this.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintButton.UseVisualStyle = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.SaveButton.BeforeTouchSize = new System.Drawing.Size(54, 44);
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.IsBackStageButton = false;
            this.SaveButton.KeepFocusRectangle = false;
            this.SaveButton.Location = new System.Drawing.Point(147, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.SaveButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(54, 44);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyle = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.NewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.NewButton.BeforeTouchSize = new System.Drawing.Size(63, 44);
            this.NewButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.NewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.NewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewButton.IsBackStageButton = false;
            this.NewButton.KeepFocusRectangle = false;
            this.NewButton.Location = new System.Drawing.Point(84, 0);
            this.NewButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.NewButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(63, 44);
            this.NewButton.TabIndex = 14;
            this.NewButton.Text = "New";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NewButton.UseVisualStyle = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
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
        private System.Windows.Forms.ComboBox PrescriptionID;
        private Syncfusion.Windows.Forms.ButtonAdv PrintButton;
        private Syncfusion.Windows.Forms.ButtonAdv SaveButton;
        private Syncfusion.Windows.Forms.ButtonAdv NewButton;
    }
}
