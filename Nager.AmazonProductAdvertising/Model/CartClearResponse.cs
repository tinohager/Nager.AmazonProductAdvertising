using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot(Namespace = "http://webservices.amazon.com/AWSECommerceService/2013-08-01")]
    public class CartClearResponse : AmazonResponse
    {
        public Cart Cart { get; set; }
    }
}
