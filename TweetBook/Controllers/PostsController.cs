using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TweetBook.Domain;

namespace TweetBook.Controllers
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

        }
    }
}
