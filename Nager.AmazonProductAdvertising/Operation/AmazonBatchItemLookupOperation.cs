using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nager.AmazonProductAdvertising.Model;
using Nager.ArticleNumber;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonBatchItemLookupOperation : AmazonOperationBase
    {
        public AmazonBatchItemLookupOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemLookup");
            base.ParameterDictionary.Add("ItemLookup.Shared.ResponseGroup", AmazonResponseGroup.Large.ToString());
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
                    for (var i = 0; i < articleNumbers.Count; i++)
                    {
                        articleNumbers[i] = articleNumbers[i].Replace("-", "");
                    }
                    break;
                case ArticleNumberType.ASIN:
                    break;
            }
            var split = articleNumbers.Split(10);
            var batchNumber = 1;
            foreach(var batch in split)
            {
                base.ParameterDictionary.Add("ItemLookup."+batchNumber+".ItemId", String.Join(",", batch));
                batchNumber++;
            }

            base.ParameterDictionary.Add("ItemLookup.Shared.IdType", idType);
        }
    }
}
