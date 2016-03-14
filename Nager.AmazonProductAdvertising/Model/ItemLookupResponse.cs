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
    public partial class ItemLookupResponse
    {

        private ItemLookupResponseOperationRequest operationRequestField;

        private ItemLookupResponseItems itemsField;

        /// <remarks/>
        public ItemLookupResponseOperationRequest OperationRequest
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
        public ItemLookupResponseItems Items
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
    public partial class ItemLookupResponseOperationRequest
    {

        private string requestIdField;

        private ItemLookupResponseOperationRequestArgument[] argumentsField;

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
        public ItemLookupResponseOperationRequestArgument[] Arguments
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
    public partial class ItemLookupResponseOperationRequestArgument
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
    public partial class ItemLookupResponseItems
    {

        private ItemLookupResponseItemsRequest requestField;

        private ItemLookupResponseItemsItem itemField;

        /// <remarks/>
        public ItemLookupResponseItemsRequest Request
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
        public ItemLookupResponseItemsItem Item
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
    public partial class ItemLookupResponseItemsRequest
    {

        private string isValidField;

        private ItemLookupResponseItemsRequestItemLookupRequest itemLookupRequestField;

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
        public ItemLookupResponseItemsRequestItemLookupRequest ItemLookupRequest
        {
            get
            {
                return this.itemLookupRequestField;
            }
            set
            {
                this.itemLookupRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemLookupResponseItemsRequestItemLookupRequest
    {

        private string idTypeField;

        private string itemIdField;

        private string responseGroupField;

        private string variationPageField;

        /// <remarks/>
        public string IdType
        {
            get
            {
                return this.idTypeField;
            }
            set
            {
                this.idTypeField = value;
            }
        }

        /// <remarks/>
        public string ItemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
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
        public string VariationPage
        {
            get
            {
                return this.variationPageField;
            }
            set
            {
                this.variationPageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemLookupResponseItemsItem
    {

        private string aSINField;

        private string parentASINField;

        private string detailPageURLField;

        private ItemLookupResponseItemsItemItemLink[] itemLinksField;

        private long salesRankField;

        private ItemLookupResponseItemsItemSmallImage smallImageField;

        private ItemLookupResponseItemsItemMediumImage mediumImageField;

        private ItemLookupResponseItemsItemLargeImage largeImageField;

        private ItemLookupResponseItemsItemImageSet[] imageSetsField;

        private ItemLookupResponseItemsItemItemAttributes itemAttributesField;

        private ItemLookupResponseItemsItemOfferSummary offerSummaryField;

        private ItemLookupResponseItemsItemOffers offersField;

        private ItemLookupResponseItemsItemCustomerReviews customerReviewsField;

        private ItemLookupResponseItemsItemEditorialReviews editorialReviewsField;

        private ItemLookupResponseItemsItemSimilarProduct[] similarProductsField;

        private ItemLookupResponseItemsItemBrowseNodes browseNodesField;

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
        public ItemLookupResponseItemsItemItemLink[] ItemLinks
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
        public ItemLookupResponseItemsItemSmallImage SmallImage
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
        public ItemLookupResponseItemsItemMediumImage MediumImage
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
        public ItemLookupResponseItemsItemLargeImage LargeImage
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
        public ItemLookupResponseItemsItemImageSet[] ImageSets
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
        public ItemLookupResponseItemsItemItemAttributes ItemAttributes
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
        public ItemLookupResponseItemsItemOfferSummary OfferSummary
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
        public ItemLookupResponseItemsItemOffers Offers
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
        public ItemLookupResponseItemsItemCustomerReviews CustomerReviews
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
        public ItemLookupResponseItemsItemEditorialReviews EditorialReviews
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
        public ItemLookupResponseItemsItemSimilarProduct[] SimilarProducts
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
        public ItemLookupResponseItemsItemBrowseNodes BrowseNodes
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
    public partial class ItemLookupResponseItemsItemItemLink
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
    public partial class ItemLookupResponseItemsItemSmallImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemSmallImageHeight heightField;

        private ItemLookupResponseItemsItemSmallImageWidth widthField;

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
        public ItemLookupResponseItemsItemSmallImageHeight Height
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
        public ItemLookupResponseItemsItemSmallImageWidth Width
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
    public partial class ItemLookupResponseItemsItemSmallImageHeight
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
    public partial class ItemLookupResponseItemsItemSmallImageWidth
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
    public partial class ItemLookupResponseItemsItemMediumImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemMediumImageHeight heightField;

        private ItemLookupResponseItemsItemMediumImageWidth widthField;

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
        public ItemLookupResponseItemsItemMediumImageHeight Height
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
        public ItemLookupResponseItemsItemMediumImageWidth Width
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
    public partial class ItemLookupResponseItemsItemMediumImageHeight
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
    public partial class ItemLookupResponseItemsItemMediumImageWidth
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
    public partial class ItemLookupResponseItemsItemLargeImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemLargeImageHeight heightField;

        private ItemLookupResponseItemsItemLargeImageWidth widthField;

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
        public ItemLookupResponseItemsItemLargeImageHeight Height
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
        public ItemLookupResponseItemsItemLargeImageWidth Width
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
    public partial class ItemLookupResponseItemsItemLargeImageHeight
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
    public partial class ItemLookupResponseItemsItemLargeImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSet
    {

        private ItemLookupResponseItemsItemImageSetSwatchImage swatchImageField;

        private ItemLookupResponseItemsItemImageSetSmallImage smallImageField;

        private ItemLookupResponseItemsItemImageSetThumbnailImage thumbnailImageField;

        private ItemLookupResponseItemsItemImageSetTinyImage tinyImageField;

        private ItemLookupResponseItemsItemImageSetMediumImage mediumImageField;

        private ItemLookupResponseItemsItemImageSetLargeImage largeImageField;

        private string categoryField;

        /// <remarks/>
        public ItemLookupResponseItemsItemImageSetSwatchImage SwatchImage
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
        public ItemLookupResponseItemsItemImageSetSmallImage SmallImage
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
        public ItemLookupResponseItemsItemImageSetThumbnailImage ThumbnailImage
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
        public ItemLookupResponseItemsItemImageSetTinyImage TinyImage
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
        public ItemLookupResponseItemsItemImageSetMediumImage MediumImage
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
        public ItemLookupResponseItemsItemImageSetLargeImage LargeImage
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
    public partial class ItemLookupResponseItemsItemImageSetSwatchImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetSwatchImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetSwatchImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetSwatchImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetSwatchImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetSwatchImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetSwatchImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSetSmallImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetSmallImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetSmallImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetSmallImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetSmallImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetSmallImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetSmallImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSetThumbnailImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetThumbnailImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetThumbnailImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetThumbnailImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetThumbnailImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetThumbnailImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetThumbnailImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSetTinyImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetTinyImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetTinyImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetTinyImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetTinyImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetTinyImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetTinyImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSetMediumImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetMediumImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetMediumImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetMediumImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetMediumImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetMediumImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetMediumImageWidth
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
    public partial class ItemLookupResponseItemsItemImageSetLargeImage
    {

        private string uRLField;

        private ItemLookupResponseItemsItemImageSetLargeImageHeight heightField;

        private ItemLookupResponseItemsItemImageSetLargeImageWidth widthField;

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
        public ItemLookupResponseItemsItemImageSetLargeImageHeight Height
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
        public ItemLookupResponseItemsItemImageSetLargeImageWidth Width
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
    public partial class ItemLookupResponseItemsItemImageSetLargeImageHeight
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
    public partial class ItemLookupResponseItemsItemImageSetLargeImageWidth
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
    public partial class ItemLookupResponseItemsItemItemAttributes
    {

        private string aspectRatioField;

        private string bindingField;

        private string brandField;

        private string[] catalogNumberListField;

        private string colorField;

        private ItemLookupResponseItemsItemItemAttributesCreator creatorField;

        private ulong eANField;

        private ItemLookupResponseItemsItemItemAttributesEANList eANListField;

        private string[] featureField;

        private ItemLookupResponseItemsItemItemAttributesItemDimensions itemDimensionsField;

        private string labelField;

        private string legalDisclaimerField;

        private ItemLookupResponseItemsItemItemAttributesListPrice listPriceField;

        private string manufacturerField;

        private string mediaTypeField;

        private string modelField;

        private string mPNField;

        private ItemLookupResponseItemsItemItemAttributesPackageDimensions packageDimensionsField;

        private long packageQuantityField;

        private string partNumberField;

        private string productGroupField;

        private string productTypeNameField;

        private string publisherField;

        private string sizeField;

        private string studioField;

        private string titleField;

        /// <remarks/>
        public string AspectRatio
        {
            get
            {
                return this.aspectRatioField;
            }
            set
            {
                this.aspectRatioField = value;
            }
        }

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
        [System.Xml.Serialization.XmlArrayItemAttribute("CatalogNumberListElement", IsNullable = false)]
        public string[] CatalogNumberList
        {
            get
            {
                return this.catalogNumberListField;
            }
            set
            {
                this.catalogNumberListField = value;
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
        public ItemLookupResponseItemsItemItemAttributesCreator Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
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
        public ItemLookupResponseItemsItemItemAttributesEANList EANList
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
        public ItemLookupResponseItemsItemItemAttributesItemDimensions ItemDimensions
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
        public string LegalDisclaimer
        {
            get
            {
                return this.legalDisclaimerField;
            }
            set
            {
                this.legalDisclaimerField = value;
            }
        }

        /// <remarks/>
        public ItemLookupResponseItemsItemItemAttributesListPrice ListPrice
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
        public string MediaType
        {
            get
            {
                return this.mediaTypeField;
            }
            set
            {
                this.mediaTypeField = value;
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
        public ItemLookupResponseItemsItemItemAttributesPackageDimensions PackageDimensions
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://webservices.amazon.com/AWSECommerceService/2011-08-01")]
    public partial class ItemLookupResponseItemsItemItemAttributesCreator
    {

        private string roleField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
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
    public partial class ItemLookupResponseItemsItemItemAttributesEANList
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
    public partial class ItemLookupResponseItemsItemItemAttributesItemDimensions
    {

        private ItemLookupResponseItemsItemItemAttributesItemDimensionsHeight heightField;

        private ItemLookupResponseItemsItemItemAttributesItemDimensionsLength lengthField;

        private ItemLookupResponseItemsItemItemAttributesItemDimensionsWeight weightField;

        private ItemLookupResponseItemsItemItemAttributesItemDimensionsWidth widthField;

        /// <remarks/>
        public ItemLookupResponseItemsItemItemAttributesItemDimensionsHeight Height
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
        public ItemLookupResponseItemsItemItemAttributesItemDimensionsLength Length
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
        public ItemLookupResponseItemsItemItemAttributesItemDimensionsWeight Weight
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
        public ItemLookupResponseItemsItemItemAttributesItemDimensionsWidth Width
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
    public partial class ItemLookupResponseItemsItemItemAttributesItemDimensionsHeight
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
    public partial class ItemLookupResponseItemsItemItemAttributesItemDimensionsLength
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
    public partial class ItemLookupResponseItemsItemItemAttributesItemDimensionsWeight
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
    public partial class ItemLookupResponseItemsItemItemAttributesItemDimensionsWidth
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
    public partial class ItemLookupResponseItemsItemItemAttributesListPrice
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
    public partial class ItemLookupResponseItemsItemItemAttributesPackageDimensions
    {

        private ItemLookupResponseItemsItemItemAttributesPackageDimensionsHeight heightField;

        private ItemLookupResponseItemsItemItemAttributesPackageDimensionsLength lengthField;

        private ItemLookupResponseItemsItemItemAttributesPackageDimensionsWeight weightField;

        private ItemLookupResponseItemsItemItemAttributesPackageDimensionsWidth widthField;

        /// <remarks/>
        public ItemLookupResponseItemsItemItemAttributesPackageDimensionsHeight Height
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
        public ItemLookupResponseItemsItemItemAttributesPackageDimensionsLength Length
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
        public ItemLookupResponseItemsItemItemAttributesPackageDimensionsWeight Weight
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
        public ItemLookupResponseItemsItemItemAttributesPackageDimensionsWidth Width
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
    public partial class ItemLookupResponseItemsItemItemAttributesPackageDimensionsHeight
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
    public partial class ItemLookupResponseItemsItemItemAttributesPackageDimensionsLength
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
    public partial class ItemLookupResponseItemsItemItemAttributesPackageDimensionsWeight
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
    public partial class ItemLookupResponseItemsItemItemAttributesPackageDimensionsWidth
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
    public partial class ItemLookupResponseItemsItemOfferSummary
    {

        private ItemLookupResponseItemsItemOfferSummaryLowestNewPrice lowestNewPriceField;

        private ItemLookupResponseItemsItemOfferSummaryLowestUsedPrice lowestUsedPriceField;

        private long totalNewField;

        private long totalUsedField;

        private long totalCollectibleField;

        private long totalRefurbishedField;

        /// <remarks/>
        public ItemLookupResponseItemsItemOfferSummaryLowestNewPrice LowestNewPrice
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
        public ItemLookupResponseItemsItemOfferSummaryLowestUsedPrice LowestUsedPrice
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
    public partial class ItemLookupResponseItemsItemOfferSummaryLowestNewPrice
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
    public partial class ItemLookupResponseItemsItemOfferSummaryLowestUsedPrice
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
    public partial class ItemLookupResponseItemsItemOffers
    {

        private long totalOffersField;

        private long totalOfferPagesField;

        private string moreOffersUrlField;

        private ItemLookupResponseItemsItemOffersOffer offerField;

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
        public ItemLookupResponseItemsItemOffersOffer Offer
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
    public partial class ItemLookupResponseItemsItemOffersOffer
    {

        private ItemLookupResponseItemsItemOffersOfferOfferAttributes offerAttributesField;

        private ItemLookupResponseItemsItemOffersOfferOfferListing offerListingField;

        /// <remarks/>
        public ItemLookupResponseItemsItemOffersOfferOfferAttributes OfferAttributes
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
        public ItemLookupResponseItemsItemOffersOfferOfferListing OfferListing
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
    public partial class ItemLookupResponseItemsItemOffersOfferOfferAttributes
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
    public partial class ItemLookupResponseItemsItemOffersOfferOfferListing
    {

        private string offerListingIdField;

        private ItemLookupResponseItemsItemOffersOfferOfferListingPrice priceField;

        private ItemLookupResponseItemsItemOffersOfferOfferListingAmountSaved amountSavedField;

        private long percentageSavedField;

        private string availabilityField;

        private ItemLookupResponseItemsItemOffersOfferOfferListingAvailabilityAttributes availabilityAttributesField;

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
        public ItemLookupResponseItemsItemOffersOfferOfferListingPrice Price
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
        public ItemLookupResponseItemsItemOffersOfferOfferListingAmountSaved AmountSaved
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
        public ItemLookupResponseItemsItemOffersOfferOfferListingAvailabilityAttributes AvailabilityAttributes
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
    public partial class ItemLookupResponseItemsItemOffersOfferOfferListingPrice
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
    public partial class ItemLookupResponseItemsItemOffersOfferOfferListingAmountSaved
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
    public partial class ItemLookupResponseItemsItemOffersOfferOfferListingAvailabilityAttributes
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
    public partial class ItemLookupResponseItemsItemCustomerReviews
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
    public partial class ItemLookupResponseItemsItemEditorialReviews
    {

        private ItemLookupResponseItemsItemEditorialReviewsEditorialReview editorialReviewField;

        /// <remarks/>
        public ItemLookupResponseItemsItemEditorialReviewsEditorialReview EditorialReview
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
    public partial class ItemLookupResponseItemsItemEditorialReviewsEditorialReview
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
    public partial class ItemLookupResponseItemsItemSimilarProduct
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
    public partial class ItemLookupResponseItemsItemBrowseNodes
    {

        private ItemLookupResponseItemsItemBrowseNodesBrowseNode browseNodeField;

        /// <remarks/>
        public ItemLookupResponseItemsItemBrowseNodesBrowseNode BrowseNode
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestors ancestorsField;

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
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestors Ancestors
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestors
    {

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNode BrowseNode
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

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
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestors Ancestors
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
    {

        private long browseNodeIdField;

        private string nameField;

        private long isCategoryRootField;

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors ancestorsField;

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
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors Ancestors
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestors
    {

        private ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode browseNodeField;

        /// <remarks/>
        public ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode BrowseNode
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
    public partial class ItemLookupResponseItemsItemBrowseNodesBrowseNodeAncestorsBrowseNodeAncestorsBrowseNodeAncestorsBrowseNode
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