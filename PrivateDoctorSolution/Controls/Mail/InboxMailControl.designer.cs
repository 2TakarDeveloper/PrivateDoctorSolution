namespace PrivateDoctorSolution.Controls.Mail
{
    partial class InboxMailControl
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
            this.MailButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailButton
            // 
            this.MailButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.MailButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MailButton.Location = new System.Drawing.Point(0, 0);
            this.MailButton.Name = "MailButton";
            this.MailButton.Size = new System.Drawing.Size(1084, 61);
            this.MailButton.TabIndex = 0;
            this.MailButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MailButton.UseMnemonic = false;
            this.MailButton.UseVisualStyleBackColor = false;
            this.MailButton.Click += new System.EventHandler(this.MailButton_Click);
            // 
            // InboxMailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MailButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InboxMailControl";
            this.Size = new System.Drawing.Size(1084, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MailButton;
    }
}
