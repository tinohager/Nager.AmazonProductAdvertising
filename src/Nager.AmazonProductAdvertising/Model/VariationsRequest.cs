namespace Nager.AmazonProductAdvertising.Model
{
    public class VariationsRequest
    {
        public string Asin { get; set; }
        public string[] Resources { get; set; }
        public Merchant? Merchant { get; set; }
    }
}
