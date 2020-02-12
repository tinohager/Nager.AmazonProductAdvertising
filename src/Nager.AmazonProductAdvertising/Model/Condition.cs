using System.Runtime.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public enum Condition
    {
        [EnumMember(Value = "Any")]
        Any,
        [EnumMember(Value = "New")]
        New,
        [EnumMember(Value = "Used")]
        Used,
        [EnumMember(Value = "Collectible")]
        Collectible,
        [EnumMember(Value = "Refurbished")]
        Refurbished
    }
}
