using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Extension
{
    public static class OperationExtension
    {
        public static IDictionary<string, string> ItemPage(this IDictionary<string, string> source, int value)
        {
            if (value > 5)
            {
                throw new ArgumentOutOfRangeException("value", "value must be between 1 and 5");
            }

            //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/MaximumNumberofPages.html
            source.Add("ItemPage", value.ToString());
            return source;
        }

        public static IDictionary<string, string> Sort(this IDictionary<string, string> source, AmazonSearchSort amazonSearchSort, AmazonSearchSortOrder amazonSearchSortOrder)
        {
            var order = String.Empty;
            if (amazonSearchSortOrder == AmazonSearchSortOrder.Descending)
            {
                order = "-";
            }

            var value = String.Format("{1}{0}", amazonSearchSort.ToString().ToLower(), order);

            source.Add("Sort", value);
            return source;
        }

        public static IDictionary<string, string> Available(this IDictionary<string, string> source)
        {
            source.Add("Availability", "Available");
            return source;
        }
    }
}
