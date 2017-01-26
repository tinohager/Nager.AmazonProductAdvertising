using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class TopItem
    {
        public string ASIN { get; set; }
        public string Title { get; set; }
        public string DetailPageURL { get; set; }
        public string ProductGroup { get; set; }
        [XmlElement("Actor")]
        public string[] Actor { get; set; }
    }
}
