using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class ItemAttributesCreator
    {
        [XmlAttribute]
        public string Role { get; set; }
        [XmlText]
        public string Name { get; set; }
    }
}
