using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class Request
    {
        public string IsValid { get; set; }
        [XmlArrayItem("Error")]
        public AmazonError[] Errors { get; set; }
    }
}
