using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonCartCreateOperation : AmazonOperationBase
    {
        public AmazonCartCreateOperation()
        {
            base.ParameterDictionary.Add("Operation", "CartCreate");
        }

        public void AddArticles(IList<AmazonCartItem> amazonCartItems)
        {
            var i = 0;
            foreach (var item in amazonCartItems)
            {
                base.ParameterDictionary.Add($"Item.{i}.ASIN", item.Asin);
                base.ParameterDictionary.Add($"Item.{i}.Quantity", item.Quantity.ToString());
                i++;
            }
        }
    }
}
