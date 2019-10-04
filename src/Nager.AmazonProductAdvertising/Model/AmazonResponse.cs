using Newtonsoft.Json;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonResponse
    {
        [JsonProperty("__type")]
        public string Type { get; set; }
        public bool Successful { get; set; }
        public string ErrorMessage { get; set; }
        public AmazonResponseError[] Errors { get; set; }
    }
}
