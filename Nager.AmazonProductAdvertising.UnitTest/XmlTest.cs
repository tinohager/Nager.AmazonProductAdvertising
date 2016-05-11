using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlTest
    {
        [TestMethod]
        public void ParseItemSearchResponse()
        {
            var xml = File.ReadAllText("ItemSearchResponse.xml");
            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 10);
        }

        [TestMethod]
        public void ParseItemSearchResponseWithError()
        {
            var xml = File.ReadAllText("ItemSearchResponseWithError.xml");
            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Request.Errors[0].Code, "AWS.RestrictedParameterValueCombination");
        }

        [TestMethod]
        public void ParseItemSearchErrorResponse()
        {
            var xml = File.ReadAllText("ItemSearchErrorResponse.xml");
            var result = XmlHelper.ParseXml<ItemSearchErrorResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreNotEqual(result.RequestId, null);
            Assert.AreNotEqual(result.Error.Code, null);
            Assert.AreNotEqual(result.Error.Message, null);
        }

        [TestMethod]
        public void ParseItemLookupResponse1()
        {
            var xml = File.ReadAllText("ItemLookupResponse1.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 1);
            Assert.AreEqual(result.Items.Item[0].ASIN, "B007KKKJYK");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Title, "Canon EOS 5D Mark III SLR-Digitalkamera (22 Megapixel, CMOS-Sensor, 8,1 cm (3,2 Zoll) Display, DIGIC 5+ Prozessor) Gehäuse schwarz");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Feature.Length, 5);
        }

        [TestMethod]
        public void ParseItemLookupResponse2()
        {
            var xml = File.ReadAllText("ItemLookupResponse2.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 1);
            Assert.AreEqual(result.Items.Item[0].ASIN, "B00BYPW00I");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Title, "Canon EOS 700D SLR-Digitalkamera (18 Megapixel, 7,6 cm (3 Zoll) Touchscreen, Full HD, Live-View) Kit inkl. EF-S 18-55mm 1:3,5-5,6 IS STM");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Platform.Length, 12);
            Assert.AreEqual(result.Items.Item[0].Offers.Offer[0].OfferListing[0].Price.FormattedPrice, "EUR 538,18");
        }

        [TestMethod]
        public void ParseItemLookupResponse3()
        {
            var xml = File.ReadAllText("ItemLookupResponse3.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 1);
            Assert.AreEqual(result.Items.Item[0].ASIN, "3955610977");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Title, "C# 5.0 - kurz & gut");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Author.Length, 2);
        }

        [TestMethod]
        public void ParseItemLookupResponse4()
        {
            var xml = File.ReadAllText("ItemLookupResponse4.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 1);
            Assert.AreEqual(result.Items.Item[0].ASIN, "B00189AYJY");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Title, "Iron Man [Blu-ray]");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Actor.Length, 5);
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.CatalogNumberList.Length, 3);
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Creator.Length, 2);
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Creator[0].Role, "Hauptdarsteller");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Creator[0].Name, "Robert Downey Jr.");
        }

        [TestMethod]
        public void ParseItemLookupErrorResponse()
        {
            var xml = File.ReadAllText("ItemLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<ItemLookupErrorResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreNotEqual(result.RequestId, null);
            Assert.AreNotEqual(result.Error.Code, null);
            Assert.AreNotEqual(result.Error.Message, null);
        }

        [TestMethod]
        public void ParseBrowseNodeLookupResponse()
        {
            var xml = File.ReadAllText("BrowseNodeLookupResponse.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreNotEqual(result.BrowseNodes, null);
            Assert.AreNotEqual(result.BrowseNodes.BrowseNode, null);
            Assert.AreNotEqual(result.BrowseNodes.BrowseNode.Children, null);
            Assert.AreEqual(result.BrowseNodes.BrowseNode.Children.Length, 13);
        }

        [TestMethod]
        public void ParseBrowseNodeLookupResponseWithError()
        {
            var xml = File.ReadAllText("BrowseNodeLookupResponseWithError.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.BrowseNodes.Request.Errors[0].Code, "AWS.InvalidParameterValue");
        }

        [TestMethod]
        public void ParseBrowseNodeLookupErrorResponse()
        {
            var xml = File.ReadAllText("BrowseNodeLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<BrowseNodeLookupErrorResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Error.Code, "MissingClientTokenId");
        }
    }
}