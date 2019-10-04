using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class DeserializeObjectTest
    {
        private JsonSerializerSettings _jsonSerializerSettingsResponse;

        [TestInitialize]
        public void TestInitialize()
        {
            this._jsonSerializerSettingsResponse = new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Error
            };
        }

        [TestMethod]
        [DeploymentItem(@"Responses\SearchResult1.json")]
        public void DeserializeObjectSearch1()
        {
            var json = File.ReadAllText(@"Responses\SearchResult1.json");
            var response = JsonConvert.DeserializeObject<SearchItemResponse>(json, this._jsonSerializerSettingsResponse);

            Assert.IsNotNull(response.SearchResult);
        }

        [TestMethod]
        [DeploymentItem(@"Responses\SearchResult2.json")]
        public void DeserializeObjectSearch2()
        {
            var json = File.ReadAllText(@"Responses\SearchResult2.json");
            var response = JsonConvert.DeserializeObject<SearchItemResponse>(json, this._jsonSerializerSettingsResponse);

            Assert.IsNotNull(response.SearchResult);
        }

        [TestMethod]
        [DeploymentItem(@"Responses\SearchResult3.json")]
        public void DeserializeObjectSearch3()
        {
            var json = File.ReadAllText(@"Responses\SearchResult3.json");
            var response = JsonConvert.DeserializeObject<SearchItemResponse>(json, this._jsonSerializerSettingsResponse);

            Assert.IsNotNull(response.SearchResult);
        }

        [TestMethod]
        [DeploymentItem(@"Responses\SearchNoResults.json")]
        public void DeserializeObjectSearch4()
        {
            var json = File.ReadAllText(@"Responses\SearchNoResults.json");
            var response = JsonConvert.DeserializeObject<SearchItemResponse>(json, this._jsonSerializerSettingsResponse);

            Assert.IsNull(response.SearchResult);
            Assert.AreEqual("NoResults", response.Errors[0].Code);
        }

        [TestMethod]
        [DeploymentItem(@"Responses\TooManyRequestsException.json")]
        public void DeserializeTooManyRequests()
        {
            var json = File.ReadAllText(@"Responses\TooManyRequestsException.json");
            var response = JsonConvert.DeserializeObject<SearchItemResponse>(json, this._jsonSerializerSettingsResponse);

            Assert.IsNull(response.SearchResult);
            Assert.AreEqual("TooManyRequests", response.Errors[0].Code);
        }
    }
}
