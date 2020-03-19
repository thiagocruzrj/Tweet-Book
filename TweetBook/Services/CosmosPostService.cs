using Cosmonaut;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TweetBook.Domain;

namespace TweetBook.Services
{
    public class CosmosPostService : IPostService
    {
        private readonly ICosmosStore<CosmosPostDto> _cosmosStore;

        public CosmosPostService(ICosmosStore<CosmosPostDto> cosmosStore)
        {
            _cosmosStore = cosmosStore;
        }

        public async Task<bool> CreatePost(Post post)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeletePost(Guid postId)
        {
            throw new NotImplementedException();
        }

        public async Task<Post> GetPostById(Guid postId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Post>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdatePost(Post postUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
