namespace Nager.AmazonProductAdvertising.Model
{
    public class SearchRequest
    {
        public string Keywords { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public int? ItemPage { get; set; }
        public SortBy? SortBy { get; set; }
        public string BrowseNodeId { get; set; }
        public string[] Resources { get; set; }
        public Merchant? Merchant { get; set; }
        public SearchIndex? SearchIndex { get; set; }
        public Condition? Condition { get; set; }
    }
}
