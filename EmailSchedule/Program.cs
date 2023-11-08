using EmailSchedule;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;

var mail = new Email();


var body = "Este é um teste do agendamento de emails, por favor entre em panico";
var subject = "Teste de agendamento de emails";
var destinatario = "EMAIL";

//mail.sendMail(destinatario, body, subject);

Schedule schedule = new Schedule();
while (true)
{

    if (DateTime.Now.ToString("HH:mm")== "11:26")
    {
       
        mail.sendMail(destinatario, body, subject);
    }
    Thread.Sleep(60000);


}



