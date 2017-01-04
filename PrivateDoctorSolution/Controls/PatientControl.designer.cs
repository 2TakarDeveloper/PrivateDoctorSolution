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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridDataBoundGrid1 = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Addbtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Updatebtn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.Deletetbn = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 816F));
            this.tableLayoutPanel1.Controls.Add(this.gridDataBoundGrid1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
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
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(94)))), ((int)(((byte)(171)))), ((int)(((byte)(222)))));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.gridDataBoundGrid1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridDataBoundGrid1.DefaultRowHeight = 20;
            this.gridDataBoundGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDataBoundGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(3, 53);
            this.gridDataBoundGrid1.MetroScrollBars = true;
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.OptimizeInsertRemoveCells = true;
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(810, 411);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.Text = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.UseListChangedEvent = true;
            this.gridDataBoundGrid1.UseRightToLeftCompatibleTextBox = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.flowLayoutPanel1.Controls.Add(this.Addbtn);
            this.flowLayoutPanel1.Controls.Add(this.Updatebtn);
            this.flowLayoutPanel1.Controls.Add(this.Deletetbn);
            this.flowLayoutPanel1.Controls.Add(this.buttonAdv3);
            this.flowLayoutPanel1.Controls.Add(this.textBoxExt1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(810, 44);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(194, 29);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxExt1.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.Location = new System.Drawing.Point(419, 8);
            this.textBoxExt1.Margin = new System.Windows.Forms.Padding(3, 8, 10, 3);
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Size = new System.Drawing.Size(194, 29);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.textBoxExt1.TabIndex = 10;
            this.textBoxExt1.Text = "Search......";
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
            this.Addbtn.Location = new System.Drawing.Point(3, 3);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Addbtn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(74, 37);
            this.Addbtn.TabIndex = 7;
            this.Addbtn.Text = "Add";
            this.Addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Addbtn.UseVisualStyle = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Updatebtn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Updatebtn.BeforeTouchSize = new System.Drawing.Size(99, 37);
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Updatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Updatebtn.Image = global::PrivateDoctorSolution.Properties.Resources.File_Edit_WF;
            this.Updatebtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Updatebtn.IsBackStageButton = false;
            this.Updatebtn.KeepFocusRectangle = false;
            this.Updatebtn.Location = new System.Drawing.Point(90, 3);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Updatebtn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(99, 37);
            this.Updatebtn.TabIndex = 9;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Updatebtn.UseVisualStyle = true;
            // 
            // Deletetbn
            // 
            this.Deletetbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Deletetbn.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Deletetbn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Deletetbn.BeforeTouchSize = new System.Drawing.Size(91, 37);
            this.Deletetbn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Deletetbn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.Deletetbn.Image = global::PrivateDoctorSolution.Properties.Resources.Trash_can___03;
            this.Deletetbn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletetbn.IsBackStageButton = false;
            this.Deletetbn.KeepFocusRectangle = false;
            this.Deletetbn.Location = new System.Drawing.Point(202, 3);
            this.Deletetbn.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.Deletetbn.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.Deletetbn.Name = "Deletetbn";
            this.Deletetbn.Size = new System.Drawing.Size(91, 37);
            this.Deletetbn.TabIndex = 8;
            this.Deletetbn.Text = "Delete";
            this.Deletetbn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Deletetbn.UseVisualStyle = true;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.buttonAdv3.BeforeTouchSize = new System.Drawing.Size(100, 37);
            this.buttonAdv3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAdv3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.buttonAdv3.Image = global::PrivateDoctorSolution.Properties.Resources.Search_WF;
            this.buttonAdv3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv3.IsBackStageButton = false;
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(306, 3);
            this.buttonAdv3.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.buttonAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(100, 37);
            this.buttonAdv3.TabIndex = 11;
            this.buttonAdv3.Text = "Search";
            this.buttonAdv3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv3.UseVisualStyle = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Syncfusion.Windows.Forms.Grid.GridDataBoundGrid gridDataBoundGrid1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv Addbtn;
        private Syncfusion.Windows.Forms.ButtonAdv Updatebtn;
        private Syncfusion.Windows.Forms.ButtonAdv Deletetbn;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
    }
}
