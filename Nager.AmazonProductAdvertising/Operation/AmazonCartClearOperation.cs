

using Nager.AmazonProductAdvertising.Model;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonCartClearOperation : AmazonOperationBase
    {
        public AmazonCartClearOperation()
        {
            base.ParameterDictionary.Add("Operation", "CartClear");
        }

        public void ClearCart(Cart cart)
        {
          
            base.ParameterDictionary.Add($"CartId", cart.CartId);
             base.ParameterDictionary.Add($"HMAC",cart.HMAC);
                
        }
        


    }
}