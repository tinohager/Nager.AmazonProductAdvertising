using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Nager.AmazonProductAdvertising.Model.Request
{
    public class SearchItemRequest : AmazonRequest
    {
        public string Keywords { get; set; }
        public string Brand { get; set; }
        public string Title { get; set; }
        public int? ItemPage { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SortBy? SortBy { get; set; }
        public string BrowseNodeId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SearchIndex? SearchIndex { get; set; }
    }
}
