using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class VariationDimensions
    {
        [XmlElement("VariationDimension")]
        public string[] VariationDimension { get; set; }
    }
}
