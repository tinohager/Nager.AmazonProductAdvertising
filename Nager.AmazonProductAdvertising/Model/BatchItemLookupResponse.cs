using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{

    [XmlRoot]
    public class BatchItemLookupResponse : AmazonResponse
    {

        public Items[] Items { get; set; }
    }
}
