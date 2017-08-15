using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class OfferListing
    {
        public string OfferListingId { get; set; }
        public Price Price { get; set; }
        public Price SalePrice { get; set; }
        public Price AmountSaved { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string PercentageSaved { get; set; }
        public string Availability { get; set; }
        public bool IsEligibleForSuperSaverShipping { get; set; }
        public bool IsEligibleForPrime { get; set; }
    }
}
