/*
 * AUTO GENERATED
 * Visual Studio -> EDIT ->  Paste Special -> Paste XML As Classes
 */

namespace Nager.AmazonProductAdvertising.Model
{

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01", IsNullable = false)]
    public partial class ItemSearchResponse
    {

        private ItemSearchResponseOperationRequest operationRequestField;

        private ItemSearchResponseItems itemsField;

        /// <remarks/>
        public ItemSearchResponseOperationRequest OperationRequest
        {
            get
            {
                return this.operationRequestField;
            }
            set
            {
                this.operationRequestField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItems Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseOperationRequest
    {

        private string requestIdField;

        private ItemSearchResponseOperationRequestArgument[] argumentsField;

        private decimal requestProcessingTimeField;

        /// <remarks/>
        public string RequestId
        {
            get
            {
                return this.requestIdField;
            }
            set
            {
                this.requestIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Argument", IsNullable = false)]
        public ItemSearchResponseOperationRequestArgument[] Arguments
        {
            get
            {
                return this.argumentsField;
            }
            set
            {
                this.argumentsField = value;
            }
        }

        /// <remarks/>
        public decimal RequestProcessingTime
        {
            get
            {
                return this.requestProcessingTimeField;
            }
            set
            {
                this.requestProcessingTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseOperationRequestArgument
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItems
    {

        private ItemSearchResponseItemsRequest requestField;

        private long totalResultsField;

        private long totalPagesField;

        private string moreSearchResultsUrlField;

        private ItemSearchResponseItemsItem[] itemField;

        /// <remarks/>
        public ItemSearchResponseItemsRequest Request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        public long TotalResults
        {
            get
            {
                return this.totalResultsField;
            }
            set
            {
                this.totalResultsField = value;
            }
        }

        /// <remarks/>
        public long TotalPages
        {
            get
            {
                return this.totalPagesField;
            }
            set
            {
                this.totalPagesField = value;
            }
        }

        /// <remarks/>
        public string MoreSearchResultsUrl
        {
            get
            {
                return this.moreSearchResultsUrlField;
            }
            set
            {
                this.moreSearchResultsUrlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Item")]
        public ItemSearchResponseItemsItem[] Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsRequest
    {

        private string isValidField;

        private ItemSearchResponseItemsRequestItemSearchRequest itemSearchRequestField;

        /// <remarks/>
        public string IsValid
        {
            get
            {
                return this.isValidField;
            }
            set
            {
                this.isValidField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsRequestItemSearchRequest ItemSearchRequest
        {
            get
            {
                return this.itemSearchRequestField;
            }
            set
            {
                this.itemSearchRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsRequestItemSearchRequest
    {

        private string availabilityField;

        private string keywordsField;

        private string responseGroupField;

        private string searchIndexField;

        /// <remarks/>
        public string Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }

        /// <remarks/>
        public string Keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        public string ResponseGroup
        {
            get
            {
                return this.responseGroupField;
            }
            set
            {
                this.responseGroupField = value;
            }
        }

        /// <remarks/>
        public string SearchIndex
        {
            get
            {
                return this.searchIndexField;
            }
            set
            {
                this.searchIndexField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItem
    {

        private string aSINField;

        private string parentASINField;

        private string detailPageURLField;

        private ItemSearchResponseItemsItemItemLink[] itemLinksField;

        private long salesRankField;

        private ItemSearchResponseItemsItemSmallImage smallImageField;

        private ItemSearchResponseItemsItemMediumImage mediumImageField;

        private ItemSearchResponseItemsItemLargeImage largeImageField;

        private ItemSearchResponseItemsItemImageSet[] imageSetsField;

        private ItemSearchResponseItemsItemItemAttributes itemAttributesField;

        private ItemSearchResponseItemsItemOfferSummary offerSummaryField;

        private ItemSearchResponseItemsItemOffers offersField;

        private ItemSearchResponseItemsItemCustomerReviews customerReviewsField;

        private ItemSearchResponseItemsItemEditorialReviews editorialReviewsField;

        private ItemSearchResponseItemsItemSimilarProduct[] similarProductsField;

        private ItemSearchResponseItemsItemBrowseNode[] browseNodesField;

        /// <remarks/>
        public string ASIN
        {
            get
            {
                return this.aSINField;
            }
            set
            {
                this.aSINField = value;
            }
        }

        /// <remarks/>
        public string ParentASIN
        {
            get
            {
                return this.parentASINField;
            }
            set
            {
                this.parentASINField = value;
            }
        }

        /// <remarks/>
        public string DetailPageURL
        {
            get
            {
                return this.detailPageURLField;
            }
            set
            {
                this.detailPageURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ItemLink", IsNullable = false)]
        public ItemSearchResponseItemsItemItemLink[] ItemLinks
        {
            get
            {
                return this.itemLinksField;
            }
            set
            {
                this.itemLinksField = value;
            }
        }

        /// <remarks/>
        public long SalesRank
        {
            get
            {
                return this.salesRankField;
            }
            set
            {
                this.salesRankField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemSmallImage SmallImage
        {
            get
            {
                return this.smallImageField;
            }
            set
            {
                this.smallImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemMediumImage MediumImage
        {
            get
            {
                return this.mediumImageField;
            }
            set
            {
                this.mediumImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemLargeImage LargeImage
        {
            get
            {
                return this.largeImageField;
            }
            set
            {
                this.largeImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ImageSet", IsNullable = false)]
        public ItemSearchResponseItemsItemImageSet[] ImageSets
        {
            get
            {
                return this.imageSetsField;
            }
            set
            {
                this.imageSetsField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributes ItemAttributes
        {
            get
            {
                return this.itemAttributesField;
            }
            set
            {
                this.itemAttributesField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOfferSummary OfferSummary
        {
            get
            {
                return this.offerSummaryField;
            }
            set
            {
                this.offerSummaryField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffers Offers
        {
            get
            {
                return this.offersField;
            }
            set
            {
                this.offersField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemCustomerReviews CustomerReviews
        {
            get
            {
                return this.customerReviewsField;
            }
            set
            {
                this.customerReviewsField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemEditorialReviews EditorialReviews
        {
            get
            {
                return this.editorialReviewsField;
            }
            set
            {
                this.editorialReviewsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SimilarProduct", IsNullable = false)]
        public ItemSearchResponseItemsItemSimilarProduct[] SimilarProducts
        {
            get
            {
                return this.similarProductsField;
            }
            set
            {
                this.similarProductsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BrowseNode", IsNullable = false)]
        public ItemSearchResponseItemsItemBrowseNode[] BrowseNodes
        {
            get
            {
                return this.browseNodesField;
            }
            set
            {
                this.browseNodesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemLink
    {

        private string descriptionField;

        private string uRLField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemSmallImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemSmallImageHeight heightField;

        private ItemSearchResponseItemsItemSmallImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemSmallImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemSmallImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemSmallImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemSmallImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemMediumImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemMediumImageHeight heightField;

        private ItemSearchResponseItemsItemMediumImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemMediumImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemMediumImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemMediumImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemMediumImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemLargeImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemLargeImageHeight heightField;

        private ItemSearchResponseItemsItemLargeImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemLargeImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemLargeImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemLargeImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemLargeImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSet
    {

        private ItemSearchResponseItemsItemImageSetSwatchImage swatchImageField;

        private ItemSearchResponseItemsItemImageSetSmallImage smallImageField;

        private ItemSearchResponseItemsItemImageSetThumbnailImage thumbnailImageField;

        private ItemSearchResponseItemsItemImageSetTinyImage tinyImageField;

        private ItemSearchResponseItemsItemImageSetMediumImage mediumImageField;

        private ItemSearchResponseItemsItemImageSetLargeImage largeImageField;

        private string categoryField;

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSwatchImage SwatchImage
        {
            get
            {
                return this.swatchImageField;
            }
            set
            {
                this.swatchImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSmallImage SmallImage
        {
            get
            {
                return this.smallImageField;
            }
            set
            {
                this.smallImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetThumbnailImage ThumbnailImage
        {
            get
            {
                return this.thumbnailImageField;
            }
            set
            {
                this.thumbnailImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetTinyImage TinyImage
        {
            get
            {
                return this.tinyImageField;
            }
            set
            {
                this.tinyImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetMediumImage MediumImage
        {
            get
            {
                return this.mediumImageField;
            }
            set
            {
                this.mediumImageField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetLargeImage LargeImage
        {
            get
            {
                return this.largeImageField;
            }
            set
            {
                this.largeImageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSwatchImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetSwatchImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetSwatchImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSwatchImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSwatchImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSwatchImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSwatchImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSmallImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetSmallImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetSmallImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSmallImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetSmallImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSmallImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetSmallImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetThumbnailImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetThumbnailImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetThumbnailImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetThumbnailImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetThumbnailImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetThumbnailImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetThumbnailImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetTinyImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetTinyImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetTinyImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetTinyImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetTinyImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetTinyImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetTinyImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetMediumImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetMediumImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetMediumImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetMediumImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetMediumImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetMediumImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetMediumImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetLargeImage
    {

        private string uRLField;

        private ItemSearchResponseItemsItemImageSetLargeImageHeight heightField;

        private ItemSearchResponseItemsItemImageSetLargeImageWidth widthField;

        /// <remarks/>
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetLargeImageHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemImageSetLargeImageWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetLargeImageHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemImageSetLargeImageWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributes
    {

        private string bindingField;

        private string brandField;

        private string colorField;

        private ulong eANField;

        private bool eANFieldSpecified;

        private ItemSearchResponseItemsItemItemAttributesEANList eANListField;

        private string[] featureField;

        private long isAdultProductField;

        private bool isAdultProductFieldSpecified;

        private ItemSearchResponseItemsItemItemAttributesItemDimensions itemDimensionsField;

        private long isAutographedField;

        private bool isAutographedFieldSpecified;

        private long isMemorabiliaField;

        private bool isMemorabiliaFieldSpecified;

        private string labelField;

        private ItemSearchResponseItemsItemItemAttributesListPrice listPriceField;

        private string manufacturerField;

        private string modelField;

        private string mPNField;

        private long numberOfItemsField;

        private bool numberOfItemsFieldSpecified;

        private ItemSearchResponseItemsItemItemAttributesPackageDimensions packageDimensionsField;

        private long packageQuantityField;

        private bool packageQuantityFieldSpecified;

        private string partNumberField;

        private string productGroupField;

        private string productTypeNameField;

        private string publisherField;

        private string sizeField;

        private string studioField;

        private string titleField;

        private ulong uPCField;

        private bool uPCFieldSpecified;

        private ItemSearchResponseItemsItemItemAttributesUPCList uPCListField;

        /// <remarks/>
        public string Binding
        {
            get
            {
                return this.bindingField;
            }
            set
            {
                this.bindingField = value;
            }
        }

        /// <remarks/>
        public string Brand
        {
            get
            {
                return this.brandField;
            }
            set
            {
                this.brandField = value;
            }
        }

        /// <remarks/>
        public string Color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }

        /// <remarks/>
        public ulong EAN
        {
            get
            {
                return this.eANField;
            }
            set
            {
                this.eANField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EANSpecified
        {
            get
            {
                return this.eANFieldSpecified;
            }
            set
            {
                this.eANFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesEANList EANList
        {
            get
            {
                return this.eANListField;
            }
            set
            {
                this.eANListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Feature")]
        public string[] Feature
        {
            get
            {
                return this.featureField;
            }
            set
            {
                this.featureField = value;
            }
        }

        /// <remarks/>
        public long IsAdultProduct
        {
            get
            {
                return this.isAdultProductField;
            }
            set
            {
                this.isAdultProductField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAdultProductSpecified
        {
            get
            {
                return this.isAdultProductFieldSpecified;
            }
            set
            {
                this.isAdultProductFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesItemDimensions ItemDimensions
        {
            get
            {
                return this.itemDimensionsField;
            }
            set
            {
                this.itemDimensionsField = value;
            }
        }

        /// <remarks/>
        public long IsAutographed
        {
            get
            {
                return this.isAutographedField;
            }
            set
            {
                this.isAutographedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAutographedSpecified
        {
            get
            {
                return this.isAutographedFieldSpecified;
            }
            set
            {
                this.isAutographedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public long IsMemorabilia
        {
            get
            {
                return this.isMemorabiliaField;
            }
            set
            {
                this.isMemorabiliaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsMemorabiliaSpecified
        {
            get
            {
                return this.isMemorabiliaFieldSpecified;
            }
            set
            {
                this.isMemorabiliaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesListPrice ListPrice
        {
            get
            {
                return this.listPriceField;
            }
            set
            {
                this.listPriceField = value;
            }
        }

        /// <remarks/>
        public string Manufacturer
        {
            get
            {
                return this.manufacturerField;
            }
            set
            {
                this.manufacturerField = value;
            }
        }

        /// <remarks/>
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        public string MPN
        {
            get
            {
                return this.mPNField;
            }
            set
            {
                this.mPNField = value;
            }
        }

        /// <remarks/>
        public long NumberOfItems
        {
            get
            {
                return this.numberOfItemsField;
            }
            set
            {
                this.numberOfItemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfItemsSpecified
        {
            get
            {
                return this.numberOfItemsFieldSpecified;
            }
            set
            {
                this.numberOfItemsFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesPackageDimensions PackageDimensions
        {
            get
            {
                return this.packageDimensionsField;
            }
            set
            {
                this.packageDimensionsField = value;
            }
        }

        /// <remarks/>
        public long PackageQuantity
        {
            get
            {
                return this.packageQuantityField;
            }
            set
            {
                this.packageQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PackageQuantitySpecified
        {
            get
            {
                return this.packageQuantityFieldSpecified;
            }
            set
            {
                this.packageQuantityFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string PartNumber
        {
            get
            {
                return this.partNumberField;
            }
            set
            {
                this.partNumberField = value;
            }
        }

        /// <remarks/>
        public string ProductGroup
        {
            get
            {
                return this.productGroupField;
            }
            set
            {
                this.productGroupField = value;
            }
        }

        /// <remarks/>
        public string ProductTypeName
        {
            get
            {
                return this.productTypeNameField;
            }
            set
            {
                this.productTypeNameField = value;
            }
        }

        /// <remarks/>
        public string Publisher
        {
            get
            {
                return this.publisherField;
            }
            set
            {
                this.publisherField = value;
            }
        }

        /// <remarks/>
        public string Size
        {
            get
            {
                return this.sizeField;
            }
            set
            {
                this.sizeField = value;
            }
        }

        /// <remarks/>
        public string Studio
        {
            get
            {
                return this.studioField;
            }
            set
            {
                this.studioField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }

        /// <remarks/>
        public ulong UPC
        {
            get
            {
                return this.uPCField;
            }
            set
            {
                this.uPCField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UPCSpecified
        {
            get
            {
                return this.uPCFieldSpecified;
            }
            set
            {
                this.uPCFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesUPCList UPCList
        {
            get
            {
                return this.uPCListField;
            }
            set
            {
                this.uPCListField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesEANList
    {

        private ulong eANListElementField;

        /// <remarks/>
        public ulong EANListElement
        {
            get
            {
                return this.eANListElementField;
            }
            set
            {
                this.eANListElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesItemDimensions
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Height", typeof(ItemSearchResponseItemsItemItemAttributesItemDimensionsHeight))]
        [System.Xml.Serialization.XmlElementAttribute("Length", typeof(ItemSearchResponseItemsItemItemAttributesItemDimensionsLength))]
        [System.Xml.Serialization.XmlElementAttribute("Weight", typeof(ItemSearchResponseItemsItemItemAttributesItemDimensionsWeight))]
        [System.Xml.Serialization.XmlElementAttribute("Width", typeof(ItemSearchResponseItemsItemItemAttributesItemDimensionsWidth))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesItemDimensionsHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesItemDimensionsLength
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesItemDimensionsWeight
    {

        private string unitsField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesItemDimensionsWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesListPrice
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesPackageDimensions
    {

        private ItemSearchResponseItemsItemItemAttributesPackageDimensionsHeight heightField;

        private ItemSearchResponseItemsItemItemAttributesPackageDimensionsLength lengthField;

        private ItemSearchResponseItemsItemItemAttributesPackageDimensionsWeight weightField;

        private ItemSearchResponseItemsItemItemAttributesPackageDimensionsWidth widthField;

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesPackageDimensionsHeight Height
        {
            get
            {
                return this.heightField;
            }
            set
            {
                this.heightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesPackageDimensionsLength Length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesPackageDimensionsWeight Weight
        {
            get
            {
                return this.weightField;
            }
            set
            {
                this.weightField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemItemAttributesPackageDimensionsWidth Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesPackageDimensionsHeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesPackageDimensionsLength
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesPackageDimensionsWeight
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesPackageDimensionsWidth
    {

        private string unitsField;

        private long valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public long Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemItemAttributesUPCList
    {

        private ulong uPCListElementField;

        /// <remarks/>
        public ulong UPCListElement
        {
            get
            {
                return this.uPCListElementField;
            }
            set
            {
                this.uPCListElementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOfferSummary
    {

        private ItemSearchResponseItemsItemOfferSummaryLowestNewPrice lowestNewPriceField;

        private ItemSearchResponseItemsItemOfferSummaryLowestUsedPrice lowestUsedPriceField;

        private long totalNewField;

        private long totalUsedField;

        private long totalCollectibleField;

        private long totalRefurbishedField;

        /// <remarks/>
        public ItemSearchResponseItemsItemOfferSummaryLowestNewPrice LowestNewPrice
        {
            get
            {
                return this.lowestNewPriceField;
            }
            set
            {
                this.lowestNewPriceField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOfferSummaryLowestUsedPrice LowestUsedPrice
        {
            get
            {
                return this.lowestUsedPriceField;
            }
            set
            {
                this.lowestUsedPriceField = value;
            }
        }

        /// <remarks/>
        public long TotalNew
        {
            get
            {
                return this.totalNewField;
            }
            set
            {
                this.totalNewField = value;
            }
        }

        /// <remarks/>
        public long TotalUsed
        {
            get
            {
                return this.totalUsedField;
            }
            set
            {
                this.totalUsedField = value;
            }
        }

        /// <remarks/>
        public long TotalCollectible
        {
            get
            {
                return this.totalCollectibleField;
            }
            set
            {
                this.totalCollectibleField = value;
            }
        }

        /// <remarks/>
        public long TotalRefurbished
        {
            get
            {
                return this.totalRefurbishedField;
            }
            set
            {
                this.totalRefurbishedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOfferSummaryLowestNewPrice
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOfferSummaryLowestUsedPrice
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffers
    {

        private long totalOffersField;

        private long totalOfferPagesField;

        private string moreOffersUrlField;

        private ItemSearchResponseItemsItemOffersOffer offerField;

        /// <remarks/>
        public long TotalOffers
        {
            get
            {
                return this.totalOffersField;
            }
            set
            {
                this.totalOffersField = value;
            }
        }

        /// <remarks/>
        public long TotalOfferPages
        {
            get
            {
                return this.totalOfferPagesField;
            }
            set
            {
                this.totalOfferPagesField = value;
            }
        }

        /// <remarks/>
        public string MoreOffersUrl
        {
            get
            {
                return this.moreOffersUrlField;
            }
            set
            {
                this.moreOffersUrlField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOffer Offer
        {
            get
            {
                return this.offerField;
            }
            set
            {
                this.offerField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOffer
    {

        private ItemSearchResponseItemsItemOffersOfferOfferAttributes offerAttributesField;

        private ItemSearchResponseItemsItemOffersOfferOfferListing offerListingField;

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferAttributes OfferAttributes
        {
            get
            {
                return this.offerAttributesField;
            }
            set
            {
                this.offerAttributesField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferListing OfferListing
        {
            get
            {
                return this.offerListingField;
            }
            set
            {
                this.offerListingField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferAttributes
    {

        private string conditionField;

        /// <remarks/>
        public string Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferListing
    {

        private string offerListingIdField;

        private ItemSearchResponseItemsItemOffersOfferOfferListingPrice priceField;

        private ItemSearchResponseItemsItemOffersOfferOfferListingSalePrice salePriceField;

        private ItemSearchResponseItemsItemOffersOfferOfferListingAmountSaved amountSavedField;

        private long percentageSavedField;

        private bool percentageSavedFieldSpecified;

        private string availabilityField;

        private ItemSearchResponseItemsItemOffersOfferOfferListingAvailabilityAttributes availabilityAttributesField;

        private long isEligibleForSuperSaverShippingField;

        private long isEligibleForPrimeField;

        /// <remarks/>
        public string OfferListingId
        {
            get
            {
                return this.offerListingIdField;
            }
            set
            {
                this.offerListingIdField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferListingPrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferListingSalePrice SalePrice
        {
            get
            {
                return this.salePriceField;
            }
            set
            {
                this.salePriceField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferListingAmountSaved AmountSaved
        {
            get
            {
                return this.amountSavedField;
            }
            set
            {
                this.amountSavedField = value;
            }
        }

        /// <remarks/>
        public long PercentageSaved
        {
            get
            {
                return this.percentageSavedField;
            }
            set
            {
                this.percentageSavedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PercentageSavedSpecified
        {
            get
            {
                return this.percentageSavedFieldSpecified;
            }
            set
            {
                this.percentageSavedFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Availability
        {
            get
            {
                return this.availabilityField;
            }
            set
            {
                this.availabilityField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemOffersOfferOfferListingAvailabilityAttributes AvailabilityAttributes
        {
            get
            {
                return this.availabilityAttributesField;
            }
            set
            {
                this.availabilityAttributesField = value;
            }
        }

        /// <remarks/>
        public long IsEligibleForSuperSaverShipping
        {
            get
            {
                return this.isEligibleForSuperSaverShippingField;
            }
            set
            {
                this.isEligibleForSuperSaverShippingField = value;
            }
        }

        /// <remarks/>
        public long IsEligibleForPrime
        {
            get
            {
                return this.isEligibleForPrimeField;
            }
            set
            {
                this.isEligibleForPrimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferListingPrice
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferListingSalePrice
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferListingAmountSaved
    {

        private long amountField;

        private string currencyCodeField;

        private string formattedPriceField;

        /// <remarks/>
        public long Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        public string CurrencyCode
        {
            get
            {
                return this.currencyCodeField;
            }
            set
            {
                this.currencyCodeField = value;
            }
        }

        /// <remarks/>
        public string FormattedPrice
        {
            get
            {
                return this.formattedPriceField;
            }
            set
            {
                this.formattedPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemOffersOfferOfferListingAvailabilityAttributes
    {

        private string availabilityTypeField;

        private long minimumHoursField;

        private long maximumHoursField;

        /// <remarks/>
        public string AvailabilityType
        {
            get
            {
                return this.availabilityTypeField;
            }
            set
            {
                this.availabilityTypeField = value;
            }
        }

        /// <remarks/>
        public long MinimumHours
        {
            get
            {
                return this.minimumHoursField;
            }
            set
            {
                this.minimumHoursField = value;
            }
        }

        /// <remarks/>
        public long MaximumHours
        {
            get
            {
                return this.maximumHoursField;
            }
            set
            {
                this.maximumHoursField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemCustomerReviews
    {

        private string iFrameURLField;

        private bool hasReviewsField;

        /// <remarks/>
        public string IFrameURL
        {
            get
            {
                return this.iFrameURLField;
            }
            set
            {
                this.iFrameURLField = value;
            }
        }

        /// <remarks/>
        public bool HasReviews
        {
            get
            {
                return this.hasReviewsField;
            }
            set
            {
                this.hasReviewsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemEditorialReviews
    {

        private ItemSearchResponseItemsItemEditorialReviewsEditorialReview editorialReviewField;

        /// <remarks/>
        public ItemSearchResponseItemsItemEditorialReviewsEditorialReview EditorialReview
        {
            get
            {
                return this.editorialReviewField;
            }
            set
            {
                this.editorialReviewField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemEditorialReviewsEditorialReview
    {

        private string sourceField;

        private string contentField;

        private long isLinkSuppressedField;

        /// <remarks/>
        public string Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }

        /// <remarks/>
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }

        /// <remarks/>
        public long IsLinkSuppressed
        {
            get
            {
                return this.isLinkSuppressedField;
            }
            set
            {
                this.isLinkSuppressedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemSimilarProduct
    {

        private string aSINField;

        private string titleField;

        /// <remarks/>
        public string ASIN
        {
            get
            {
                return this.aSINField;
            }
            set
            {
                this.aSINField = value;
            }
        }

        /// <remarks/>
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNode
    {

        private ulong browseNodeIdField;

        private string nameField;

        private long isCategoryRootField;

        private bool isCategoryRootFieldSpecified;

        private ItemSearchResponseItemsItemBrowseNodeBrowseNode[] childrenField;

        private ItemSearchResponseItemsItemBrowseNodeAncestors ancestorsField;

        /// <remarks/>
        public ulong BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public long IsCategoryRoot
        {
            get
            {
                return this.isCategoryRootField;
            }
            set
            {
                this.isCategoryRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCategoryRootSpecified
        {
            get
            {
                return this.isCategoryRootFieldSpecified;
            }
            set
            {
                this.isCategoryRootFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("BrowseNode", IsNullable = false)]
        public ItemSearchResponseItemsItemBrowseNodeBrowseNode[] Children
        {
            get
            {
                return this.childrenField;
            }
            set
            {
                this.childrenField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestors Ancestors
        {
            get
            {
                return this.ancestorsField;
            }
            set
            {
                this.ancestorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeBrowseNode
    {

        private ulong browseNodeIdField;

        private string nameField;

        /// <remarks/>
        public ulong BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestors
    {

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNode BrowseNode
        {
            get
            {
                return this.browseNodeField;
            }
            set
            {
                this.browseNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNode
    {

        private ulong browseNodeIdField;

        private string nameField;

        private long isCategoryRootField;

        private bool isCategoryRootFieldSpecified;

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

        /// <remarks/>
        public ulong BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public long IsCategoryRoot
        {
            get
            {
                return this.isCategoryRootField;
            }
            set
            {
                this.isCategoryRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCategoryRootSpecified
        {
            get
            {
                return this.isCategoryRootFieldSpecified;
            }
            set
            {
                this.isCategoryRootFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestors Ancestors
        {
            get
            {
                return this.ancestorsField;
            }
            set
            {
                this.ancestorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
        {
            get
            {
                return this.browseNodeField;
            }
            set
            {
                this.browseNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

        /// <remarks/>
        public long BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors Ancestors
        {
            get
            {
                return this.ancestorsField;
            }
            set
            {
                this.ancestorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
        {
            get
            {
                return this.browseNodeField;
            }
            set
            {
                this.browseNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private long isCategoryRootField;

        private bool isCategoryRootFieldSpecified;

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

        /// <remarks/>
        public long BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public long IsCategoryRoot
        {
            get
            {
                return this.isCategoryRootField;
            }
            set
            {
                this.isCategoryRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCategoryRootSpecified
        {
            get
            {
                return this.isCategoryRootFieldSpecified;
            }
            set
            {
                this.isCategoryRootFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors Ancestors
        {
            get
            {
                return this.ancestorsField;
            }
            set
            {
                this.ancestorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
        {
            get
            {
                return this.browseNodeField;
            }
            set
            {
                this.browseNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private long isCategoryRootField;

        private bool isCategoryRootFieldSpecified;

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

        /// <remarks/>
        public long BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public long IsCategoryRoot
        {
            get
            {
                return this.isCategoryRootField;
            }
            set
            {
                this.isCategoryRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCategoryRootSpecified
        {
            get
            {
                return this.isCategoryRootFieldSpecified;
            }
            set
            {
                this.isCategoryRootFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors Ancestors
        {
            get
            {
                return this.ancestorsField;
            }
            set
            {
                this.ancestorsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
        {
            get
            {
                return this.browseNodeField;
            }
            set
            {
                this.browseNodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemSearchResponseItemsItemBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        /// <remarks/>
        public long BrowseNodeId
        {
            get
            {
                return this.browseNodeIdField;
            }
            set
            {
                this.browseNodeIdField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }


}
