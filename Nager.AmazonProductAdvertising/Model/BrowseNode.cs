using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot]
    public class BrowseNode
    {
        public string BrowseNodeId { get; set; }
        public string Name { get; set; }
        public int IsCategoryRoot { get; set; }
        [XmlArrayItem("BrowseNode")]
        public BrowseNode[] Children { get; set; }
        public TopSellers TopSellers { get; set; }
        public TopItemSet TopItemSet { get; set; }
        public BrowseNode[] Ancestors { get; set; }
    }
}
