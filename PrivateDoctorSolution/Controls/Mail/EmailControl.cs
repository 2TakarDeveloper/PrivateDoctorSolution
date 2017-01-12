using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using S22.Imap;


namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class EmailControl : UserControl
    {
        private string EmailAddress { get; set; }
        private string EmailPassword { get; set; }
        private string ImapServerAddress { get; set; }
       
        private IEnumerable<MailMessage> Messages { get; set; }

        public EmailControl()
        {
            InitializeComponent();
          
           

            LoadSettings();
            EmailAddress = EmailAddressTextBox.Text;
            EmailPassword = EmailPasswordTextBox.Text;

        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            flowLayoutPanelBody.Controls.Clear();
            foreach (var mail in Messages)
            {
                var im = new InboxMailControl(mail) {Dock = DockStyle.Top};
                flowLayoutPanelBody.Controls.Add(im);
            }
            
        }

        private  void ReadEmail(object sender, DoWorkEventArgs e)
        {
           
            // The default port for IMAP over SSL is 993.
           using (ImapClient client =  new ImapClient(ImapServerAddress, 993, EmailAddress, EmailPassword, AuthMethod.Login, true))
            {
                
                IEnumerable<uint> uids = client.Search(SearchCondition.Unseen());
                // Download mail messages from the default mailbox.
                Messages = new List<MailMessage>();
             
                Messages =  client.GetMessages(uids);
          
              

            }





        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailAddressTextBox.Text) ||
                string.IsNullOrEmpty(EmailPasswordTextBox.Text))
            {
                MessageBox.Show(@"Invalid Mail or Password");
                return;
            }
            try
            {
                ReloadMails();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ReloadMails()
        {
           

            EmailAddress = EmailAddressTextBox.Text;
            EmailPassword = EmailPasswordTextBox.Text;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += ReadEmail;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EmailAddressTextBox.Text) ||
                string.IsNullOrEmpty(EmailPasswordTextBox.Text))
            {
                MessageBox.Show(@"Invalid Mail or Password");
                return;
            }
            try
            {
                if (File.Exists("settings.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("settings.txt"))
                    {

                        writer.WriteLine(EmailAddressTextBox.Text + "," + EmailPasswordTextBox.Text + "," + EmailServer.Text);
                    }
                }

                else
                {
                  
                    using (StreamWriter writer = new StreamWriter("settings.txt"))
                    {

                        writer.WriteLine(EmailAddressTextBox.Text + "," + EmailPasswordTextBox.Text+","+EmailServer.Text);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LoadSettings()
        {
           

            using (var reader = new StreamReader("settings.txt"))
            {
                string line;
               
                while ((line = reader.ReadLine()) != null)
                {
                    var sarr = line.Split(',');
                    EmailAddressTextBox.Text = sarr[0];
                    EmailPasswordTextBox.Text = sarr[1];
                    EmailServer.Text = sarr[2];
                }
            }
        }

        private void EmailServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (EmailServer.Text)
            {
                case "Live":
                    ImapServerAddress = "imap-mail.outlook.com";
                    break;
                case "Gmail":
                    ImapServerAddress = "imap.gmail.com";
                    break;
                case "Yahoo":
                    ImapServerAddress = "imap.mail.yahoo.com";
                    break;
                default:
                    ImapServerAddress = "imap-mail.outlook.com";
                    break;
            }
        }
    }
}
