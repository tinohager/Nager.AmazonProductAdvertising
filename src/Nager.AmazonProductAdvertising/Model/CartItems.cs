using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class CartItems
    {
        public Price SubTotal { get; set; }
        [XmlElement("CartItem")]
        public CartItem[] CartItem { get; set; }
    }
}
