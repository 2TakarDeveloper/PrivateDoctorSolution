using System.Windows.Forms;
using DTD.PDS.Entity.MailClasses;

namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class InboxMailControl : UserControl
    {
        public InboxMailControl(InboxInfo inboxInfo)
        {
            InitializeComponent();
            NameX.Text = inboxInfo.SenderName;
            Subject.Text = inboxInfo.SubjectName;
            Date.Text = inboxInfo.Date;
        }
    }
}
