using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonItemResponse : AmazonResponse
    { 

        [XmlElement("Items")]
        public Items[] Items { get; set; }
    }
}
