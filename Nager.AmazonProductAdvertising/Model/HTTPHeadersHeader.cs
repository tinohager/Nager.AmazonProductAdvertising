using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class HTTPHeadersHeader
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Value { get; set; }
    }
}
