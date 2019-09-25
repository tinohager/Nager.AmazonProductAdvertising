namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class Item
    {
        public string ASIN { get; set; }
        public string ParentASIN { get; set; }
        public string DetailPageURL { get; set; }
        public ItemInfo ItemInfo { get; set; }
        public Images Images { get; set; }
        public Offers Offers { get; set; }
        public VariationAttribute[] VariationAttributes { get; set; }
        public BrowseNodeInfo BrowseNodeInfo { get; set; }
    }
}
