using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nager.AmazonProductAdvertising.Website.Controllers
{
    public class AmazonController : Controller
    {
        private readonly string _partnerTag;
        private readonly AmazonEndpoint _amazonEndpoint;

        public AmazonController()
        {
            var partnerTag = ConfigurationManager.AppSettings["AmazonPartnerTag"];
            var amazonEndpoint = ConfigurationManager.AppSettings["AmazonEndpoint"];

            this._partnerTag = partnerTag;
            if (Enum.TryParse(amazonEndpoint, out AmazonEndpoint endpoint))
            {
                this._amazonEndpoint = endpoint;
            }
        }

        private AmazonAuthentication GetConfig()
        {
            var accessKey = ConfigurationManager.AppSettings["AmazonAccessKey"];
            var secretKey = ConfigurationManager.AppSettings["AmazonSecretKey"];

            return new AmazonAuthentication
            {
                AccessKey = accessKey,
                SecretKey = secretKey
            };
        }

        public async Task<ActionResult> Lookup(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._partnerTag);
            var result = await client.GetItemsAsync(articleNumber.Trim());
            if (!result.Successful)
            {
                return View("Error", result);
            }

            return View(result);
        }

        public async Task<ActionResult> Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return RedirectPermanent("/");
            }

            ViewBag.Search = search.Trim();

            var authentication = this.GetConfig();

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._partnerTag);
            var result = await client.SearchItemsAsync(search.Trim());
            if (!result.Successful)
            {
                return View("Error", result);
            }

            return View(result);
        }

        public async Task<ActionResult> Detail(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return RedirectPermanent("/");
            }

            var authentication = this.GetConfig();

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._partnerTag);
            var result = await client.GetItemsAsync(articleNumber.Trim());
            if (!result.Successful)
            {
                return View("Error", result);
            }

            return View(result.ItemsResult.Items.FirstOrDefault());
        }
    }
}