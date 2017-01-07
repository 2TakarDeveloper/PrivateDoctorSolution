namespace PrivateDoctorSolution.Controls.Prescription
{
    partial class MedicineControl
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
            this.NameBox = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.BeforeTouchSize = new System.Drawing.Size(148, 24);
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NameBox.Location = new System.Drawing.Point(10, 10);
            this.NameBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(148, 24);
            this.NameBox.TabIndex = 20;
            this.NameBox.Text = "Medicine Name";
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // EndDate
            // 
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.EndDate.Location = new System.Drawing.Point(560, 10);
            this.EndDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(235, 22);
            this.EndDate.TabIndex = 16;
            this.EndDate.ValueChanged += new System.EventHandler(this.EndDate_ValueChanged);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.IntervalTextBox.Location = new System.Drawing.Point(880, 10);
            this.IntervalTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(161, 22);
            this.IntervalTextBox.TabIndex = 18;
            this.IntervalTextBox.TextChanged += new System.EventHandler(this.IntervalTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(158, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start Date :";
            // 
            // StartDate
            // 
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(244, 10);
            this.StartDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(237, 22);
            this.StartDate.TabIndex = 15;
            this.StartDate.ValueChanged += new System.EventHandler(this.StartDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(481, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "End Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(795, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Interval :";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(80, 40);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv1.Image = global::PrivateDoctorSolution.Properties.Resources.Trash_can___03;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(1070, 0);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(80, 40);
            this.buttonAdv1.TabIndex = 12;
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9565217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.565217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.86957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.956522F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.69565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.478261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69565F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.782609F));
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv1, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.StartDate, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndDate, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.IntervalTextBox, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1150, 40);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // MedicineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MedicineControl";
            this.Size = new System.Drawing.Size(1150, 40);
            ((System.ComponentModel.ISupportInitialize)(this.NameBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.ComboBoxAdv NameBox;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
