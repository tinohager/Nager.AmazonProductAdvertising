using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class TopItemSet
    {
        public string Type { get; set; }
        [XmlElement("TopItem")]
        public TopItem[] TopItem { get; set; }
    }
}
