using System.Threading.Tasks;

namespace Tweetbook.Services
{
    public class IdentityService : IIdentityService
    {
        public Task<object> RegisterAsync(string email, string password)
        {
            throw new System.NotImplementedException();
        }
    }
}