using Nager.AmazonProductAdvertising.Model;
using System.Configuration;
using System.Linq;
using System.Web.Mvc;

namespace Nager.AmazonProductAdvertising.Website.Controllers
{
    public class AmazonController : Controller
    {
        private string _associateTag;
        private AmazonEndpoint _amazonEndpoint;

        public AmazonController()
        {
            this._associateTag = "nagerat-21";
            this._amazonEndpoint = AmazonEndpoint.DE;
        }

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
            if (string.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
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

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var result = wrapper.Lookup(articleNumbers);

            return View("Lookup", result);
        }

        public ActionResult Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return View();
            }

            ViewBag.Search = search.Trim();

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var responseGroup = AmazonResponseGroup.ItemAttributes | AmazonResponseGroup.Images | AmazonResponseGroup.OfferSummary;

            var result = wrapper.Search(search.Trim(), AmazonSearchIndex.All, responseGroup);

            return View(result);
        }

        public ActionResult Detail(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var result = wrapper.Lookup(articleNumber.Trim());

            if (result == null)
            {
                return null;
            }

            var item = result.Items?.Item?.FirstOrDefault();
            return View(item);
        }
    }
}