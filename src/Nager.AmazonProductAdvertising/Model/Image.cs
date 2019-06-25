namespace Nager.AmazonProductAdvertising.Model
{
    public class Image
    {
        public string URL { get; set; }
        public DecimalWithUnits Height { get; set; }
        public DecimalWithUnits Width { get; set; }
        public string IsVerified { get; set; }

        public override string ToString()
        {
            return this.URL;
        }
    }
}
