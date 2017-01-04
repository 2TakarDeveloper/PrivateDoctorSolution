using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Controls
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
