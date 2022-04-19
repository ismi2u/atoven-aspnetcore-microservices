using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorRegistration.Application.Contracts.Infrastructure;
using VendorRegistration.Application.Models;

namespace VendorRegistration.Infrastructure.Mail
{
    public class EmailService : IEmailService
    {
      

        public EmailSettings _emailSettings { get;  }

        public ILogger<EmailService> _logger { get; }



        public EmailService(IOptions<EmailSettings> emailSettings, ILogger<EmailService> logger)
        {
            _emailSettings = emailSettings.Value;
            _logger = logger;
        }

        public async Task<bool> SendEmailAsync(Email email)
        {// SG1.ErXMJ5G9RFKW9i7boauZew.
         // 6AxWjKQCV1jdqDHVf-27eyuLpEQyC62hQN1OA-yItYg
            var apiKey = " ";
            var client = new SendGridClient(_emailSettings.ApiKey);
            var from = new EmailAddress
            {
                Email = _emailSettings.FromAddress,
                Name = _emailSettings.FromName
            };
            var subject = email.Subject;
            var to = new EmailAddress(email.To);
            //var plainTextContent = "and easy to do anywhere, even with C#";
            //var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            //var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //var response = await client.SendEmailAsync(msg);
            var emailbody = email.Body;

            var sendGridMessage = MailHelper.CreateSingleEmail(from, to, subject, emailbody, emailbody);
            var response = await client.SendEmailAsync(sendGridMessage);

            _logger.LogInformation("Email Sent!");

            if(response.StatusCode == System.Net.HttpStatusCode.Accepted || response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                _logger.LogError("Sending Email Failed!");
                return true;
            }
          
                return false;

        }
    }
}
