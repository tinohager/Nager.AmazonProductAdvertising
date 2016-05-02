using System;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonItemSearchOperation : AmazonOperationBase
    {
        public AmazonItemSearchOperation()
        {
            base.ParameterDictionary.Add("Operation", "ItemSearch");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.Large.ToString());
        }

        public void Keywords(string keywords)
        {
            if (base.ParameterDictionary.ContainsKey("Keywords"))
            {
                base.ParameterDictionary["Keywords"] = keywords;
                return;
            }

            base.ParameterDictionary.Add("Keywords", keywords);
        }

        public void SearchIndex(AmazonSearchIndex searchIndex)
        {
            if (base.ParameterDictionary.ContainsKey("SearchIndex"))
            {
                base.ParameterDictionary["SearchIndex"] = searchIndex.ToString();
                return;
            }

            base.ParameterDictionary.Add("SearchIndex", searchIndex.ToString());
        }

        public void Skip(int value)
        {
            //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/MaximumNumberofPages.html

            if (value > 10)
            {
                throw new ArgumentOutOfRangeException("value", "value must be between 1 and 5");
            }

            if (base.ParameterDictionary.ContainsKey("ItemPage"))
            {
                base.ParameterDictionary["ItemPage"] = value.ToString();
                return;
            }

            base.ParameterDictionary.Add("ItemPage", value.ToString());
        }

        public void Sort(AmazonSearchSort amazonSearchSort, AmazonSearchSortOrder amazonSearchSortOrder)
        {
            var order = String.Empty;
            if (amazonSearchSortOrder == AmazonSearchSortOrder.Descending)
            {
                order = "-";
            }

            var value = String.Format("{1}{0}", amazonSearchSort.ToString().ToLower(), order);

            if (base.ParameterDictionary.ContainsKey("Sort"))
            {
                base.ParameterDictionary["Sort"] = value.ToString();
                return;
            }

            base.ParameterDictionary.Add("Sort", value.ToString());
        }

        public void Available()
        {
            if (base.ParameterDictionary.ContainsKey("Availability"))
            {
                base.ParameterDictionary["Availability"] = "Available";
                return;
            }

            base.ParameterDictionary.Add("Availability", "Available");
        }
    }
}