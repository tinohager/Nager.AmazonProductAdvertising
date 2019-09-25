using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [Ignore]
    [TestClass]
    public class Paapi5Test
    {
        private AmazonProductAdvertisingClient _client;

        [TestInitialize]
        public void TestInitialize()
        {
            var amazonAuthentication = new AmazonAuthentication("accessKey", "secretKey");
            this._client = new AmazonProductAdvertisingClient(amazonAuthentication, AmazonEndpoint.DE, "partnerTag", strictJsonMapping: true);
        }

        [DataTestMethod]
        [DataRow("Auto")]
        [DataRow("Kleider")]
        [DataRow("Schuhe")]
        [DataRow("Staubsauger")]
        public async Task SearchItemsTest1(string keyword)
        {
            var response = await this._client.SearchItemsAsync(keyword);
            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.SearchResult.Items.Length);
        }

        [TestMethod]

        public async Task SearchItemsTest2()
        {
            var request = new SearchRequest
            {
                BrowseNodeId = "84230031",
                SortBy = SortBy.AvgCustomerReviews,
                Keywords = "*",
                Resources = new[]
                {
                    "Images.Primary.Small",
                    "ItemInfo.Title",
                },
            };

            var response = await this._client.SearchItemsAsync(request);
            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.SearchResult.Items.Length);
        }

        [DataTestMethod]
        [DataRow("B00IYD5QUO")] //shower gel
        [DataRow("B07CJPSNX8")] //clothes, dress
        [DataRow("3551317267")] //book, harry potter
        [DataRow("B00BQ6RS7K")] //food, sweets
        [DataRow("B01LFB3R0W")] //electronic, cable
        public async Task GetItemsTest(string asin)
        {
            var response = await this._client.GetItemsAsync(asin);
            Assert.IsTrue(response.Successful);
            Assert.AreEqual(1, response.ItemsResult.Items.Length);
        }

        [TestMethod]
        public async Task GetVariationsTest()
        {
            var response = await this._client.GetVariationsAsync("B07QP2SF9J");
            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.VariationsResult.Items.Length);
        }
    }
}
