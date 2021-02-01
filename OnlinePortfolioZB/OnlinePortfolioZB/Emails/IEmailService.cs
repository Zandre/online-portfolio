using System.Threading.Tasks;

namespace OnlinePortfolioZB.Emails
{
    public interface IEmailService
    {
        Task ContactMe(string name, string email, string message);
    }
}
    