using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSchedule
{
    internal class Schedule
    {
        //int sleepTime = 1;
        
        public Task StartAsync(string to, string body, string subject)
        {
            Task.Run(() => sendMail(to, body, subject));
            return Task.CompletedTask;
        }
        private static void sendMail(string to, string body, string subject)
        {
            while (true)
            {
                if(DateTime.Now.Hour == 11 ) {
                    Email mail = new Email();
                    mail.sendMail(to, body,subject);
                }
                Thread.Sleep(60000);

            }
        }

    }
}
