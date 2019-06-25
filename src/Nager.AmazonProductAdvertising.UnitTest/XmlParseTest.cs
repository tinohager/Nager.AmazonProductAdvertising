using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nager.AmazonProductAdvertising.Model;
using System.IO;
using System.Linq;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class XmlParseTest
    {
        [TestMethod]
        [DeploymentItem("AmazonResponse.xml")]
        public void ParseAmazonResponse()
        {
            var xml = File.ReadAllText("AmazonResponse.xml");
            var result = XmlHelper.ParseXml<AmazonResponse>(xml);
            Assert.AreNotEqual(null, result);
            Assert.AreEqual("Nager.AmazonProductAdvertising", result.OperationRequest.HTTPHeaders.Where(o => o.Name == "UserAgent").Select(o => o.Value).FirstOrDefault());
            Assert.AreEqual("66a39e87-ffa2-424f-9bac-250309a172bf", result.OperationRequest.RequestId);
            Assert.AreEqual("AWSAccessKeyId", result.OperationRequest.Arguments.Where(o => o.Name == "AWSAccessKeyId").Select(o => o.Value).FirstOrDefault());
            Assert.AreEqual("nagerat-21", result.OperationRequest.Arguments.Where(o => o.Name == "AssociateTag").Select(o => o.Value).FirstOrDefault());
            Assert.AreEqual("canon eos", result.OperationRequest.Arguments.Where(o => o.Name == "Keywords").Select(o => o.Value).FirstOrDefault());
            Assert.AreEqual("ItemSearch", result.OperationRequest.Arguments.Where(o => o.Name == "Operation").Select(o => o.Value).FirstOrDefault());
        }
    }
}
