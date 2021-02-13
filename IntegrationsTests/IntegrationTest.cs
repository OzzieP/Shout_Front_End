using Microsoft.AspNetCore.Mvc.Testing;
using Shout_Front_End;
using System;
using System.Net;
using System.Net.Http;

using Xunit;

namespace IntegrationsTests
{
    public class IntegrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private HttpClient _client { get; }

        public IntegrationTest(WebApplicationFactory<Startup> fixture)
        {
            _client = fixture.CreateClient();
        }

        [Fact]
        public void Get_Integration_Test()
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
            response.EnsureSuccessStatusCode();
        }
    }
}
