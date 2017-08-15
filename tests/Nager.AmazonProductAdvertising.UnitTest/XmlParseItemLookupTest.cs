using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseItemLookupTest
    {
        [TestMethod]
        [DeploymentItem("ItemLookupResponse1.xml")]
        public void ParseItemLookupResponse1()
        {
            var xml = Resources.LoadResource("ItemLookupResponse1.xml");
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
            var xml = Resources.LoadResource("ItemLookupResponse2.xml");
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
            var xml = Resources.LoadResource("ItemLookupResponse3.xml");
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
            var xml = Resources.LoadResource("ItemLookupResponse4.xml");
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
            var xml = Resources.LoadResource("ItemLookupErrorResponse.xml");
            var result = XmlHelper.ParseXml<ItemLookupErrorResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreNotEqual(null, result.RequestId);
            Assert.AreNotEqual(null, result.Error.Code);
            Assert.AreNotEqual(null, result.Error.Message);
        }
    }
}
