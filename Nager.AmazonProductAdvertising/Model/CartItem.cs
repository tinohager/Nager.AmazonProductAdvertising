namespace Nager.AmazonProductAdvertising.Model
{
    public class CartItem
    {
        public string CartItemId { get; set; }
        public string ASIN { get; set; }
        public string SellerNickname { get; set; }
        public int Quantity { get; set; }
        public string Title { get; set; }
        public string ProductGroup { get; set; }
        public Price Price { get; set; }
        public Price ItemTotal { get; set; }
    }
}
