using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class VariationDimensions
    {
        [XmlElement("VariationDimension")]
        public string[] VariationDimension { get; set; }
    }
}
