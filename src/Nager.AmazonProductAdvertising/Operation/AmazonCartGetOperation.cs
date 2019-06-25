using Nager.AmazonProductAdvertising.Model;

namespace  Nager.AmazonProductAdvertising.Operation
{
    public class  AmazonCartGetOperation : AmazonOperationBase
    {
        public AmazonCartGetOperation()
        {
            base.ParameterDictionary.Add("Operation", "CartGet");
        }

        public void GetCart(Cart cart)
        {
            base.ParameterDictionary.Add("CartId", cart.CartId);
            base.ParameterDictionary.Add("HMAC", cart.HMAC);
        }
    }
}