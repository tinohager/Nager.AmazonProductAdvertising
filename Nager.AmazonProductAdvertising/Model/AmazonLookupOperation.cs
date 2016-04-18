using System;
using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonLookupOperation : AmazonOperationBase
    {
        public AmazonLookupOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemLookup");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.Large.ToString());
        }

        public void Get(string asin)
        {
            if (base.ParameterDictionary.ContainsKey("ItemId"))
            {
                base.ParameterDictionary["ItemId"] = asin;
                return;
            }

            base.ParameterDictionary.Add("ItemId", asin);
        }

        public void Get(IList<string> asins)
        {
            if (base.ParameterDictionary.ContainsKey("ItemId"))
            {
                base.ParameterDictionary["ItemId"] = String.Join(",", asins);
                return;
            }

            base.ParameterDictionary.Add("ItemId", String.Join(",", asins));
        }
    }
}