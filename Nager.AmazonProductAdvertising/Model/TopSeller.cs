using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class TopSeller
    {
        public string ASIN { get; set; }
        public string Title { get; set; }
    }
}
