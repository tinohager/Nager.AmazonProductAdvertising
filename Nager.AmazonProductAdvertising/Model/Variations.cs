using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class Variations
    {
        public int TotalVariations { get; set; }

        public int TotalVariationPages { get; set; }

        public VariationDimensions VariationDimensions { get; set; }

        [XmlElement("Item")]
        public Item[] Item { get; set; }
    }
}
