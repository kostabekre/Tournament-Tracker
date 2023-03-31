using System.Net.Mail;

namespace TrackerLibrary
{

    public static class EmailLogic
    {
        public static void SendEmail(string to, string subject, string body)
        {
            SendEmail(new List<string>{to}, subject, body);
        }
        public static void SendEmail(List<string> to, string subject, string body, List<string>? bcc = null)
        {
            MailAddress fromMailAddress = new MailAddress(GlobalConfig.AppKeyLookup("SenderEmail"));

            MailMessage mail = new MailMessage();

            foreach(string email in to)
            {
                mail.To.Add(email);
            }

            if(bcc != null)
            {
                foreach(string email in bcc)
                {
                    mail.Bcc.Add(email);
                }
            }
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            // Could not set host and port in app.config due system.net is obsolete 
            client.Host = "localhost";
            client.Port = 25;

            try
            {

                client.Send(mail);
            }
            catch (SmtpException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
