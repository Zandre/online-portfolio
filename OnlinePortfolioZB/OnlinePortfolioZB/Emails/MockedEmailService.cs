using System.Net.Mail;
using System.Threading.Tasks;

namespace OnlinePortfolioZB.Emails
{
    public class MockedEmailService : IEmailService
    {
        private static SmtpClient _smtpClient;

        public MockedEmailService()
        {
            _smtpClient = new SmtpClient();
            _smtpClient.UseDefaultCredentials = true;
            _smtpClient.Host = "localhost";
        }

        public async Task ContactMe(string name, string email, string message)
        {
            var mailMessage = new MailMessage();
            mailMessage.To.Add("botha.zandre@gmail.com");
            mailMessage.From = new MailAddress(email);
            mailMessage.Body = message;
            mailMessage.Subject = "Online Profile Message";
            string userState = "test message1";
            _smtpClient.SendAsync(mailMessage, userState);
        }
    }
}
