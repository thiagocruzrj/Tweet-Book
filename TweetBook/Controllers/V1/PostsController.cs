using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TweetBook.Contracts.V1;
using TweetBook.Contracts.V1.Requests;
using TweetBook.Contracts.V1.Response;
using TweetBook.Domain;
using TweetBook.Extension;
using TweetBook.Services;

namespace TweetBook.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PostsController : Controller
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet(ApiRoutes.Posts.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _postService.GetPostsAsync());
        }

        [HttpGet(ApiRoutes.Posts.GetById)]
        public async Task<IActionResult> GetById([FromRoute] Guid postId)
        {
            var post = await _postService.GetPostByIdAsync(postId);

            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPut(ApiRoutes.Posts.Update)]
        public async Task<IActionResult> Update([FromRoute] Guid postId, [FromBody] UpdatePostRequest request)
        {
            //var userOwnsPost = await _postService.UseOwnsPostAsync();
            var post = new Post
            {
                Id = postId,
                Name = request.Name
            };

            var updated = await _postService.UpdatePostAsync(post);

            if(updated)
                return Ok(post);

            return NotFound();
        }

        [HttpPost(ApiRoutes.Posts.Create)]
        public async Task<IActionResult> Create([FromBody] CreatePostRequest postRequest)
        {
            var post = new Post { Name = postRequest.Name, UserId = HttpContext.GetUserId() }; 

            await _postService.CreatePostAsync(post);

            var baseUrl = $"{ HttpContext.Request.Scheme}://{HttpContext.Request.Host.ToUriComponent()}";
            var locationUrl = baseUrl + "/" + ApiRoutes.Posts.GetById.Replace("{postId}", post.Id.ToString());

            var response = new PostResponse { Id = post.Id };
            return Created(locationUrl, response);
        }

        [HttpDelete(ApiRoutes.Posts.Delete)]
        public async Task<IActionResult> Delete([FromRoute] Guid postId)
        {
            var deleted = await _postService.DeletePostAsync(postId);

            if (deleted) return NoContent();

            return NotFound();
        }
    }
}
