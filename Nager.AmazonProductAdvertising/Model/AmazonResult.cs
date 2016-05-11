using System.Web;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    #region Common

    public class AmazonResponse
    {
        public OperationRequest OperationRequest { get; set; }
    }

    public class AmazonErrorResponse
    {
        public AmazonError Error { get; set; }
        public string RequestId { get; set; }
    }

    public class AmazonError
    {
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public class ArgumentsArgument
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Value { get; set; }
    }

    public class HTTPHeadersHeader
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Value { get; set; }
    }

    public class OperationRequest
    {
        public string RequestId { get; set; }
        public float RequestProcessingTime { get; set; }
        [XmlArrayItem("Header")]
        public HTTPHeadersHeader[] HTTPHeaders { get; set; }
        [XmlArrayItem("Argument")]
        public ArgumentsArgument[] Arguments { get; set; }
        [XmlArrayItem("Error")]
        public AmazonError[] Errors { get; set; }
    }

    public class Request
    {
        public string IsValid { get; set; }
        [XmlArrayItem("Error")]
        public AmazonError[] Errors { get; set; }
    }

    #endregion

    #region ItemLookup / Item Search

    public class AmazonItemResponse : AmazonResponse
    {
        public Items Items { get; set; }
    }

    [XmlRoot]
    public class ItemLookupResponse : AmazonItemResponse
    { }

    [XmlRoot]
    public class ItemSearchResponse : AmazonItemResponse
    { }

    [XmlRoot]
    public class ItemLookupErrorResponse : AmazonErrorResponse
    { }

    [XmlRoot]
    public class ItemSearchErrorResponse : AmazonErrorResponse
    { }

    public class ItemLink
    {
        private string _url;

        public string Description { get; set; }
        public string URL
        {
            get { return this._url; }
            set { this._url = HttpUtility.UrlDecode(value); }
        }

        public override string ToString()
        {
            return this.Description;
        }
    }

    public class DecimalWithUnits
    {
        [XmlAttribute]
        public string Units { get; set; }
        [XmlTextAttribute]
        public decimal Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Value, this.Units);
        }
    }

    public class Image
    {
        public string URL { get; set; }
        public DecimalWithUnits Height { get; set; }
        public DecimalWithUnits Width { get; set; }
        public string IsVerified { get; set; }

        public override string ToString()
        {
            return this.URL;
        }
    }

    public class ImageSet
    {
        public Image SwatchImage { get; set; }
        public Image SmallImage { get; set; }
        public Image ThumbnailImage { get; set; }
        public Image TinyImage { get; set; }
        public Image MediumImage { get; set; }
        public Image LargeImage { get; set; }
        [XmlAttribute]
        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("Category:{0}", this.Category);
        }
    }

    public class CorrectedQuery
    {
        public string Keywords { get; set; }
        public string Message { get; set; }
    }

    public class SearchResultsMapSearchIndex
    {
        public string IndexName { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Results { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Pages { get; set; }
        [XmlElement(Order = 3)]
        public CorrectedQuery CorrectedQuery { get; set; }
        [XmlElement(DataType = "positiveInteger")]
        public string RelevanceRank { get; set; }
        public string[] ASIN { get; set; }
    }

    public class Items
    {
        public CorrectedQuery CorrectedQuery { get; set; }
        public string Qid { get; set; }
        public string EngineQuery { get; set; }
        public string TotalResults { get; set; }
        public string TotalPages { get; set; }
        public string MoreSearchResultsUrl { get; set; }
        [XmlElement(IsNullable=true)]
        public Request Request { get; set; }
        [XmlElement("Item")]
        public Item[] Item { get; set; }
    }

    public class Price
    {
        [XmlElement(DataType = "integer")]
        public string Amount { get; set; }
        public string CurrencyCode { get; set; }
        public string FormattedPrice { get; set; }
    }

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

    public class NonNegativeIntegerWithUnits
    {
        public string Units { get; set; }
        [XmlTextAttribute(DataType = "nonNegativeInteger")]
        public string Value { get; set; }
    }

    public class Merchant
    {
        public string Name { get; set; }
    }

    public class OfferAttributes
    {
        public string Condition { get; set; }
    }

    public class OfferListing
    {
        public string OfferListingId { get; set; }
        public Price Price { get; set; }
        public Price SalePrice { get; set; }
        public Price AmountSaved { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string PercentageSaved { get; set; }
        public string Availability { get; set; }
        //public OfferListingAvailabilityAttributes AvailabilityAttributes { get; set; }
        public bool IsEligibleForSuperSaverShipping { get; set; }
        public bool IsEligibleForPrime { get; set; }
    }

    public class LoyaltyPoints
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Points { get; set; }
        public Price TypicalRedemptionValue { get; set; }
    }

    public class Promotion
    {
        public PromotionSummary Summary { get; set; }
    }

    public class PromotionSummary
    {
        public string PromotionId { get; set; }
        public string Category { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string EligibilityRequirementDescription { get; set; }
        public string BenefitDescription { get; set; }
        public string TermsAndConditions { get; set; }
    }

    public class Offer
    {
        public Merchant Merchant { get; set; }
        public OfferAttributes OfferAttributes { get; set; }
        [XmlElement("OfferListing")]
        public OfferListing[] OfferListing { get; set; }
        public LoyaltyPoints LoyaltyPoints { get; set; }
        public Promotion[] Promotions { get; set; }
    }

    public class Offers
    {
        [XmlElement(DataType = "nonNegativeInteger")]
        public string TotalOffers { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string TotalOfferPages { get; set; }
        public string MoreOffersUrl { get; set; }
        [XmlElement("Offer")]
        public Offer[] Offer { get; set; }
    }

    public class EditorialReview
    {
        public string Source { get; set; }
        public string Content { get; set; }
        public bool IsLinkSuppressed { get; set; }
    }

    public class VariationSummary
    {
        public Price HighestPrice { get; set; }
        public Price LowestSalePrice { get; set; }
        public Price HighestSalePrice { get; set; }
    }

    public class SimilarProductsSimilarProduct
    {
        public string ASIN { get; set; }
        public string Title { get; set; }
    }

    public class CustomerReviews
    {
        public string IFrameURL { get; set; }
        public bool HasReviews { get; set; }
    }

    public class ItemAttributesItemDimensions
    {
        public DecimalWithUnits Height { get; set; }
        public DecimalWithUnits Length { get; set; }
        public DecimalWithUnits Weight { get; set; }
        public DecimalWithUnits Width { get; set; }
    }

    public class ItemAttributesPackageDimensions
    {
        public DecimalWithUnits Height { get; set; }
        public DecimalWithUnits Length { get; set; }
        public DecimalWithUnits Weight { get; set; }
        public DecimalWithUnits Width { get; set; }
    }

    public class ItemAttributesLanguage
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string AudioFormat { get; set; }
    }

    public class ItemAttributesCreator
    {
        public string Role { get; set; }
        public string Value { get; set; }
    }

    public class ItemAttributes
    {
        public string[] Actor { get; set; }
        public string[] Artist { get; set; }
        public string AspectRatio { get; set; }
        public string AudienceRating { get; set; }
        public string[] AudioFormat { get; set; }
        [XmlElement("Author")]
        public string[] Author { get; set; }
        public string Binding { get; set; }
        public string Brand { get; set; }
        [XmlArrayItem("CatalogNumberListElement", IsNullable = false)]
        public string[] CatalogNumberList { get; set; }
        public string[] Category { get; set; }
        public string CEROAgeRating { get; set; }
        public string ClothingSize { get; set; }
        public string Color { get; set; }
        public ItemAttributesCreator[] Creator { get; set; }
        public string Department { get; set; }
        public string[] Director { get; set; }
        public string EAN { get; set; }
        [XmlArrayItem("EANListElement", IsNullable = false)]
        public string[] EANList { get; set; }
        public string Edition { get; set; }
        public string[] EISBN { get; set; }
        public string EpisodeSequence { get; set; }
        public string ESRBAgeRating { get; set; }
        [XmlElement("Feature")]
        public string[] Feature { get; set; }
        public string[] Format { get; set; }
        public string Genre { get; set; }
        public string HardwarePlatform { get; set; }
        public string HazardousMaterialType { get; set; }
        public bool IsAdultProduct { get; set; }
        public bool IsAutographed { get; set; }
        public string ISBN { get; set; }
        public bool IsEligibleForTradeIn { get; set; }
        public bool IsMemorabilia { get; set; }
        public string IssuesPerYear { get; set; }
        public ItemAttributesItemDimensions ItemDimensions { get; set; }
        public string ItemPartNumber { get; set; }
        public string Label { get; set; }
        public ItemAttributesLanguage[] Languages { get; set; }
        public string LegalDisclaimer { get; set; }
        public Price ListPrice { get; set; }
        public string MagazineType { get; set; }
        public string Manufacturer { get; set; }
        public DecimalWithUnits ManufacturerMaximumAge { get; set; }
        public DecimalWithUnits ManufacturerMinimumAge { get; set; }
        public string ManufacturerPartsWarrantyDescription { get; set; }
        public string MediaType { get; set; }
        public string Model { get; set; }
        public string ModelYear { get; set; }
        public string MPN { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumberOfDiscs { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumberOfIssues { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumberOfItems { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumberOfPages { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string NumberOfTracks { get; set; }
        public string OperatingSystem { get; set; }
        public ItemAttributesPackageDimensions PackageDimensions { get; set; }
        public string PackageQuantity { get; set; }
        public string PartNumber { get; set; }
        public string[] PictureFormat { get; set; }
        [XmlElement("Platform")]
        public string[] Platform { get; set; }
        public string ProductGroup { get; set; }
        public string ProductTypeName { get; set; }
        public string ProductTypeSubcategory { get; set; }
        public string PublicationDate { get; set; }
        public string Publisher { get; set; }
        public string RegionCode { get; set; }
        public string ReleaseDate { get; set; }
        public DecimalWithUnits RunningTime { get; set; }
        public string SeikodoProductCode { get; set; }
        public string Size { get; set; }
        public string SKU { get; set; }
        public string Studio { get; set; }
        public NonNegativeIntegerWithUnits SubscriptionLength { get; set; }
        public string Title { get; set; }
        public string TrackSequence { get; set; }
        public Price TradeInValue { get; set; }
        public string UPC { get; set; }
        [XmlArrayItem("UPCListElement", IsNullable = false)]
        public string[] UPCList { get; set; }
        public string Warranty { get; set; }
        public Price WEEETaxValue { get; set; }
    }

    public class Item
    {
        private string _detailPageURL;

        public string ASIN { get; set; }
        public string ParentASIN  { get; set; }
        public string DetailPageURL
        {
            get { return this._detailPageURL; }
            set { this._detailPageURL = HttpUtility.UrlDecode(value); }
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

        public override string ToString()
        {
            if (this.ItemAttributes != null)
            {
                return this.ItemAttributes.Title;
            }

            return base.ToString();
        }
    }

    #endregion

    #region BrowseNodeLookupResponse

    [XmlRoot]
    public class BrowseNodeLookupResponse : AmazonResponse
    {
        public BrowseNodes BrowseNodes { get; set; }
    }

    [XmlRoot]
    public class BrowseNodeLookupErrorResponse : AmazonErrorResponse
    { }

    [XmlRoot]
    public class BrowseNodes
    {
        public BaseBrowseNodeLookupRequest Request { get; set; }
        public BrowseNode BrowseNode { get; set; }
    }

    public class BaseBrowseNodeLookupRequest : Request
    {
        public BrowseNodeLookupRequest BrowseNodeLookupRequest { get; set; }
    }

    [XmlRoot]
    public class BrowseNodeLookupRequest
    {
        public string BrowseNodeId { get; set; }
        public string ResponseGroup { get; set; }
    }

    [XmlRoot]
    public class BrowseNode
    {
        public string BrowseNodeId { get; set; }
        public string Name { get; set; }
        public int IsCategoryRoot { get; set; }
        [XmlArrayItem("BrowseNode")]
        public BrowseNode[] Children { get; set; }
    }

    [XmlRoot]
    public class Ancestors
    {
        public BrowseNode BrowseNode { get; set; }
    }

    #endregion
}