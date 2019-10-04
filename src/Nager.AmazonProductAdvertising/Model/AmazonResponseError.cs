using Newtonsoft.Json;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonResponseError
    {
        [JsonProperty("__type")]
        public string Type { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
    }
}
