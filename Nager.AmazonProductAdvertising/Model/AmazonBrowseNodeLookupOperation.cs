namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonBrowseNodeLookupOperation : AmazonOperationBase
    {
        public AmazonBrowseNodeLookupOperation()
        {
            base.ParameterDictionary.Add("Operation", "BrowseNodeLookup");
            base.ParameterDictionary.Add("ResponseGroup", AmazonResponseGroup.BrowseNodeInfo.ToString());
        }

        public void BrowseNodeId(long browseNodeId)
        {
            if (base.ParameterDictionary.ContainsKey("BrowseNodeId"))
            {
                base.ParameterDictionary["BrowseNodeId"] = browseNodeId.ToString();
                return;
            }

            base.ParameterDictionary.Add("BrowseNodeId", browseNodeId.ToString());
        }
    }
}