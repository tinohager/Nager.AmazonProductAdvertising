using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nager.AmazonProductAdvertising.UnitTest
{
    [TestClass]
    public class AmazonTest
    {

        [TestMethod]
        public void TestMethod1()
        {

            var authentication = new AmazonAuthentication();
            authentication.AccessKey = "[AccessKey]";
            authentication.SecretKey = "[SECRET]";
            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.ES, "desincuentos-21");
            wrapper.ErrorReceived += response =>
            {
                var error = response;
            };
            var res = wrapper.BatchItemLookupOperation(new List<string> { "B01I4QAERA", "B07H42TBTD", "B075CK3GVJ", "B01CJYNBBY", "B01A9GM5X4", "B00ZB9QJ5K", "B005QJOQEG", "B06XXZLCD2", "B019HAOZ3G", "B01I4QAERA", "B07H42TBTD", "B075CK3GVJ", "B01CJYNBBY", "B01A9GM5X4", "B00ZB9QJ5K", "B005QJOQEG", "B06XXZLCD2", "B019HAOZ3G", "B019HAOZ3G", "B019HAOZ3G" });
        }
    }
}