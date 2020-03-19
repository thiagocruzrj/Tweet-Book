﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();
        Task<Post> GetPostById(Guid postId);
        Task<bool> CreatePost(Post post);
        Task<bool> UpdatePost(Post postUpdate);
        Task<bool> DeletePost(Guid postId);
    }
}
