using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonSimpleItem
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public string[] Description { get; set; }
        public Item SourceItem { get; set; }

        public AmazonSimpleItem(Item item)
        {
            this.SourceItem = item;
            this.Name = item.ItemAttributes.Title;
            if (item.LargeImage != null)
            {
                this.ImageUrl = item.LargeImage.URL;
            }
            this.Description = item.ItemAttributes.Feature;

            if (item.Offers != null)
            {
                if (item.Offers.Offer != null && item.Offers.Offer.Length > 0)
                {
                    if (item.Offers.Offer[0].OfferListing != null && item.Offers.Offer[0].OfferListing.Length > 0)
                    {
                        double price;
                        var amount = item.Offers.Offer[0].OfferListing[0].Price.Amount;
                        if (double.TryParse(amount, out price))
                        {
                            this.Price = price / 100;
                        }
                    }
                }
            }
        }
    }
}
