using System.Collections.Generic;

namespace Tweetbook.Controllers.Responses
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}