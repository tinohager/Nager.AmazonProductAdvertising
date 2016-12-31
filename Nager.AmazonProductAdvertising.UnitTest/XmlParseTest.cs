using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseTest
    {
        [TestMethod]
        [DeploymentItem("ItemSearchResponse.xml")]
        public void ParseItemSearchResponse()
        {
            var xml = File.ReadAllText("ItemSearchResponse.xml");
            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual(10, result.Items.Item.Length);
        }

        [TestMethod]
        [DeploymentItem("ItemSearchResponseWithError.xml")]
        public void ParseItemSearchResponseWithError()
        {
            var xml = File.ReadAllText("ItemSearchResponseWithError.xml");
            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("AWS.RestrictedParameterValueCombination", result.Items.Request.Errors[0].Code);
        }

        [TestMethod]
        [DeploymentItem("ItemSearchErrorResponse.xml")]
        public void ParseItemSearchErrorResponse()
        {
            var xml = File.ReadAllText("ItemSearchErrorResponse.xml");
            var result = XmlHelper.ParseXml<ItemSearchErrorResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.RequestId);
            Assert.AreNotEqual(null, result.Error.Code);
            Assert.AreNotEqual(null, result.Error.Message);
        }

        [TestMethod]
        [DeploymentItem("ItemLookupResponse1.xml")]
        public void ParseItemLookupResponse1()
        {
            var xml = File.ReadAllText("ItemLookupResponse1.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual(1, result.Items.Item.Length);
            Assert.AreEqual("B007KKKJYK", result.Items.Item[0].ASIN);
            Assert.AreEqual("Canon EOS 5D Mark III SLR-Digitalkamera (22 Megapixel, CMOS-Sensor, 8,1 cm (3,2 Zoll) Display, DIGIC 5+ Prozessor) Gehäuse schwarz", result.Items.Item[0].ItemAttributes.Title);
            Assert.AreEqual(5, result.Items.Item[0].ItemAttributes.Feature.Length);
        }

        [TestMethod]
        [DeploymentItem("ItemLookupResponse2.xml")]
        public void ParseItemLookupResponse2()
        {
            var xml = File.ReadAllText("ItemLookupResponse2.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual(1, result.Items.Item.Length);
            Assert.AreEqual("B00BYPW00I", result.Items.Item[0].ASIN);
            Assert.AreEqual("Canon EOS 700D SLR-Digitalkamera (18 Megapixel, 7,6 cm (3 Zoll) Touchscreen, Full HD, Live-View) Kit inkl. EF-S 18-55mm 1:3,5-5,6 IS STM", result.Items.Item[0].ItemAttributes.Title);
            Assert.AreEqual(12, result.Items.Item[0].ItemAttributes.Platform.Length);
            Assert.AreEqual("EUR 538,18", result.Items.Item[0].Offers.Offer[0].OfferListing[0].Price.FormattedPrice);
        }

        [TestMethod]
        [DeploymentItem("ItemLookupResponse3.xml")]
        public void ParseItemLookupResponse3()
        {
            var xml = File.ReadAllText("ItemLookupResponse3.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual(1, result.Items.Item.Length);
            Assert.AreEqual("3955610977", result.Items.Item[0].ASIN);
            Assert.AreEqual("C# 5.0 - kurz & gut", result.Items.Item[0].ItemAttributes.Title);
            Assert.AreEqual(2, result.Items.Item[0].ItemAttributes.Author.Length);
        }

        [TestMethod]
        [DeploymentItem("ItemLookupResponse4.xml")]
        public void ParseItemLookupResponse4()
        {
            var xml = File.ReadAllText("ItemLookupResponse4.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual(1, result.Items.Item.Length);
            Assert.AreEqual("B00189AYJY", result.Items.Item[0].ASIN);
            Assert.AreEqual("Iron Man [Blu-ray]", result.Items.Item[0].ItemAttributes.Title);
            Assert.AreEqual(5, result.Items.Item[0].ItemAttributes.Actor.Length);
            Assert.AreEqual(3, result.Items.Item[0].ItemAttributes.CatalogNumberList.Length);
            Assert.AreEqual(2, result.Items.Item[0].ItemAttributes.Creator.Length);
            Assert.AreEqual("Hauptdarsteller", result.Items.Item[0].ItemAttributes.Creator[0].Role);
            Assert.AreEqual("Robert Downey Jr.", result.Items.Item[0].ItemAttributes.Creator[0].Name);
        }

        [TestMethod]
        [DeploymentItem("ItemLookupErrorResponse.xml")]
        public void ParseItemLookupErrorResponse()
        {
            var xml = File.ReadAllText("ItemLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<ItemLookupErrorResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.RequestId);
            Assert.AreNotEqual(null, result.Error.Code);
            Assert.AreNotEqual(null, result.Error.Message);
        }

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
