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
            ImapServerAddress = "imap-mail.outlook.com";

            EmailAddress = "tazimtazim2012@hotmail.com";
            EmailPassword = "darks1d1ers";
          
            BackgroundWorker backgroundWorker= new BackgroundWorker();
            backgroundWorker.DoWork += ReadEmail;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var inboxInfo in InboxInfos)
            {
                var im = new InboxMailControl(inboxInfo);
                flowLayoutPanelBody.Controls.Add(im);
            }
            
        }

        private  void ReadEmail(object sender, DoWorkEventArgs e)
        {
           
            // The default port for IMAP over SSL is 993.
           using (ImapClient client =  new ImapClient(ImapServerAddress, 993, EmailAddress, EmailPassword, AuthMethod.Login, true))
            {
                flowLayoutPanelBody.Controls.Clear();
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


       

        private  void InboxButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
