namespace PrivateDoctorSolution.Controls.Prescription
{
    partial class TestControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.IssueDate = new System.Windows.Forms.DateTimePicker();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(253, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Status :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.882353F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.823529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.52941F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.529412F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.58824F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.823529F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.76471F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdv1, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.IssueDate, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.StatusComboBox, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 40);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(489, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name :";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(71, 40);
            this.buttonAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv1.Image = global::PrivateDoctorSolution.Properties.Resources.Trash_can___03;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(779, 0);
            this.buttonAdv1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(71, 40);
            this.buttonAdv1.TabIndex = 4;
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // IssueDate
            // 
            this.IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDate.Location = new System.Drawing.Point(546, 10);
            this.IssueDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(233, 22);
            this.IssueDate.TabIndex = 3;
            this.IssueDate.ValueChanged += new System.EventHandler(this.IssueDate_ValueChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.NameTextBox.Location = new System.Drawing.Point(72, 10);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(181, 22);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Pending",
            "Complete",
            "Redo"});
            this.StatusComboBox.Location = new System.Drawing.Point(319, 9);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(167, 21);
            this.StatusComboBox.TabIndex = 2;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestControl";
            this.Size = new System.Drawing.Size(850, 40);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker IssueDate;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}
