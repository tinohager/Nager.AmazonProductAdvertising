using Nager.AmazonProductAdvertising.Model;
using System;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonItemSearchOperation : AmazonOperationBase
    {
        public AmazonItemSearchOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemSearch");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.Large.ToString());
        }

        public AmazonItemSearchOperation Keywords(string keywords)
        {
            return this.AddOrReplace("Keywords", keywords);
        }

        public AmazonItemSearchOperation ItemPage(short ItemPage)
        {
            return this.AddOrReplace("ItemPage", ItemPage);
        }

        public AmazonItemSearchOperation Skip(int value)
        {
            //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/MaximumNumberofPages.html

            var maxItems = 10;

            if (base.ParameterDictionary.ContainsKey("SearchIndex"))
            {
                if (base.ParameterDictionary["SearchIndex"] == AmazonSearchIndex.All.ToString())
                {
                    maxItems = 5;
                }
            }

            if (value > maxItems)
            {
                throw new ArgumentOutOfRangeException("value", $"value must be between 1 and {maxItems}");
            }

            return this.AddOrReplace("ItemPage", value.ToString());
        }

        public AmazonItemSearchOperation Sort(AmazonSearchSort amazonSearchSort, AmazonSearchSortOrder amazonSearchSortOrder)
        {
            var order = string.Empty;
            if (amazonSearchSortOrder == AmazonSearchSortOrder.Descending)
            {
                order = "-";
            }
            var value = string.Format("{1}{0}", amazonSearchSort.ToString().ToLower(), order);
            return this.AddOrReplace("Sort", value.ToString());
        }

        public AmazonItemSearchOperation Available()
        {
            return this.AddOrReplace("Availability", "Available");
        }

        public AmazonItemSearchOperation Condition(ItemCondition condition)
        {
            return this.AddOrReplace("Condition", condition);
        }

        public AmazonItemSearchOperation MaxPrice(int priceInLowestCurrencyDenomination)
        {
            return this.AddOrReplace("MaximumPrice", priceInLowestCurrencyDenomination);
        }

        public AmazonItemSearchOperation MinPrice(int priceInLowestCurrencyDenomination)
        {
            return this.AddOrReplace("MinimumPrice", priceInLowestCurrencyDenomination);
        }

        public AmazonItemSearchOperation PriceBetween(int maxPriceInLowestCurrencyDenomination, int minPriceInLowestCurrencyDenomination)
        {
            return this.MaxPrice(maxPriceInLowestCurrencyDenomination)
                       .MinPrice(minPriceInLowestCurrencyDenomination);
        }

        private new AmazonItemSearchOperation AddOrReplace(string param, object value)
        {
            base.AddOrReplace(param, value);
            return this;
        }
    }
}
