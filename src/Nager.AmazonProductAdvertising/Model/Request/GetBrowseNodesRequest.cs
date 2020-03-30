namespace Nager.AmazonProductAdvertising.Model.Request
{
    public class GetBrowseNodesRequest : AmazonRequest
    {
        public string[] BrowseNodeIds { get; set; }
        public string[] LanguagesOfPreference { get; set; }
    }
}