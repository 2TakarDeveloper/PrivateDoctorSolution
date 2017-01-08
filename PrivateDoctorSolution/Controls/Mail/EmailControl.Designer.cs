namespace PrivateDoctorSolution.Controls.Mail
{
    partial class EmailControl
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
            this.flowLayoutPanelSideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.InboxButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.JunkButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.SentButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.DraftButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.flowLayoutPanelBody = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanelSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelSideBar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBody, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanelSideBar
            // 
            this.flowLayoutPanelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.flowLayoutPanelSideBar.Controls.Add(this.InboxButton);
            this.flowLayoutPanelSideBar.Controls.Add(this.JunkButton);
            this.flowLayoutPanelSideBar.Controls.Add(this.SentButton);
            this.flowLayoutPanelSideBar.Controls.Add(this.DraftButton);
            this.flowLayoutPanelSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSideBar.Location = new System.Drawing.Point(0, 60);
            this.flowLayoutPanelSideBar.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSideBar.Name = "flowLayoutPanelSideBar";
            this.flowLayoutPanelSideBar.Size = new System.Drawing.Size(200, 365);
            this.flowLayoutPanelSideBar.TabIndex = 0;
            // 
            // InboxButton
            // 
            this.InboxButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.InboxButton.BackColor = System.Drawing.Color.Transparent;
            this.InboxButton.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.InboxButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.InboxButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InboxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.InboxButton.IsBackStageButton = false;
            this.InboxButton.KeepFocusRectangle = false;
            this.InboxButton.Location = new System.Drawing.Point(0, 0);
            this.InboxButton.Margin = new System.Windows.Forms.Padding(0);
            this.InboxButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.InboxButton.Name = "InboxButton";
            this.InboxButton.Size = new System.Drawing.Size(200, 35);
            this.InboxButton.TabIndex = 0;
            this.InboxButton.Text = "Inbox                    ";
            this.InboxButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InboxButton.UseVisualStyle = true;
            this.InboxButton.Click += new System.EventHandler(this.InboxButton_Click);
            // 
            // JunkButton
            // 
            this.JunkButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.JunkButton.BackColor = System.Drawing.Color.Transparent;
            this.JunkButton.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.JunkButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.JunkButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JunkButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.JunkButton.IsBackStageButton = false;
            this.JunkButton.KeepFocusRectangle = false;
            this.JunkButton.Location = new System.Drawing.Point(0, 35);
            this.JunkButton.Margin = new System.Windows.Forms.Padding(0);
            this.JunkButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.JunkButton.Name = "JunkButton";
            this.JunkButton.Size = new System.Drawing.Size(200, 35);
            this.JunkButton.TabIndex = 1;
            this.JunkButton.Text = "Junk Email            ";
            this.JunkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.JunkButton.UseVisualStyle = true;
            // 
            // SentButton
            // 
            this.SentButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.SentButton.BackColor = System.Drawing.Color.Transparent;
            this.SentButton.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.SentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.SentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SentButton.IsBackStageButton = false;
            this.SentButton.KeepFocusRectangle = false;
            this.SentButton.Location = new System.Drawing.Point(0, 70);
            this.SentButton.Margin = new System.Windows.Forms.Padding(0);
            this.SentButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.SentButton.Name = "SentButton";
            this.SentButton.Size = new System.Drawing.Size(200, 35);
            this.SentButton.TabIndex = 2;
            this.SentButton.Text = "Sent                       ";
            this.SentButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SentButton.UseVisualStyle = true;
            // 
            // DraftButton
            // 
            this.DraftButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.DraftButton.BackColor = System.Drawing.Color.Transparent;
            this.DraftButton.BeforeTouchSize = new System.Drawing.Size(200, 35);
            this.DraftButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DraftButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DraftButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.DraftButton.IsBackStageButton = false;
            this.DraftButton.KeepFocusRectangle = false;
            this.DraftButton.Location = new System.Drawing.Point(0, 105);
            this.DraftButton.Margin = new System.Windows.Forms.Padding(0);
            this.DraftButton.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.DraftButton.Name = "DraftButton";
            this.DraftButton.Size = new System.Drawing.Size(200, 35);
            this.DraftButton.TabIndex = 3;
            this.DraftButton.Text = "Draft                      ";
            this.DraftButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DraftButton.UseVisualStyle = true;
            // 
            // flowLayoutPanelBody
            // 
            this.flowLayoutPanelBody.AutoScroll = true;
            this.flowLayoutPanelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.flowLayoutPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBody.Location = new System.Drawing.Point(203, 63);
            this.flowLayoutPanelBody.Name = "flowLayoutPanelBody";
            this.flowLayoutPanelBody.Size = new System.Drawing.Size(640, 359);
            this.flowLayoutPanelBody.TabIndex = 1;
            // 
            // flowLayout1
            // 
            this.flowLayout1.ContainerControl = this.flowLayoutPanelSideBar;
            this.flowLayout1.HorzFarMargin = 1;
            this.flowLayout1.HorzNearMargin = 1;
            // 
            // EmailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "EmailControl";
            this.Size = new System.Drawing.Size(846, 425);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanelSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSideBar;
        private Syncfusion.Windows.Forms.ButtonAdv InboxButton;
        private Syncfusion.Windows.Forms.ButtonAdv JunkButton;
        private Syncfusion.Windows.Forms.ButtonAdv SentButton;
        private Syncfusion.Windows.Forms.ButtonAdv DraftButton;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBody;
    }
}
