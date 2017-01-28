using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseBrowseNodeLookupTest
    {
        [TestMethod]
        [DeploymentItem("BrowseNodeLookupResponse1.xml")]
        public void ParseBrowseNodeLookupResponse1()
        {
            var xml = File.ReadAllText("BrowseNodeLookupResponse1.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.BrowseNodes);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode.Children);
            Assert.AreEqual(13, result.BrowseNodes.BrowseNode.Children.Length);
        }

        [TestMethod]
        [DeploymentItem("BrowseNodeLookupResponse2.xml")]
        public void ParseBrowseNodeLookupResponse2()
        {
            var xml = File.ReadAllText("BrowseNodeLookupResponse2.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.BrowseNodes);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode.TopSellers);
            Assert.AreEqual("TopSellers", result.BrowseNodes.BrowseNode.TopItemSet.Type);
            Assert.AreEqual(10, result.BrowseNodes.BrowseNode.TopItemSet.TopItem.Length);
            Assert.AreEqual("B01FY5MQSO", result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].ASIN);
            Assert.AreEqual("TV Series Episode Video on Demand", result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].ProductGroup);
            Assert.AreEqual("Die Tür", result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].Title);
        }

        [TestMethod]
        [DeploymentItem("BrowseNodeLookupResponseWithError.xml")]
        public void ParseBrowseNodeLookupResponseWithError()
        {
            var xml = File.ReadAllText("BrowseNodeLookupResponseWithError.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("AWS.InvalidParameterValue", result.BrowseNodes.Request.Errors[0].Code);
        }

        [TestMethod]
        [DeploymentItem("BrowseNodeLookupErrorResponse.xml")]
        public void ParseBrowseNodeLookupErrorResponse()
        {
            var xml = File.ReadAllText("BrowseNodeLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupErrorResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("MissingClientTokenId", result.Error.Code);
        }
    }
}
