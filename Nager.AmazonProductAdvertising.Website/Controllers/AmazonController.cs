using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nager.AmazonProductAdvertising.Website.Controllers
{
    public class AmazonController : Controller
    {
        private AmazonAuthentication GetConfig()
        {
            var accessKey = ConfigurationManager.AppSettings["AmazonAccessKey"];
            var secretKey = ConfigurationManager.AppSettings["AmazonSecretKey"];

            var authentication = new AmazonAuthentication();
            authentication.AccessKey = accessKey;
            authentication.SecretKey = secretKey;

            return authentication;
        }

        public ActionResult Lookup(string articleNumber)
        {
            if (String.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Lookup(articleNumber);

            return View(result);
        }

        public ActionResult Search(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var responseGroup = AmazonResponseGroup.ItemAttributes | AmazonResponseGroup.Images;
            //var operation = wrapper.ItemSearchOperation(search, AmazonSearchIndex.Electronics, responseGroup);
            //operation.Sort(AmazonSearchSort.Salesrank, AmazonSearchSortOrder.Descending);
            //var webResponse = wrapper.Request(operation);
            //var result = (AmazonItemResponse)XmlHelper.ParseXml<ItemSearchResponse>(webResponse.Content);

            var result = wrapper.Search(search, AmazonSearchIndex.All, responseGroup);

            return View(result);
        }

        public ActionResult Detail(string articleNumber)
        {
            if (String.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Lookup(articleNumber);

            var item = result.Items?.Item.FirstOrDefault();

            return View(item);
        }
    }
}