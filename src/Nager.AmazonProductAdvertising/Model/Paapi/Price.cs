namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class Price
    {
        public double Amount { get; set; }
        public string Currency { get; set; }
        public string DisplayAmount { get; set; }
        public double? PricePerUnit { get; set; }
        public Savings Savings { get; set; }
    }
}
