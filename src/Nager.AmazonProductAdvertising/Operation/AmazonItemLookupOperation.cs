using Nager.AmazonProductAdvertising.Model;
using Nager.ArticleNumber;
using System;
using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonItemLookupOperation : AmazonOperationBase
    {
        public AmazonItemLookupOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemLookup");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.Large.ToString());
        }

        public void Get(IList<string> articleNumbers)
        {
            if (articleNumbers.Count == 0)
            {
                return;
            }

            var articleNumberType = ArticleNumberHelper.GetArticleNumberType(articleNumbers[0]);
            var idType = "ASIN";
            switch (articleNumberType)
            {
                case ArticleNumberType.EAN8:
                case ArticleNumberType.EAN13:
                case ArticleNumberType.GTIN:
                case ArticleNumberType.SKU:
                    idType = "EAN";
                    base.SearchIndex(AmazonSearchIndex.All);
                    break;
                case ArticleNumberType.UPC:
                    idType = "UPC";
                    base.SearchIndex(AmazonSearchIndex.All);
                    break;
                case ArticleNumberType.ISBN10:
                case ArticleNumberType.ISBN13:
                    idType = "ISBN";
                    base.SearchIndex(AmazonSearchIndex.Books);
                    for (var i = 0; i< articleNumbers.Count; i++)
                    {
                        articleNumbers[i] = articleNumbers[i].Replace("-", "");
                    }
                    break;
                case ArticleNumberType.ASIN:
                    break;
            }

            if (base.ParameterDictionary.ContainsKey("ItemId"))
            {
                base.ParameterDictionary["ItemId"] = String.Join(",", articleNumbers);
                return;
            }

            base.ParameterDictionary.Add("IdType", idType);
            base.ParameterDictionary.Add("ItemId", String.Join(",", articleNumbers));
        }
    }
}