using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tweetbook.Contract.V1;
using Tweetbook.Controllers.V1.Requests;
using Tweetbook.Services;

namespace Tweetbook.Controllers.V1
{
    public class IdentityController : Controller
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost(ApiRoutes.Identity.Register)]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest userRegistration)
        {
            var registration
            return Ok();
        }
    }
}