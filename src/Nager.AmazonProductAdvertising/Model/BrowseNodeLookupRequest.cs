using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class BrowseNodeLookupRequest
    {
        public string BrowseNodeId { get; set; }
        public string ResponseGroup { get; set; }
    }
}
