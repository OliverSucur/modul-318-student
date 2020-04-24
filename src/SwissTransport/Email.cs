using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransport
{
    public class Email
    {
        public string data { get; set; }
        public string fromName { get; set; }
        public string emailTo { get; set; }
        public string subject { get; set; }
        private static Email instance;
        
        private Email()
        {
            data = null;
            fromName = null;
            emailTo = null;
            subject = null;
            instance = null;
        }

        public static Email getInstance()
        {
            if (instance == null)
                instance = new Email();

            return instance;
        }

        public void SendEmailConnections()
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("oev.app@gmail.com", "BestApplication4ever2020created!");
                MailMessage msg = new MailMessage();
                msg.To.Add(emailTo);
                msg.From = new MailAddress("oev.app@gmail.com");
                msg.Subject = subject;
                msg.Body = data;
                client.Send(msg);
                MessageBox.Show("E-Mail erfolgreicht versandt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SendEmailOpinion()
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("oev.app@gmail.com", "BestApplication4ever2020created!");
                MailMessage msg = new MailMessage();
                msg.To.Add("oli.sucur@gmx.ch");
                msg.From = new MailAddress("oev.app@gmail.com");
                msg.Subject = "ÖV-Applikation: Meinung eines Benutzers";
                msg.Body = data;
                client.Send(msg);
                MessageBox.Show("E-Mail erfolgreicht versandt!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
