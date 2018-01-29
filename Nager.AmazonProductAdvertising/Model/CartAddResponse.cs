using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising.Model
{
    public class CartAddResponse : AmazonResponse
    {
        public Cart Cart { get; set; }

    }
}
