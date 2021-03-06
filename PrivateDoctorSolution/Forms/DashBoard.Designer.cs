﻿namespace PrivateDoctorSolution
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
            this.drawerHeaderProfile = new Syncfusion.Windows.Forms.Tools.DrawerHeader();
            this.drawerMenuItemSchedule = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemPatient = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemEmails = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemLock = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.drawerMenuItemLogout = new Syncfusion.Windows.Forms.Tools.DrawerMenuItem();
            this.MenuBar = new Syncfusion.Windows.Forms.ButtonAdv();
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
            this.navigationDrawer1.Items.Add(this.drawerMenuItemPatient);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemEmails);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemLock);
            this.navigationDrawer1.Items.Add(this.drawerMenuItemLogout);
            this.navigationDrawer1.Location = new System.Drawing.Point(0, 50);
            this.navigationDrawer1.Name = "navigationDrawer1";
            this.navigationDrawer1.Size = new System.Drawing.Size(814, 423);
            this.navigationDrawer1.TabIndex = 0;
            this.navigationDrawer1.Text = "navigationDrawer1";
            this.navigationDrawer1.TouchThreshold = 0;
            this.navigationDrawer1.Transition = Syncfusion.Windows.Forms.Tools.Transition.Push;
            // 
            // drawerHeaderProfile
            // 
            this.drawerHeaderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(73)))), ((int)(((byte)(164)))));
            this.drawerHeaderProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerHeaderProfile.HeaderImage = global::PrivateDoctorSolution.Properties.Resources.imageListAdv1_Images;
            this.drawerHeaderProfile.HeaderText = "drawerHeaderProfile";
            this.drawerHeaderProfile.Location = new System.Drawing.Point(2, 0);
            this.drawerHeaderProfile.Margin = new System.Windows.Forms.Padding(0);
            this.drawerHeaderProfile.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerHeaderProfile.Name = "drawerHeaderProfile";
            this.drawerHeaderProfile.SelectionColor = System.Drawing.Color.Maroon;
            this.drawerHeaderProfile.Size = new System.Drawing.Size(200, 120);
            this.drawerHeaderProfile.TabIndex = 5;
            this.drawerHeaderProfile.Text = "Mr.Doctor";
            this.drawerHeaderProfile.TextAlign = Syncfusion.Windows.Forms.Tools.TextAlignment.Right;
            this.drawerHeaderProfile.TextColor = System.Drawing.Color.White;
            this.drawerHeaderProfile.Click += new System.EventHandler(this.drawerHeaderProfile_Click);
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
            // drawerMenuItemPatient
            // 
            this.drawerMenuItemPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemPatient.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.drawerMenuItemPatient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.drawerMenuItemPatient.ForeColor = System.Drawing.Color.White;
            this.drawerMenuItemPatient.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(9)))));
            this.drawerMenuItemPatient.ItemText = "Apointment";
            this.drawerMenuItemPatient.Location = new System.Drawing.Point(2, 170);
            this.drawerMenuItemPatient.Margin = new System.Windows.Forms.Padding(0);
            this.drawerMenuItemPatient.MinimumSize = new System.Drawing.Size(200, 50);
            this.drawerMenuItemPatient.Name = "drawerMenuItemPatient";
            this.drawerMenuItemPatient.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.drawerMenuItemPatient.Size = new System.Drawing.Size(200, 50);
            this.drawerMenuItemPatient.TabIndex = 1;
            this.drawerMenuItemPatient.Text = "Patient List";
            this.drawerMenuItemPatient.TextColor = System.Drawing.Color.White;
            this.drawerMenuItemPatient.Click += new System.EventHandler(this.drawerMenuItemPatient_Click);
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
            // MenuBar
            // 
            this.MenuBar.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.MenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.MenuBar.BeforeTouchSize = new System.Drawing.Size(109, 44);
            this.MenuBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.MenuBar.ForeColor = System.Drawing.Color.White;
            this.MenuBar.Image = global::PrivateDoctorSolution.Properties.Resources.Menu;
            this.MenuBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuBar.IsBackStageButton = false;
            this.MenuBar.KeepFocusRectangle = false;
            this.MenuBar.Location = new System.Drawing.Point(3, 0);
            this.MenuBar.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.ResetStateOnLostFocus = false;
            this.MenuBar.Size = new System.Drawing.Size(109, 44);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "Menu";
            this.MenuBar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuBar.UseVisualStyle = true;
            this.MenuBar.Click += new System.EventHandler(this.Menu_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(814, 473);
            this.Controls.Add(this.MenuBar);
            this.Controls.Add(this.navigationDrawer1);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.Name = "DashBoard";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationDrawer navigationDrawer1;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemSchedule;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemPatient;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemEmails;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemLock;
        private Syncfusion.Windows.Forms.Tools.DrawerMenuItem drawerMenuItemLogout;
        private Syncfusion.Windows.Forms.ButtonAdv MenuBar;
        private Syncfusion.Windows.Forms.Tools.DrawerHeader drawerHeaderProfile;
    }
}