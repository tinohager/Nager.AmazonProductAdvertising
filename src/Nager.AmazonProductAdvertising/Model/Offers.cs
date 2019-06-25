using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
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
}
