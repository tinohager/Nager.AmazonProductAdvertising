using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseCartTest
    {
        [TestMethod]
        [DeploymentItem("CartCreateResponse1.xml")]
        public void ParseCartCreateResponse()
        {
            var xml = File.ReadAllText("CartCreateResponse1.xml");
            var result = XmlHelper.ParseXml<CartCreateResponse>(xml);
            Assert.AreNotEqual(null, result);
        }

        [TestMethod]
        [DeploymentItem("CartGetResponse1.xml")]
        public void ParseCartGetResponse1()
        {
            var xml = File.ReadAllText("CartGetResponse1.xml");
            var result = XmlHelper.ParseXml<CartGetResponse>(xml);
            Assert.AreNotEqual(null, result);
        }

        [TestMethod]
        [DeploymentItem("CartGetResponse2.xml")]
        public void ParseCartGetResponse2()
        {
            var xml = File.ReadAllText("CartGetResponse2.xml");
            var result = XmlHelper.ParseXml<CartGetResponse>(xml);
            Assert.AreNotEqual(null, result);
        }
    }
}
