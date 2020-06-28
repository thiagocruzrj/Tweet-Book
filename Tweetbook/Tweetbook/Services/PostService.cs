using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Data;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public class PostService : IPostService
    {
        private readonly DataContext _dataContext;

        public PostService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Post GetPostById(Guid id)
        {
            return _dataContext.Posts.Find(id);
        }

        public async Task<List<Post>> GetPosts()
        {
            return await _dataContext.Posts.ToListAsync();
        }

        public bool UpdatePost(Post postToUpdate)
        {
            var exists = GetPostById(postToUpdate.Id) != null;

            if (!exists)
                return false;

            var index = _posts.FindIndex(x => x.Id == postToUpdate.Id);
            _posts[index] = postToUpdate;
            return true;
        }

        public bool DeletePost(Guid id)
        {
            var post = GetPostById(id);

            if (post == null)
                return false;

            _posts.Remove(post);
                return true;
        }
    }
}