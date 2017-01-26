namespace Nager.AmazonProductAdvertising.Model
{
    public class OfferSummary
    {
        public Price LowestNewPrice { get; set; }
        public Price LowestUsedPrice { get; set; }
        public Price LowestCollectiblePrice { get; set; }
        public Price LowestRefurbishedPrice { get; set; }
        public string TotalNew { get; set; }
        public string TotalUsed { get; set; }
        public string TotalCollectible { get; set; }
        public string TotalRefurbished { get; set; }
    }
}
