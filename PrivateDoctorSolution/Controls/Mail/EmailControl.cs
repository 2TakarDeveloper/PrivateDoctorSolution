using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.PDS.Entity.MailClasses;
using S22.Imap;


namespace PrivateDoctorSolution.Controls.Mail
{
    public partial class EmailControl : UserControl
    {
        private string EmailAddress { get; set; }
        private string EmailPassword { get; set; }
        private string ImapServerAddress { get; set; }
        private List<InboxInfo>  InboxInfos { get; set; }
        private IEnumerable<MailMessage> Messages { get; set; }

        public EmailControl()
        {
            InitializeComponent();
          
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

            EmailAddress = EmailAddressTextBox.Text;
            EmailPassword = EmailPasswordTextBox.Text;

        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            flowLayoutPanelBody.Controls.Clear();
            foreach (var inboxInfo in InboxInfos)
            {
                var im = new InboxMailControl(inboxInfo) {Dock = DockStyle.Top};
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
                InboxInfos = new List<InboxInfo>();
                Messages =  client.GetMessages(uids);
          
                foreach (var message in Messages)
                {
                    InboxInfo inboxInfo = new InboxInfo
                    {
                        SubjectName = message.Subject,
                        Date = message.Date().ToString(),
                        SenderName = message.From.ToString()
                    };
                    InboxInfos.Add(inboxInfo);
                  
                }

            }





        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
          ReloadMails();
        }

        private void ReloadMails()
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

            EmailAddress = EmailAddressTextBox.Text;
            EmailPassword = EmailPasswordTextBox.Text;

            BackgroundWorker backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += ReadEmail;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }
    }
}
