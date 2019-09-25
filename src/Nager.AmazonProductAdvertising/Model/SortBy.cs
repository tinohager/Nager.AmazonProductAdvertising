using System.Runtime.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public enum SortBy
    {
        [EnumMember(Value = "AvgCustomerReviews")]
        AvgCustomerReviews,
        [EnumMember(Value = "Featured")]
        Featured,
        [EnumMember(Value = "NewestArrivals")]
        NewestArrivals,
        [EnumMember(Value = "Price:HighToLow")]
        PriceHighToLow,
        [EnumMember(Value = "Price:LowToHigh")]
        PriceLowToHigh,
        [EnumMember(Value = "Relevance")]
        Relevance
    }
}
