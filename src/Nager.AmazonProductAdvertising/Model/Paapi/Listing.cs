namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class Listing
    {
        public Availability Availability { get; set; }
        public Condition Condition { get; set; }
        public DeliveryInfo DeliveryInfo { get; set; }
        public string Id { get; set; }
        public MerchantInfo MerchantInfo { get; set; }
        public Price Price { get; set; }
        public ProgramEligibility ProgramEligibility { get; set; }
        public bool ViolatesMAP { get; set; }
        public SavingBasis SavingBasis { get; set; }
        public Promotion[] Promotions { get; set; }
    }
}
