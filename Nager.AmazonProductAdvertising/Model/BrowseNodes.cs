using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class BrowseNodes
    {
        public BaseBrowseNodeLookupRequest Request { get; set; }
        public BrowseNode BrowseNode { get; set; }
    }
}
