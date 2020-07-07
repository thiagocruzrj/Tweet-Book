using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using System.Threading.Tasks;
using Tweetbook.Contract.V1;
using Xunit;

namespace Tweetbook.IntegrationTests
{
    public class UnitTest1
    {
        private readonly HttpClient _client;

        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            _client = appFactory.CreateClient();
        }

        [Fact]
        [Trait("TestingReplaceEndpoint", "Replace get endpoint")]
        public async Task TestingReplaceEndpoint()
        {
            await _client.GetAsync(ApiRoutes.Posts.Get.Replace("{postId}", "1"));
        }
    }
}
