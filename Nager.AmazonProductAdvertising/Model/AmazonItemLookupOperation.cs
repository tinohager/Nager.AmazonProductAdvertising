using Nager.ArticleNumber;
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
            var idType = "ASIN";
            switch (articelNumberType)
            {
                case ArticleNumberType.EAN8:
                case ArticleNumberType.EAN13:
                case ArticleNumberType.UPC:
                case ArticleNumberType.GTIN:
                case ArticleNumberType.SKU:
                    idType = "EAN";
                    base.SearchIndex(AmazonSearchIndex.All);
                    break;
                case ArticleNumberType.ISBN10:
                case ArticleNumberType.ISBN13:
                    idType = "ISBN";
                    base.SearchIndex(AmazonSearchIndex.Books);
                    for (var i = 0; i< articelNumbers.Count; i++)
                    {
                        articelNumbers[i] = articelNumbers[i].Replace("-", "");
                    }
                    break;
                case ArticleNumberType.ASIN:
                    break;
            }

            if (base.ParameterDictionary.ContainsKey("ItemId"))
            {
                base.ParameterDictionary["ItemId"] = String.Join(",", articelNumbers);
                return;
            }

            base.ParameterDictionary.Add("IdType", idType);
            base.ParameterDictionary.Add("ItemId", String.Join(",", articelNumbers));
        }
    }
}