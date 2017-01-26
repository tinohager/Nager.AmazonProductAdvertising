using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class OperationRequest
    {
        public string RequestId { get; set; }
        public float RequestProcessingTime { get; set; }
        [XmlArrayItem("Header")]
        public HTTPHeadersHeader[] HTTPHeaders { get; set; }
        [XmlArrayItem("Argument")]
        public ArgumentsArgument[] Arguments { get; set; }
        [XmlArrayItem("Error")]
        public AmazonError[] Errors { get; set; }
    }
}
