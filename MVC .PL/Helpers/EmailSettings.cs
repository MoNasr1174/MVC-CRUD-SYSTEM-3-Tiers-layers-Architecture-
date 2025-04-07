using MVC.DAL.Models;
using System.Net;
using System.Net.Mail;

namespace MVC_.PL.Helpers
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            var mailServer = new SmtpClient("smtp.gmail.com", 587);
            mailServer.EnableSsl = true;
            mailServer.Credentials = new NetworkCredential("mohamednasr117411@gmail.com", "ujqsfuzflocceivt");
           // ujqs fuzf locc eivt

            mailServer.Send("mohamednasr117411@gmail.com", email.RecipientsS, email.Subject, email.Body);
        }
    }
}
