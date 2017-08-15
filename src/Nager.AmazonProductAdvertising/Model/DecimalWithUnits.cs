using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class DecimalWithUnits
    {
        [XmlAttribute]
        public string Units { get; set; }
        [XmlText]
        public decimal Value { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Value, this.Units);
        }
    }
}
