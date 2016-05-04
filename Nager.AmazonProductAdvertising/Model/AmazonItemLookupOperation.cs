using Nager.AmazonProductAdvertising.Helper;
using System;
using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonItemLookupOperation : AmazonOperationBase
    {
        public AmazonItemLookupOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemLookup");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.Large.ToString());
        }

        public void Get(IList<string> articelNumbers)
        {
            if (articelNumbers.Count == 0)
            {
                return;
            }

            var articelNumberType = ArticleNumberHelper.GetArticleNumberType(articelNumbers[0]);
            switch (articelNumberType)
            {
                case ArticleNumberType.EAN:
                case ArticleNumberType.SKU:
                case ArticleNumberType.UPC:
                    base.SearchIndex(AmazonSearchIndex.All);
                    break;
                case ArticleNumberType.ISBN:
                    base.SearchIndex(AmazonSearchIndex.Books);
                    for (var i = 0; i< articelNumbers.Count; i++)
                    {
                        articelNumbers[i] = articelNumbers[i].Replace("-", "");
                    }
                    break;
            }

            if (articelNumberType != ArticleNumberType.EAN)
            {
                base.SearchIndex(AmazonSearchIndex.Books);
            }

            if (base.ParameterDictionary.ContainsKey("ItemId"))
            {
                base.ParameterDictionary["ItemId"] = String.Join(",", articelNumbers);
                return;
            }

            base.ParameterDictionary.Add("IdType", articelNumberType.ToString());
            base.ParameterDictionary.Add("ItemId", String.Join(",", articelNumbers));
        }
    }
}