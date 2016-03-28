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
            //Assert.AreEqual(result.Items.Request.Errors[0].Code, "AWS.RestrictedParameterValueCombination");
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
        public void ParseItemLookupResponse()
        {
            var xml = File.ReadAllText("ItemLookupResponse.xml");
            var result = XmlHelper.ParseXml<ItemLookupResponse>(xml);
            Assert.AreNotEqual(result, null);
            Assert.AreEqual(result.Items.Item.Length, 1);
            Assert.AreEqual(result.Items.Item[0].ASIN, "B007KKKJYK");
            Assert.AreEqual(result.Items.Item[0].ItemAttributes.Title, "Canon EOS 5D Mark III SLR-Digitalkamera (22 Megapixel, CMOS-Sensor, 8,1 cm (3,2 Zoll) Display, DIGIC 5+ Prozessor) Gehäuse schwarz");
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
    }
}
