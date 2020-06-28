using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPostById(Guid id);
        bool UpdatePost(Post postToUpdate);
        bool DeletePost(Guid id);
    }
}