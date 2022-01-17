using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BD_cyrs
{
    class Mails
    {
        public void mailpost(string mail, string textmail, string topicmail)
        {
            MailAddress fromAdress = new MailAddress("tt980845@gmail.com", "Твоя любимая работа");
            MailAddress toAdress = new MailAddress(mail);
            MailMessage mailMessage = new MailMessage(fromAdress, toAdress);
            mailMessage.Body = textmail;
            mailMessage.Subject = topicmail;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdress.Address, "testingpassword");

            smtpClient.Send(mailMessage);

        }
        
    }
}
