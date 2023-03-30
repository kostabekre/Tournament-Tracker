using System.Net.Mail;

namespace TrackerLibrary
{

    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("SenderEmail"));

            MailMessage mail = new MailMessage();

            mail.To.Add(to);
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            // Could not set host and port in app.config due system.net is obsolete 
            client.Host = "localhost";
            client.Port = 25;

            client.Send(mail);
        }
    }
}
