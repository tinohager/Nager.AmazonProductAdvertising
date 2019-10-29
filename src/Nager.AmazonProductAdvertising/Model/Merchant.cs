using System.Runtime.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public enum Merchant
    {
        [EnumMember(Value = "All")]
        All,
        [EnumMember(Value = "Amazon")]
        Amazon
    }
}
