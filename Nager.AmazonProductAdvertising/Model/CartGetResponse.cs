using System;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot(Namespace = "http://webservices.amazon.com/AWSECommerceService/2013-08-01")]
    public class CartGetResponse : AmazonResponse
    {
        public Cart Cart { get; set; }

        public bool Validate()
        {
            // return true;
            return (Convert.ToBoolean(Cart.Request.IsValid) && this.OperationRequest.Errors == null);

        }
    }
}