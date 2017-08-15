using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseBrowseNodeLookupTest
    {
        [TestMethod]
        [DeploymentItem("BrowseNodeLookupResponse1.xml")]
        public void ParseBrowseNodeLookupResponse1()
        {
            var xml = Resources.LoadResource("BrowseNodeLookupResponse1.xml");
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
            var xml = Resources.LoadResource("BrowseNodeLookupResponse2.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.BrowseNodes);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode);
            Assert.AreNotEqual(null, result.BrowseNodes.BrowseNode.TopSellers);
            Assert.AreEqual("TopSellers", result.BrowseNodes.BrowseNode.TopItemSet.Type);
            Assert.AreEqual(10, result.BrowseNodes.BrowseNode.TopItemSet.TopItem.Length);
            Assert.AreEqual("B01FY5MQSO", result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].ASIN);
            Assert.AreEqual("TV Series Episode Video on Demand",
                result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].ProductGroup);
            Assert.AreEqual("Die Tür", result.BrowseNodes.BrowseNode.TopItemSet.TopItem[0].Title);
        }

        [TestMethod]
        [DeploymentItem("BrowseNodeLookupResponseWithError.xml")]
        public void ParseBrowseNodeLookupResponseWithError()
        {
            var xml = Resources.LoadResource("BrowseNodeLookupResponseWithError.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("AWS.InvalidParameterValue", result.BrowseNodes.Request.Errors[0].Code);
        }

        [TestMethod]
        [DeploymentItem("BrowseNodeLookupErrorResponse.xml")]
        public void ParseBrowseNodeLookupErrorResponse()
        {
            var xml = Resources.LoadResource("BrowseNodeLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupErrorResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("MissingClientTokenId", result.Error.Code);
        }

     
    }
}