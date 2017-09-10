using System.Net;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class Item
    {
        private string _detailPageURL;

        public string ASIN { get; set; }
        public string ParentASIN { get; set; }
        public string DetailPageURL
        {
            get { return this._detailPageURL; }
            set { this._detailPageURL = WebUtility.UrlDecode(value); }
        }
        [XmlArrayItem("ItemLink")]
        public ItemLink[] ItemLinks { get; set; }
        public string SalesRank { get; set; }
        public Image SmallImage { get; set; }
        public Image MediumImage { get; set; }
        public Image LargeImage { get; set; }
        public ImageSet[] ImageSets { get; set; }
        public ItemAttributes ItemAttributes { get; set; }
        public OfferSummary OfferSummary { get; set; }
        public Offers Offers { get; set; }
        public CustomerReviews CustomerReviews { get; set; }
        public EditorialReview[] EditorialReviews { get; set; }
        public VariationSummary VariationSummary { get; set; }
        [XmlArrayItem("SimilarProduct", IsNullable = false)]
        public SimilarProductsSimilarProduct[] SimilarProducts { get; set; }

        [XmlArrayItem("BrowseNode", IsNullable = false)]
        public BrowseNode[] BrowseNodes { get; set; }
        public Variations Variations { get; set; }

        public override string ToString()
        {
            if (this.ItemAttributes != null)
            {
                return this.ItemAttributes.Title;
            }

            return base.ToString();
        }
    }
}
