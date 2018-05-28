using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TokenAuth.Web.Messaging
{
    public class EmailService
    {
        private readonly SendGridMessage _message;
        private readonly SendGridClient _client;

        public EmailService(string apiKey, string senderEmail = "info@findjobs.com", string senderName = "Admin")
        {
            _message = new SendGridMessage { From = new EmailAddress(senderEmail, senderName) };
            _client = new SendGridClient(apiKey);
        }

        public async Task<string> SendMail(EmailMessage message, Boolean isHtml)
        {
            this._message.AddTo(message.Recipient);
            this._message.Subject = message.Subject;
            if (isHtml)
            {
                this._message.HtmlContent = message.Message;
            }
            else
            {
                this._message.PlainTextContent = message.Message;
            }


            SendGrid.Response response = await _client.SendEmailAsync(_message);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return "Message was sent successfully";
            else
                return string.Empty;

        }
    }
}