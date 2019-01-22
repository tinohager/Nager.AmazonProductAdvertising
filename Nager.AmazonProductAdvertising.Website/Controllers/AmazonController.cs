using Nager.AmazonProductAdvertising.Model;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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

        public ActionResult Lookup(string articleNumber)
        {
            if (string.IsNullOrEmpty(articleNumber))
            {
                return RedirectPermanent("/");
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
                return RedirectPermanent("/");
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var result = wrapper.Lookup(articleNumbers);

            return View("Lookup", result);
        }

        public ActionResult LookupsJson(string[] articleNumbers)
        {
            if (articleNumbers == null)
            {
                return HttpNotFound();
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var result = wrapper.Lookup(articleNumbers, AmazonResponseGroup.Images | AmazonResponseGroup.ItemAttributes);

            var items = result?.Items?.Item;
            if (items == null)
            {
                return HttpNotFound();
            }

            var smallObjects = items.Select(o => new
            {
                Name = o.ItemAttributes?.Title,
                Image = o.MediumImage?.URL,
                Asin = o.ASIN
            }).Where(o=>!string.IsNullOrEmpty(o.Image));

            return Json(smallObjects, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                return RedirectPermanent("/");
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
                return RedirectPermanent("/");
            }

            var authentication = this.GetConfig();

            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);
            var result = wrapper.Lookup(articleNumber.Trim());

            if (result == null || result.Items == null)
            {
                return new HttpStatusCodeResult(429);
            }

            if (result.Items.Request?.Errors != null && result.Items.Request.Errors.Any())
            {
                return RedirectPermanent("/");
            }

            var item = result.Items?.Item?.FirstOrDefault();
            return View(item);
        }

        public ActionResult Cart()
        {
            var cartId = string.Empty;
            var hmac = string.Empty;

            var authentication = this.GetConfig();
            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);

            if (Session["cartId"] == null)
            {
                return View();
            }
            else
            {
                cartId = Session["cartId"] as string;
                hmac = Session["hmac"] as string;
            }

            var result = wrapper.CartGet(cartId, hmac);

            return View(result.Cart);
        }

        public ActionResult AddCart(string asin)
        {
            var cartId = string.Empty;
            var hmac = string.Empty;

            var authentication = this.GetConfig();
            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);

            AmazonCartItem item;

            if (Session["cartId"] == null)
            {
                item = new AmazonCartItem(asin);

                var cardCreateResponse = wrapper.CartCreate(new List<AmazonCartItem> { item });

                Session["cartId"] = cardCreateResponse.Cart.CartId;
                Session["hmac"] = cardCreateResponse.Cart.HMAC;

                return Json(new { Successful = true, cardCreateResponse.Cart.CartId }, JsonRequestBehavior.AllowGet);
            }

            cartId = Session["cartId"] as string;
            hmac = Session["hmac"] as string;

            item = new AmazonCartItem(asin);
            var cardAddResponse = wrapper.CartAdd(item, cartId, hmac);

            return Json(new { Successful = true, cardAddResponse.Cart.CartId }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ClearCart()
        {
            var cartId = string.Empty;
            var authentication = this.GetConfig();
            var wrapper = new AmazonWrapper(authentication, this._amazonEndpoint, this._associateTag);

            if (Session["cartId"] == null)
            {
                return Json(new { Successful = false });
            }

            cartId = Session["cartId"] as string;
            var result = wrapper.CartClear(cartId, null);
            Session["cartId"] = null;

            return Json(new { Successful = true, result.Cart.CartId });
        }
    }
}