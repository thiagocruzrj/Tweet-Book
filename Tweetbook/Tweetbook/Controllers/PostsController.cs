using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tweetbook.Domain;

namespace Tweetbook.Controllers
{
    public class PostsController : Controller
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
        }

        public IActionResult GetAll()
        {
            return Ok();
        }
    }
}
