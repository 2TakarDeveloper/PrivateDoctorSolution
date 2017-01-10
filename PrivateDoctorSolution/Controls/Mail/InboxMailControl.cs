using System.Windows.Forms;
using DTD.PDS.Entity.MailClasses;

namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class InboxMailControl : UserControl
    {
        public InboxMailControl(InboxInfo inboxInfo)
        {
            InitializeComponent();
            string text = inboxInfo.Date+"       " + inboxInfo.SenderName+"         " + inboxInfo.SubjectName;
            MailButton.Text = text;


        }
    }
}
