namespace Nager.AmazonProductAdvertising.Model
{
    public class Cart
    {
        public Request Request { get; set; }
        public string CartId { get; set; }
        public string PurchaseURL { get; set; }
        public string HMAC { get; set; }
        public string URLEncodedHMAC { get; set; }
        public Price SubTotal { get; set; }
        public CartItems CartItems { get; set; }
    }
}
