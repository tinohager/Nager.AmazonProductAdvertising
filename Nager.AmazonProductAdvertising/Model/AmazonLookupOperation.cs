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
    }
}