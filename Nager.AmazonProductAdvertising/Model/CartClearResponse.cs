using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class CartClearResponse : AmazonResponse
    {
        public Cart Cart { get; set; }
    }
}
