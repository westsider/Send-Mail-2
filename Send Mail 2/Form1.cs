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
        public string toEmailAddress = "whansen1@mac.com";
        public string toSmsAddress = "3103824522@tmomail.net";
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
            SmtpClient smtp = new SmtpClient(fromEmailAddress);
            smtp.Port = 25;
            smtp.Host = "smtp.stackmail.com";
            smtp.EnableSsl = false;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmailAddress, fromEmailPass);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmailAddress, "VPN Trade Stats");
            mail.To.Add(toEmailAddress);
            mail.To.Add(toSmsAddress);
            mail.Subject = emailSubject; mail.IsBodyHtml = false; mail.Body = emailMessage;
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Sent Successfully", "Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error ", ex);
            }
            
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
       
