namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class ExternalIds
    {
        public DisplayValuesItem<string[]> EANs { get; set; }
        public DisplayValuesItem<string[]> UPCs { get; set; }
        public DisplayValuesItem<string[]> ISBNs { get; set; }
    }
}
