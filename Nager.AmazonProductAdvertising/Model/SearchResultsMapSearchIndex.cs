using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class SearchResultsMapSearchIndex
    {
        public string IndexName { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Results { get; set; }
        [XmlElement(DataType = "nonNegativeInteger")]
        public string Pages { get; set; }
        [XmlElement(Order = 3)]
        public CorrectedQuery CorrectedQuery { get; set; }
        [XmlElement(DataType = "positiveInteger")]
        public string RelevanceRank { get; set; }
        public string[] ASIN { get; set; }
    }
}
