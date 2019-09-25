namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class SearchResult
    {
        public Item[] Items { get; set; }
        public SearchRefinements SearchRefinements { get; set; }
        public string SearchURL { get; set; }
        public int TotalResultCount { get; set; }
    }
}
