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
        Task<bool> UpdatePost(Post postToUpdate);
        Task<bool> DeletePost(Guid id);
    }
}