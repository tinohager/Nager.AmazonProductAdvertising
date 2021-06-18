namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class SearchRefinements
    {
        public SearchRefinement SearchIndex { get; set; }
        public BrowseNode BrowseNode { get; set; }

        public SearchRefinement[] OtherRefinements { get; set; }
    }
}
