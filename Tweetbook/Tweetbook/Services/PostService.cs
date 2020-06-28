using System;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public class PostService : IPostService
    {
        public Post GetPostById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPosts()
        {
            throw new NotImplementedException();
        }
    }
}
