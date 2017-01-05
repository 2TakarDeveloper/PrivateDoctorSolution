namespace PrivateDoctorSolution.Controls
{
    partial class PatientControl
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.EditButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.DeletetButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SearchBox = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PrescriptionButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.PatientDataGrid = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 816F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PatientDataGrid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(816, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.flowLayoutPanel1.Controls.Add(this.AddButton);
            this.flowLayoutPanel1.Controls.Add(this.EditButton);
            this.flowLayoutPanel1.Controls.Add(this.DeletetButton);
            this.flowLayoutPanel1.Controls.Add(this.SearchBox);
            this.flowLayoutPanel1.Controls.Add(this.PrescriptionButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.AddButton.BeforeTouchSize = new System.Drawing.Size(74, 37);
            this.AddButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.AddButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.AddButton.Image = global::PrivateDoctorSolution.Properties.Resources.Addbtn;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.IsBackStageButton = false;
            this.AddButton.KeepFocusRectangle = false;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.AddButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(74, 37);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.UseVisualStyle = true;
            this.AddButton.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.EditButton.BeforeTouchSize = new System.Drawing.Size(75, 37);
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.EditButton.Image = global::PrivateDoctorSolution.Properties.Resources.File_Edit_WF;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditButton.IsBackStageButton = false;
            this.EditButton.KeepFocusRectangle = false;
            this.EditButton.Location = new System.Drawing.Point(90, 3);
            this.EditButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.EditButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 37);
            this.EditButton.TabIndex = 9;
            this.EditButton.Text = "Edit";
            this.EditButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditButton.UseVisualStyle = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeletetButton
            // 
            this.DeletetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletetButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.DeletetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.DeletetButton.BeforeTouchSize = new System.Drawing.Size(91, 37);
            this.DeletetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.DeletetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.DeletetButton.Image = global::PrivateDoctorSolution.Properties.Resources.Trash_can___03;
            this.DeletetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeletetButton.IsBackStageButton = false;
            this.DeletetButton.KeepFocusRectangle = false;
            this.DeletetButton.Location = new System.Drawing.Point(178, 3);
            this.DeletetButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.DeletetButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.DeletetButton.Name = "DeletetButton";
            this.DeletetButton.Size = new System.Drawing.Size(91, 37);
            this.DeletetButton.TabIndex = 8;
            this.DeletetButton.Text = "Delete";
            this.DeletetButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeletetButton.UseVisualStyle = true;
            this.DeletetButton.Click += new System.EventHandler(this.DeletetButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.SearchBox.BeforeTouchSize = new System.Drawing.Size(194, 29);
            this.SearchBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBox.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(282, 8);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.SearchBox.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(194, 29);
            this.SearchBox.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.SearchBox.TabIndex = 10;
            this.SearchBox.Text = "Search......";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // PrescriptionButton
            // 
            this.PrescriptionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrescriptionButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.PrescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.PrescriptionButton.BeforeTouchSize = new System.Drawing.Size(135, 37);
            this.PrescriptionButton.Enabled = false;
            this.PrescriptionButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.PrescriptionButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.PrescriptionButton.Image = global::PrivateDoctorSolution.Properties.Resources.File_Edit_WF;
            this.PrescriptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrescriptionButton.IsBackStageButton = false;
            this.PrescriptionButton.KeepFocusRectangle = false;
            this.PrescriptionButton.Location = new System.Drawing.Point(489, 3);
            this.PrescriptionButton.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.PrescriptionButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.PrescriptionButton.Name = "PrescriptionButton";
            this.PrescriptionButton.Size = new System.Drawing.Size(135, 37);
            this.PrescriptionButton.TabIndex = 11;
            this.PrescriptionButton.Text = "Prescription";
            this.PrescriptionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrescriptionButton.UseVisualStyle = true;
            this.PrescriptionButton.Click += new System.EventHandler(this.PrescriptionButton_Click);
            // 
            // PatientDataGrid
            // 
            this.PatientDataGrid.AllowUserToAddRows = false;
            this.PatientDataGrid.AllowUserToDeleteRows = false;
            this.PatientDataGrid.AllowUserToResizeColumns = false;
            this.PatientDataGrid.AllowUserToResizeRows = false;
            this.PatientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PatientDataGrid.Location = new System.Drawing.Point(3, 53);
            this.PatientDataGrid.Name = "PatientDataGrid";
            this.PatientDataGrid.ReadOnly = true;
            this.PatientDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientDataGrid.Size = new System.Drawing.Size(810, 411);
            this.PatientDataGrid.TabIndex = 2;
            this.PatientDataGrid.Click += new System.EventHandler(this.PatientDataGrid_Click);
            // 
            // PatientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientControl";
            this.Size = new System.Drawing.Size(816, 467);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatientDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv AddButton;
        private Syncfusion.Windows.Forms.ButtonAdv EditButton;
        private Syncfusion.Windows.Forms.ButtonAdv DeletetButton;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchBox;
        private System.Windows.Forms.DataGridView PatientDataGrid;
        private Syncfusion.Windows.Forms.ButtonAdv PrescriptionButton;
    }
}
