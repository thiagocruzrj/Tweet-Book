using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;
using Xunit;

namespace Tweetbook.IntegrationTests
{
    public class UnitTest1
    {
        private readonly HttpClient _client;

        public UnitTest1()
        {
            var appFactory = new WebApplicationFactory<Startup>().CreateClient();
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
