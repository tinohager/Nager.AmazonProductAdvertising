using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class Items
    {
        public CorrectedQuery CorrectedQuery { get; set; }
        public string Qid { get; set; }
        public string EngineQuery { get; set; }
        public string TotalResults { get; set; }
        public string TotalPages { get; set; }
        public string MoreSearchResultsUrl { get; set; }
        [XmlElement(IsNullable = true)]
        public Request Request { get; set; }
        [XmlElement("Item")]
        public Item[] Item { get; set; }
    }
}
