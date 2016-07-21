using System;
using SendGrid.Helpers.Mail;

namespace SendGrid
{
    class Program
    {
        static void Main()
        {
            try
            {
                //dynamic sg = new SendGridAPIClient("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");
                dynamic sg = new SendGridAPIClient("e9v4HwmJTdaz_pLIgR_6EA");
                Email from = new Email("hgouw@yahoo.com");
                String subject = "Sending with SendGrid is Fun";
                Email to = new Email("hermangouw@gmail.com");
                Content content = new Content("text/plain", "and easy to do anywhere, even with C#");
                Mail mail = new Mail(from, subject, to, content);
                dynamic response = sg.client.mail.send.post(requestBody: mail.Get());
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}