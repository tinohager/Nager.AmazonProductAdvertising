using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class BrowseNodeLookupResponse : AmazonResponse
    {
        public BrowseNodes BrowseNodes { get; set; }
    }
}
