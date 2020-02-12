using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nager.AmazonProductAdvertising.Model.Request
{
    public class GetItemsRequest : AmazonRequest
    {
        public string[] ItemIds { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public Condition? Condition { get; set; }
    }
}
