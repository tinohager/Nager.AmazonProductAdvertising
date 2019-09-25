using System.Collections.Generic;
using System.Linq;

namespace Nager.AmazonProductAdvertising
{
    /// <summary>
    /// Amazon Resource Validator
    /// </summary>
    public class AmazonResourceValidator
    {
        private readonly Dictionary<string, string[]> _resources;

        /// <summary>
        /// Amazon Resource Validator
        /// </summary>
        public AmazonResourceValidator()
        {
            this._resources = new Dictionary<string, string[]>
            {
                { "BrowseNodes.Ancestor", new [] { "GetBrowseNodes" } },
                { "BrowseNodes.Children", new [] { "GetBrowseNodes" } },
                { "BrowseNodeInfo.BrowseNodes", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "BrowseNodeInfo.BrowseNodes.Ancestor", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "BrowseNodeInfo.BrowseNodes.SalesRank", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "BrowseNodeInfo.WebsiteSalesRank", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "CustomerReviews.Count", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "CustomerReviews.StarRating", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Primary.Small", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Primary.Medium", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Primary.Large", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Variants.Small", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Variants.Medium", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Images.Variants.Large", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.ByLineInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.ContentInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.ContentRating", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.Classifications", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.ExternalIds", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.Features", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.ManufacturerInfo", new [] { "SearchItems", "GetItems", "GetVariations" } }, //<-- Error
                { "ItemInfo.ProductInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.TechnicalInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.Title", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ItemInfo.TradeInInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Availability.MaxOrderQuantity", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Availability.Message", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Availability.MinOrderQuantity", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Availability.Type", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Condition", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Condition.SubCondition", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.DeliveryInfo.IsAmazonFulfilled", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.DeliveryInfo.IsFreeShippingEligible", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.DeliveryInfo.IsPrimeEligible", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.DeliveryInfo.ShippingCharges", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.IsBoxBoxWinner", new [] { "SearchItems", "GetItems", "GetVariations" } }, //<-- Error
                { "Offers.Listings.LoyaltyPoints.Points", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.MerchantInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Price", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.ProgramEligibility.IsPrimeExclusive", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.ProgramEligibility.IsPrimePantry", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.Promotions", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Listings.SavingBasis", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Summaries.HighestPrice", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Summaries.LowestPrice", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "Offers.Summaries.OfferCount", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "ParentASIN", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Availability.MaxOrderQuantity", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Availability.Message", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Availability.MinOrderQuantity", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Availability.Type", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.BasePrice", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Condition", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.Condition.SubCondition", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.DeliveryInfo.IsAmazonFulfilled", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.DeliveryInfo.IsFreeShippingEligible", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.DeliveryInfo.IsPrimeEligible", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.DeliveryInfo.ShippingCharges", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "RentalOffers.Listings.MerchantInfo", new [] { "SearchItems", "GetItems", "GetVariations" } },
                { "SearchRefinements", new [] { "SearchItems" } },
                { "VariationSummary.Price.HighestPrice", new [] { "GetVariations" } },
                { "VariationSummary.Price.LowestPrice", new [] { "GetVariations" } },
                { "VariationSummary.VariationDimension", new [] { "GetVariations" } },
            };
        }

        /// <summary>
        /// Check resources are valid for operation
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public bool IsResourcesValid(string[] resources, string operation)
        {
            var items = this._resources.Count(resource => 
                resources.Any(x => resource.Key.Equals(x, System.StringComparison.OrdinalIgnoreCase) && 
                resource.Value.Any(y => y.Equals(operation, System.StringComparison.OrdinalIgnoreCase)))
            );

            return items == resources.Length;
        }
    }
}
