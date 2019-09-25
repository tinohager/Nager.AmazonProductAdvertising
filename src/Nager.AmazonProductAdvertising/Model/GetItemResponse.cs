using Nager.AmazonProductAdvertising.Model.Paapi;

namespace Nager.AmazonProductAdvertising.Model
{
    public class GetItemsResponse : AmazonResponse
    {
        public ItemsResult ItemsResult { get; set; }
    }
}
