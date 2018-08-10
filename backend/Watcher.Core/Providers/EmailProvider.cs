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

        public async Task SendMessageOneToOne(string from,string subject, string recepient, string message, string messageHtml)
        {
            var fromAddress = new EmailAddress(from);
            var recepientsAddress =  new EmailAddress(recepient);
            
            var msg = MailHelper.CreateSingleEmail(fromAddress, recepientsAddress, subject, message, messageHtml);
        
            var client = new SendGridClient(_configuration.GetSection("SENDGRID_API_KEY").Value);

            var response = await client.SendEmailAsync(msg);
        }

        public async Task SendMessageOneToMany(string from, string subject, List<string> recepients, string message, string messageHtml)
        {
            var fromAddress = new EmailAddress(from);
            var recepientsAddresses = recepients.Select(r => new EmailAddress(r)).ToList();

            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(fromAddress, recepientsAddresses, subject, message, messageHtml);

            var client = new SendGridClient(_configuration.GetSection("SENDGRID_API_KEY").Value);

            var response = await client.SendEmailAsync(msg);
        }

    }
}
