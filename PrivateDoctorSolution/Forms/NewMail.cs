using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateDoctorSolution.Forms
{
    public partial class NewMail : Form
    {
        private string _emailAddress;
        private string _emailPassword;
        private string SmtpServer;
      

        public NewMail(string emailAddress, string emailPassword, string text)
        {
            InitializeComponent();
            _emailAddress = emailAddress;
            _emailPassword = emailPassword;
           
            switch (text)
            {
                case "Live":
                    SmtpServer = "smtp.live.com";
                    break;
                case "Gmail":
                    SmtpServer = "smtp.gmail.com";
                    break;
                case "Yahoo":
                    SmtpServer = "smtp.mail.yahoo.com";
                    break;
                default:
                    SmtpServer = "smtp.live.com";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMail();
           
        }


        public  void SendMail()
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpClient = new SmtpClient(SmtpServer);

                mail.From = new MailAddress(_emailAddress);
                mail.To.Add(addressTextBox.Text);
                mail.Subject = subjectTextBox.Text;
                mail.Body = richTextBox1.Text;

                SmtpClient.Port = 587;
                SmtpClient.Credentials = new System.Net.NetworkCredential(_emailAddress, _emailPassword);
                SmtpClient.EnableSsl = true;

                SmtpClient.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
