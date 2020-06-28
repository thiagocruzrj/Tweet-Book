using System;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface IPostService
    {
        Task<Post> GetPosts();
        Post GetPostById(Guid id);
    }
}