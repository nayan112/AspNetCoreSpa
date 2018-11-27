using System.Threading.Tasks;

namespace MyCommunity.STS.Services
{
    public interface IEmailSender
    {
        Task SendEmail(string email, string subject, string message, string toUsername);
    }
}
