using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class ItemAttributes
    {
        [XmlElement("Actor")]
        public string[] Actor { get; set; }
        [XmlElement("Artist")]
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
        [XmlElement("Category")]
        public string[] Category { get; set; }
        public string CEROAgeRating { get; set; }
        public string ClothingSize { get; set; }
        public string Color { get; set; }
        [XmlElement("Creator")]
        public ItemAttributesCreator[] Creator { get; set; }
        public string Department { get; set; }
        [XmlElement("Director")]
        public string[] Director { get; set; }
        public string EAN { get; set; }
        [XmlArrayItem("EANListElement", IsNullable = false)]
        public string[] EANList { get; set; }
        public string Edition { get; set; }
        [XmlElement("EISBN")]
        public string[] EISBN { get; set; }
        public string EpisodeSequence { get; set; }
        public string ESRBAgeRating { get; set; }
        [XmlElement("Feature")]
        public string[] Feature { get; set; }
        [XmlElement("Format")]
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
        [XmlElement("PictureFormat")]
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
}
