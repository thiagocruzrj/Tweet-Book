using Cosmonaut;
using Cosmonaut.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public class CosmosPostService : IPostService
    {
        private readonly ICosmosStore<CosmosPostDto> _cosmosStore;

        public CosmosPostService(ICosmosStore<CosmosPostDto> cosmosStore)
        {
            _cosmosStore = cosmosStore;
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            var posts = await _cosmosStore.Query().ToListAsync();

            return posts.Select(x => new Post { Id = Guid.Parse(x.Id), Name = x.Name }).ToList();
        }

        public Task<Post> GetPostByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> CreatePostAsync(Post post)
        {
            var cosmosPost = new CosmosPostDto
            {
                Id = post.Id.ToString(),
                Name = post.Name
            };

            var response = await _cosmosStore.AddAsync(cosmosPost);
            return response.IsSuccess;
        }

        public Task<bool> UpdatePostAsync(Post postToUpdate)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePostAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}