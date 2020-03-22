using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TweetBook.Contracts.V1;
using TweetBook.Contracts.V1.Requests;
using TweetBook.Services;

namespace TweetBook.Controllers.V1
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpGet(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest request)
        {
            var authResponse = await _identityService.RegisterAsync();

            return Ok();
        }
    }
}
