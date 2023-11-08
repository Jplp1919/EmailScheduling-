using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSchedule
{
    internal class Email
    {
      public void sendMail(string to, string body, string subject)
        {
            var from = "EMAIL";
            var pass = "PASSWORD";

            var message = new MailMessage(to, from);

            message.Subject = subject;
            message.Body = body;

            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(to, pass)
            };


            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }



        }

    }
}
