using System;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class EmailControl : UserControl
    {
        public EmailControl()
        {
            InitializeComponent();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<30;i++)
            {
                InboxMailControl im = new InboxMailControl();
                flowLayoutPanelBody.Controls.Add(im);
            }
        }
    }
}
