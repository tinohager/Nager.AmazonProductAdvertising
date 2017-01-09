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

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US);
            var result = wrapper.Lookup(articleNumber.Trim());

            return View(result);
        }

        public ActionResult Lookups(string[] articleNumbers)
        {
            if (articleNumbers == null)
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US);
            var result = wrapper.Lookup(articleNumbers);

            return View("Lookup", result);
        }

        public ActionResult Search(string search)
        {
            if (String.IsNullOrEmpty(search))
            {
                return View();
            }

            ViewBag.Search = search.Trim();

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US);
            var responseGroup = AmazonResponseGroup.ItemAttributes | AmazonResponseGroup.Images;

            var result = wrapper.Search(search.Trim(), AmazonSearchIndex.All, responseGroup);

            return View(result);
        }

        public ActionResult Detail(string articleNumber)
        {
            if (String.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US);
            var result = wrapper.Lookup(articleNumber.Trim());

            var item = result.Items?.Item.FirstOrDefault();

            return View(item);
        }
    }
}