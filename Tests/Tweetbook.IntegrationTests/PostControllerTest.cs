using FluentAssertions;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Tweetbook.Contract.V1;
using Tweetbook.Domain;

namespace Tweetbook.IntegrationTests
{
    public class PostControllerTest : IntegrationTest
    {
        public async Task GetAll_WithoutAnyPosts_ReturnEmptyResponse()
        {
            // Arrange
            await AuthenticateAsync();

            // Act
            var response = await TestClient.GetAsync(ApiRoutes.Posts.GetAll);

            // Assert
            response.StatusCode.Should().Be(HttpStatusCode.Ok);
            await response.Content.ReadAsAsync<List<Post>>().Should().NotEmpty();
        }
    }
}