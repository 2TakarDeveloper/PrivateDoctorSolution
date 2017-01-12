using System.Net.Mail;
using System.Windows.Forms;

namespace PrivateDoctorSolution
{
    public partial class ShowEmail : Form
    {
        private MailMessage _mail;

      
        public ShowEmail(MailMessage mail)
        {
            InitializeComponent();
            this._mail = mail;
            FromLable.Text = mail.From.ToString();
            SubjectLable.Text=mail.Subject.Normalize();
            richTextBox1.Text = mail.Body;
           



        }
    }
}
