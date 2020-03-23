using Microsoft.AspNetCore.Http;
using System.Linq;

namespace TweetBook.Extension
{
    public static class GeneralExtension
    {
        public static string GetUserId(this HttpContext httpContext)
        {
            if(httpContext == null)
                return string.Empty;

            return httpContext.User.Claims.Single(x => x.Type == "id").Value;
        }
    }
}
