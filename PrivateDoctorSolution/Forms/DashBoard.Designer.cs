namespace PrivateDoctorSolution
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.navigationDrawer1 = new Syncfusion.Windows.Forms.Tools.NavigationDrawer();
            this.drawerMenuItemSchedule = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItem2 = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemEmails = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemLock = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemLogout = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.Menu = new Syncfusion.Windows.Forms.ButtonAdv();
            this.drawerHeaderProfile = new Syncfusion.Windows.Forms.Tools.DrawerHeader();
            this.SuspendLayout();
            // 
            // navigationDrawer1
            // 
            this.navigationDrawer1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.navigationDrawer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationDrawer1.DrawerHeight = 1000;
            this.navigationDrawer1.DrawerWidth = 200;
            this.navigationDrawer1.Items.Add(this.drawerHeaderProfile);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemSchedule);
            this.navigationDrawer1.Items.Add(this.drawerMenuItem2);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemEmails);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemLock);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemLogout);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 50);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(814, 423);
            this.navigationDrawer1.TabIndex = 0;
            this.navigationDrawer1.Text = "navigationDrawer1";
            this.navigationDrawer1.TouchThreshold = 500;
            this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            // 
            // drawerMenuItemSchedule
            // 
            this.drawerMenuItemSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemSchedule.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemSchedule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItemSchedule.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItemSchedule.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItemSchedule.ItemText = "Schedule";
            this.drawerMenuItemSchedule.Location = new System.Drawing.Point(2, 120);
            this.drawerMenuItemSchedule.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItemSchedule.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItemSchedule.Name = "drawerMenuItemSchedule";
            this.drawerMenuItemSchedule.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItemSchedule.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItemSchedule.TabIndex = 0;
            this.drawerMenuItemSchedule.Text = "Schedule";
            this.drawerMenuItemSchedule.TextColor = System.Drawing.Color.White;
            this.drawerMenuItemSchedule.Click += new System.EventHandler(this.drawerMenuItemSchedule_Click);
            // 
            // drawerMenuItem2
            // 
            this.drawerMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItem2.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItem2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItem2.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItem2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItem2.ItemText = "Apointment";
            this.drawerMenuItem2.Location = new System.Drawing.Point(2, 170);
            this.drawerMenuItem2.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItem2.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.Name = "drawerMenuItem2";
            this.drawerMenuItem2.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItem2.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItem2.TabIndex = 1;
            this.drawerMenuItem2.Text = "Apointment";
            this.drawerMenuItem2.TextColor = System.Drawing.Color.White;
            // 
            // drawerMenuItemEmails
            // 
            this.drawerMenuItemEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemEmails.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemEmails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItemEmails.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItemEmails.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItemEmails.Location = new System.Drawing.Point(2, 220);
            this.drawerMenuItemEmails.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItemEmails.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItemEmails.Name = "drawerMenuItemEmails";
            this.drawerMenuItemEmails.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItemEmails.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItemEmails.TabIndex = 2;
            this.drawerMenuItemEmails.Text = "Emails";
            this.drawerMenuItemEmails.TextColor = System.Drawing.Color.White;
            this.drawerMenuItemEmails.Click += new System.EventHandler(this.drawerMenuItemEmails_Click);
            // 
            // drawerMenuItemLock
            // 
            this.drawerMenuItemLock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.drawerMenuItemLock.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemLock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItemLock.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItemLock.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItemLock.Location = new System.Drawing.Point(2, 270);
            this.drawerMenuItemLock.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItemLock.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItemLock.Name = "drawerMenuItemLock";
            this.drawerMenuItemLock.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItemLock.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItemLock.TabIndex = 3;
            this.drawerMenuItemLock.Text = "Lock";
            this.drawerMenuItemLock.TextColor = System.Drawing.Color.White;
            this.drawerMenuItemLock.Click += new System.EventHandler(this.drawerMenuItemLock_Click);
            // 
            // drawerMenuItemLogout
            // 
            this.drawerMenuItemLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemLogout.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItemLogout.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItemLogout.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItemLogout.Location = new System.Drawing.Point(2, 320);
            this.drawerMenuItemLogout.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItemLogout.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItemLogout.Name = "drawerMenuItemLogout";
            this.drawerMenuItemLogout.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItemLogout.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItemLogout.TabIndex = 4;
            this.drawerMenuItemLogout.Text = "Logout";
            this.drawerMenuItemLogout.TextColor = System.Drawing.Color.White;
            this.drawerMenuItemLogout.Click += new System.EventHandler(this.drawerMenuItemLogout_Click);
            // 
            // Menu
            // 
            this.Menu.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Menu.BeforeTouchSize = new System.Drawing.Size(109, 44);
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = global::PrivateDoctorSolution.Properties.Resources.Menu;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.IsBackStageButton = false;
            this.Menu.KeepFocusRectangle = false;
            this.Menu.Location = new System.Drawing.Point(3, 0);
            this.Menu.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(109, 44);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Menu";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Menu.UseVisualStyle = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // drawerHeaderProfile
            // 
            this.drawerHeaderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.drawerHeaderProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerHeaderProfile.HeaderImage = global::PrivateDoctorSolution.Properties.Resources.imageListAdv1_Images;
            this.drawerHeaderProfile.HeaderText = "Mr.Doctor";
            this.drawerHeaderProfile.Location = new System.Drawing.Point(2, 0);
            this.drawerHeaderProfile.Margin = new System.Windows.Forms.Padding(0);
            this.drawerHeaderProfile.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerHeaderProfile.Name = "drawerHeaderProfile";
            this.drawerHeaderProfile.Size = new System.Drawing.Size(200, 120);
            this.drawerHeaderProfile.TabIndex = 5;
            this.drawerHeaderProfile.Text = "Mr.Doctor";
            this.drawerHeaderProfile.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Right;
            this.drawerHeaderProfile.TextColor = System.Drawing.Color.White;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(814, 473);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.navigationDrawer1);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemSchedule;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItem2;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemEmails;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemLock;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemLogout;
        private Syncfusion.Windows.Forms.ButtonAdv Menu;
        private Syncfusion.Windows.Forms.Tools.DrawerHeader drawerHeaderProfile;
    }
}