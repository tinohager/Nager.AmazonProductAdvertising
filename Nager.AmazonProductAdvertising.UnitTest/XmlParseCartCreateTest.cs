using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;
using System.Linq;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseCartCreateTest
    {
        [TestMethod]
        [DeploymentItem("CartCreateResponse1.xml")]
        public void ParseCartCreateResponse()
        {
            var xml = File.ReadAllText("CartCreateResponse1.xml");
            var result = XmlHelper.ParseXml<CartCreateResponse>(xml);
            Assert.AreNotEqual(null, result);
        }
    }
}
