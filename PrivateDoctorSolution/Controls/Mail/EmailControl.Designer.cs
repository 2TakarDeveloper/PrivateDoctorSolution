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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailServer = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.flowLayoutPanelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelBody, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.ReloadButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.EmailServer);
            this.panel1.Controls.Add(this.EmailPasswordTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EmailAddressTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 97);
            this.panel1.TabIndex = 3;
            // 
            // EmailAddressTextBox
            // 
            this.EmailAddressTextBox.Location = new System.Drawing.Point(141, 35);
            this.EmailAddressTextBox.Name = "EmailAddressTextBox";
            this.EmailAddressTextBox.Size = new System.Drawing.Size(217, 20);
            this.EmailAddressTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email Password";
            // 
            // EmailPasswordTextBox
            // 
            this.EmailPasswordTextBox.Location = new System.Drawing.Point(141, 64);
            this.EmailPasswordTextBox.Name = "EmailPasswordTextBox";
            this.EmailPasswordTextBox.Size = new System.Drawing.Size(217, 20);
            this.EmailPasswordTextBox.TabIndex = 4;
            this.EmailPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // EmailServer
            // 
            this.EmailServer.FormattingEnabled = true;
            this.EmailServer.Items.AddRange(new object[] {
            "Gmail",
            "Yahoo",
            "Live"});
            this.EmailServer.Location = new System.Drawing.Point(141, 5);
            this.EmailServer.Name = "EmailServer";
            this.EmailServer.Size = new System.Drawing.Size(217, 21);
            this.EmailServer.TabIndex = 5;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.Location = new System.Drawing.Point(765, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 97);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save Info";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // ReloadButton
            // 
            this.ReloadButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReloadButton.Location = new System.Drawing.Point(690, 0);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(75, 97);
            this.ReloadButton.TabIndex = 7;
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // flowLayoutPanelBody
            // 
            this.flowLayoutPanelBody.BackColor = System.Drawing.SystemColors.Highlight;
            this.flowLayoutPanelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelBody.Location = new System.Drawing.Point(3, 106);
            this.flowLayoutPanelBody.Name = "flowLayoutPanelBody";
            this.flowLayoutPanelBody.Size = new System.Drawing.Size(840, 316);
            this.flowLayoutPanelBody.TabIndex = 4;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EmailServer;
        private System.Windows.Forms.TextBox EmailPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailAddressTextBox;
        private System.Windows.Forms.Button ReloadButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel flowLayoutPanelBody;
    }
}
