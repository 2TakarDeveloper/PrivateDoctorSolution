using System;
using System.Drawing;
using System.Windows.Forms;
using PrivateDoctorSolution.Controls;
using Syncfusion.Windows.Forms;

namespace PrivateDoctorSolution
{
    public partial class DashBoard : MetroForm
    {

       
        public DashBoard()
        {
            InitializeComponent();
            SettingUpNevDrawer();
          
        }
        public void SettingUpNevDrawer()
        {
            this.navigationDrawer1.ContentViewContainer.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.navigationDrawer1.ContentViewContainer.BackColor = Color.White;

            this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            this.navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 0, 3, 0);
            this.navigationDrawer1.TouchThreshold = 500;

            this.navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            this.navigationDrawer1.DrawerPanelContainer.Paint += new PaintEventHandler(DrawerPanelContainer_Paint);

            this.navigationDrawer1.DrawerPanelContainer.BackColor = Color.FromArgb(53,53,53);
        }
      
        void DrawerPanelContainer_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
                e.Graphics.FillRectangle(brush, this.navigationDrawer1.DrawerPanelContainer.ClientRectangle);

            Pen pen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))));
            e.Graphics.DrawRectangle(pen, 0, 0, this.navigationDrawer1.DrawerPanelContainer.ClientSize.Width - 3, this.navigationDrawer1.DrawerPanelContainer.ClientSize.Height - 1);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemSchedule_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ContentViewContainer.Controls.Clear();
            ScheduleControler sc = new ScheduleControler();
            sc.Dock = DockStyle.Fill;
            this.navigationDrawer1.ContentViewContainer.Controls.Add(sc);
            this.navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemLock_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ContentViewContainer.Controls.Clear();
            this.navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemEmails_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ContentViewContainer.Controls.Clear();
            this.navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemLogout_Click(object sender, EventArgs e)
        {
            this.navigationDrawer1.ContentViewContainer.Controls.Clear();
            this.navigationDrawer1.ToggleDrawer();
        }
    }
}
