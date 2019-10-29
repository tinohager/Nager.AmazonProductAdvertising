namespace Nager.AmazonProductAdvertising.Model
{
    public class ItemsRequest
    {
        public string[] ItemIds { get; set; }
        public string[] Resources { get; set; }
        public Merchant? Merchant { get; set; }
    }
}
