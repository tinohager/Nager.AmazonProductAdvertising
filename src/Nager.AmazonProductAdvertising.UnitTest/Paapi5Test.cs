using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.Linq;
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
            var accessKey = "";
            var secretKey = "";
            var parnterTag = "";
            var endpoint = AmazonEndpoint.DE;

            var amazonAuthentication = new AmazonAuthentication(accessKey, secretKey);
            this._client = new AmazonProductAdvertisingClient(amazonAuthentication, endpoint, parnterTag, strictJsonMapping: true);
        }

        [DataTestMethod]
        [DataRow("Auto")]
        [DataRow("Kleider")]
        [DataRow("Schuhe")]
        [DataRow("Staubsauger")]
        [DataRow("Teller")]
        [DataRow("Sonnenbrille")]
        [DataRow("Wasserkocher")]
        [DataRow("Nussknacker")]
        public async Task SearchItemsTest1(string keyword)
        {
            var response = await this._client.SearchItemsAsync(keyword);
            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.SearchResult.Items.Length);
        }


        [DataTestMethod]
        [DataRow("Harry Potter")]
        public async Task SearchItemsSearchIndexISBNs(string keyword)
        {
            var response = await this._client.SearchItemsAsync(new SearchRequest()
            {
                Keywords = keyword,
                SearchIndex = SearchIndex.Books,
                Resources = new[]
                {
                    "Images.Primary.Large",
                    "ItemInfo.Title",
                    "ItemInfo.ExternalIds",
                },
            });

            var bookItems = response.SearchResult?.Items.Where(x => !string.IsNullOrEmpty(x.ItemInfo?.ExternalIds?.ISBNs?.DisplayValues.ToString())).ToList();

            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.SearchResult.Items.Length);
            Assert.AreEqual(10, bookItems.Count);
        }

        [DataTestMethod]
        [DataRow("Harry Potter")]
        public async Task SearchItemsSearchIndexNotAllISBNs(string keyword)
        {
            var response = await this._client.SearchItemsAsync(new SearchRequest()
            {
                Keywords = keyword,
                Resources = new[]
                {
                    "Images.Primary.Large",
                    "ItemInfo.Title",
                    "ItemInfo.ExternalIds",
                },
            });

            var bookItems = response.SearchResult?.Items.Where(x => !string.IsNullOrEmpty(x.ItemInfo?.ExternalIds?.ISBNs?.DisplayValues.ToString())).ToList();

            Assert.IsTrue(response.Successful);
            Assert.AreEqual(10, response.SearchResult.Items.Length);
            Assert.AreNotEqual(10, bookItems.Count);
        }

        [DataTestMethod]
        [DataRow("aefsefwdfd")]
        [DataRow("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx")]
        [DataRow("")]
        [DataRow(null)]
        public async Task SearchItemsTest2(string keyword)
        {
            var response = await this._client.SearchItemsAsync(keyword);
            //Assert.IsTrue(response.Successful);
            //Assert.AreEqual(10, response.SearchResult.Items.Length);
        }

        [TestMethod]

        public async Task SearchItemsTest3()
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

        [TestMethod]
        public async Task SearchItemsTest4()
        {
            var request = new SearchRequest
            {
                SortBy = SortBy.AvgCustomerReviews,
                Keywords = "iPhone",
                Resources = new[]
                {
                    "Images.Primary.Small",
                    "ItemInfo.Title",
                },
                Merchant = Merchant.All
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
