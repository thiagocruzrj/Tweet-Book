using System.Threading.Tasks;

namespace Tweetbook.Services
{
    public interface IIdentityService
    {
        Task<object> RegisterAsync(string email, string password);
    }
}