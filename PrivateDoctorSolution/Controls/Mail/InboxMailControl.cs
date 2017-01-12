using System.Net.Mail;
using System.Windows.Forms;
using PrivateDoctorSolution.Forms;
using S22.Imap;


namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class InboxMailControl : UserControl
    {
        private MailMessage _mail;

        

        public InboxMailControl(MailMessage mail)
        {
            InitializeComponent();
            _mail = mail;
            string text = mail.Date()+"       " + mail.Sender+"         " + mail.Subject;
            MailButton.Text = text;

        }

        private void MailButton_Click(object sender, System.EventArgs e)
        {
            ShowEmail showEmailForm= new ShowEmail(_mail);
            showEmailForm.ShowDialog();

        }
    }
}
