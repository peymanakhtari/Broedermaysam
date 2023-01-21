using System.Net.Mail;

namespace Maysam.Utility
{
    public class Utility
    {
        public static void SendEmail(string massage, string body)
        {
            MailMessage mail = new MailMessage();

             mail.To.Add("Maysamzahiri@gmail.com");
          // mail.To.Add("peymanakhtari@outlook.com");
           // mail.To.Add("peyman.akhtari.73@gmail.com");
            mail.From = new MailAddress("admin@broedermaysam.nl");
            mail.Subject = massage;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient("mail.broedermaysam.nl", 25);

            client.Credentials = new System.Net.NetworkCredential("admin@broedermaysam.nl", "*Tw7@H567ZcStt");
            client.Send(mail);
        }
    }
}
