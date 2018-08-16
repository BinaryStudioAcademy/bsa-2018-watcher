using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Watcher.Core.Interfaces;

namespace Watcher.Core.Providers
{
    public class EmailProvider : IEmailProvider
    {
        private readonly IConfiguration _configuration;

        public EmailProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private async Task SendMessage(string from, string subject, List<string> recepients, string message, string messageHtml)
        {
            var fromAddress = new EmailAddress(from);
            var recepientsAddresses = recepients.Select(r => new EmailAddress(r)).ToList();

            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(fromAddress, recepientsAddresses, subject, message, messageHtml);

            var client = new SendGridClient(_configuration.GetSection("SENDGRID_API_KEY").Value);

            var response = await client.SendEmailAsync(msg);
        }

        public async Task SendMessageOneToOne(string from, string subject, string recepient, string message, string messageHtml)
        {
            await SendMessage(from, subject, new List<string>() { recepient }, message, messageHtml);
        }
        
        public async Task SendMessageOneToMany(string from, string subject, List<string> recepients, string message, string messageHtml)
        {
            await SendMessage(from, subject, recepients, message, messageHtml);
        }

    }
}
