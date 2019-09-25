using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Nager.AmazonProductAdvertising.Website.Controllers
{
    public class AmazonController : Controller
    {
        private readonly string _associateTag;
        private readonly AmazonEndpoint _amazonEndpoint;

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

        public async Task<ActionResult> Lookup(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return View();
            }

            var authentication = this.GetConfig();

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._associateTag);
            var result = await client.GetItemsAsync(articleNumber.Trim());

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

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._associateTag);
            var result = await client.SearchItemsAsync(search.Trim());

            return View(result);
        }

        public async Task<ActionResult> Detail(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return RedirectPermanent("/");
            }

            var authentication = this.GetConfig();

            var client = new AmazonProductAdvertisingClient(authentication, this._amazonEndpoint, this._associateTag);
            var result = await client.GetItemsAsync(articleNumber.Trim());

            return View(result.ItemsResult.Items.FirstOrDefault());
        }
    }
}