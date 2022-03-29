using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace OnlinePortfolioZB.Emails
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task ContactMe(string name, string email, string message)
        {
            var sendGridClient = new SendGridClient(_emailSettings.SENDGRID_API_KEY);

            var sendGridMessage = new SendGridMessage();
            sendGridMessage.SetFrom(email: "no-reply@cvzandrebotha.com", name: name); // TODO ZB - this might be incorrect, ENR Management works differently
            sendGridMessage.SetSubject("Online Profile Message");
            sendGridMessage.AddTo(new EmailAddress(email: "botha.zandre@gmail.com", name: "Zandre Botha"));
            sendGridMessage.AddContent(MimeType.Html, $"{message} [from {email}]");
            sendGridMessage.AddContent(MimeType.Text, $"{message} [from {email}]");

            var response = await sendGridClient.SendEmailAsync(sendGridMessage).ConfigureAwait(false);
        }
    }
}
