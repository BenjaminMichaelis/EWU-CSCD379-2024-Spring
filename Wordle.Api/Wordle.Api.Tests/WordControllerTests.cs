using System.Net;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Wordle.Api.Tests
{
    [TestClass]
    public class WordControllerTests
    {
        private static WebApplicationFactory<Program> factory = new();

        [TestMethod]
        public async Task GetWord_ReturnsSuccess()
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync("word");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [TestMethod]
        public async Task GetWord_ReturnsWord()
        {
            var client = factory.CreateClient();
            var response = await client.GetAsync("word");
            var word = await response.Content.ReadAsStringAsync();

            Assert.IsFalse(string.IsNullOrWhiteSpace(word));
        }
    }
}
