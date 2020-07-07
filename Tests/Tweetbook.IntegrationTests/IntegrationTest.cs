using Microsoft.AspNetCore.Mvc.Testing;
using System.Net.Http;

namespace Tweetbook.IntegrationTests
{
    public class IntegrationTest
    {
        private readonly HttpClient TestClient;

        public IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>();
            TestClient = appFactory.CreateClient();
        }
    }
}
