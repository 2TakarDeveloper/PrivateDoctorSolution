using System;
using System.Drawing;
using System.Windows.Forms;
using PrivateDoctorSolution.Controls;
using PrivateDoctorSolution.Controls.Mail;
using Syncfusion.Windows.Forms;

namespace PrivateDoctorSolution
{
    public partial class DashBoard : MetroForm
    {

       
        public DashBoard()
        {
            InitializeComponent();
            SettingUpNevDrawer();
            LoadSchedule();
            
        }

        private void SettingUpNevDrawer()
        {
            navigationDrawer1.ContentViewContainer.Padding = new Padding(15, 15, 15, 15);
            navigationDrawer1.ContentViewContainer.BackColor = Color.White;

            navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            navigationDrawer1.DrawerPanelContainer.Padding = new Padding(0, 0, 3, 0);
            navigationDrawer1.TouchThreshold = 0;

            navigationDrawer1.DrawerPanelContainer.BorderStyle = BorderStyle.None;
            navigationDrawer1.DrawerPanelContainer.Paint += DrawerPanelContainer_Paint;

            navigationDrawer1.DrawerPanelContainer.BackColor = Color.FromArgb(53, 53, 53);
        }

        private void DrawerPanelContainer_Paint(object sender, PaintEventArgs e)
        {
            using (var brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillRectangle(brush, navigationDrawer1.DrawerPanelContainer.ClientRectangle);
            }

            var pen = new Pen(Color.FromArgb(42, 42, 42));
            e.Graphics.DrawRectangle(pen, 0, 0, navigationDrawer1.DrawerPanelContainer.ClientSize.Width - 3,
                navigationDrawer1.DrawerPanelContainer.ClientSize.Height - 1);
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemSchedule_Click(object sender, EventArgs e)
        {
            LoadSchedule();
        }
        private void LoadSchedule()
        {
            navigationDrawer1.ContentViewContainer.Controls.Clear();
            var sc = new ScheduleControler { Dock = DockStyle.Fill };
            navigationDrawer1.ContentViewContainer.Controls.Add(sc);
            navigationDrawer1.ToggleDrawer();
        }
        private void drawerMenuItemLock_Click(object sender, EventArgs e)
        {
            navigationDrawer1.ContentViewContainer.Controls.Clear();
            LockForm lc = new LockForm();
            lc.ShowDialog(this);
        }

        private void drawerMenuItemEmails_Click(object sender, EventArgs e)
        {
            navigationDrawer1.ContentViewContainer.Controls.Clear();
            EmailControl ec = new EmailControl {Dock = DockStyle.Fill};
            navigationDrawer1.ContentViewContainer.Controls.Add(ec);
            navigationDrawer1.ToggleDrawer();
        }

        private void drawerMenuItemLogout_Click(object sender, EventArgs e)
        {
           //Give an warning then logout
        }

        private void drawerMenuItemPatient_Click(object sender, EventArgs e)
        {
            navigationDrawer1.ContentViewContainer.Controls.Clear();
            PatientControl pc = new PatientControl(navigationDrawer1) {Dock = DockStyle.Fill};
            navigationDrawer1.ContentViewContainer.Controls.Add(pc);
            navigationDrawer1.ToggleDrawer();
            
        }

        private void drawerHeaderProfile_Click(object sender, EventArgs e)
        {
            navigationDrawer1.ContentViewContainer.Controls.Clear();
            ProfileControl pc = new ProfileControl() { Dock = DockStyle.Fill };
            navigationDrawer1.ContentViewContainer.Controls.Add(pc);
          
        }

       
    }
}
