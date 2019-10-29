using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nager.AmazonProductAdvertising.Model.Request
{
    public class AmazonRequest
    {
        public string PartnerTag { get; internal set; }
        public string PartnerType { get; internal set; }
        public string Marketplace { get; internal set; }
        public string[] Resources { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Merchant? Merchant { get; set; }
    }
}
