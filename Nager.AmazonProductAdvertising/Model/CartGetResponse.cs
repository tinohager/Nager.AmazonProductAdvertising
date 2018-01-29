using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class CartGetResponse : AmazonResponse
    {
        public Cart Cart { get; set; }
    }
}