namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonCartItem
    {
        public string Asin { get; set; }
        public int Quantity { get; set; }

        public AmazonCartItem()
        { }

        public AmazonCartItem(string asin, int quantity = 1)
        {
            this.Asin = asin;
            this.Quantity = quantity;
        }
    }
}
