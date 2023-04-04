using System.Net.Mail;

namespace SUDMarin.Resources
{
    public static class EmailHelper
    {
        public static void SendEmail(string to, string from, string subject, string body)
        {
            var message = new MailMessage(from, to, subject, body);
            var client = new SmtpClient("smtp.gmail.com", 587);
            client.Credentials = new System.Net.NetworkCredential("username@gmail.com", "password");
            client.EnableSsl = true;
            client.Send(message);
        }
    }
}
