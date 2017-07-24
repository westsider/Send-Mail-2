using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Send_Mail_2
{
    public partial class Form1 : Form
    {
        public string toEmailAddress_1 = "whansen1@mac.com";
        public string toEmailAddress_2 = "3103824522@tmomail.net";
        public string emailSubject = "Test from VS";
        public string emailMessage = "Message from VS";
        public string fromEmailAddress = "trader1@tradestrat.net";
        public string fromEmailPass = "Si062fcaa";

        public Form1()
        {
            InitializeComponent();
        }
        public void sendTheMail()
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 25;
            sc.Host = "smtp.stackmail.com";
            sc.EnableSsl = false;
            sc.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPass);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmailAddress, "VPN Trade Stats");
            mail.To.Add(toEmailAddress_1);
            mail.Subject = emailSubject; mail.IsBodyHtml = true; mail.Body = emailMessage;
            sc.Send(mail);
        }

        private void sendMailBttn_Click(object sender, EventArgs e)
        {
            sendTheMail();
            Console.WriteLine("Clicked Send Mail");

            // TODO:- mail sent + completion handler -> sent or error
            // TODO - Add 2nd email address
        }

   
    }
}
       
