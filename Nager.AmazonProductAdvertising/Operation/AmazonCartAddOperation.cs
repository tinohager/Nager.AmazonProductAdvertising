using Nager.AmazonProductAdvertising.Model;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonCartAddOperation : AmazonOperationBase
    {
     public AmazonCartAddOperation()
        {
            base.ParameterDictionary.Add("Operation", "CartAdd");
        }

        public void AddItemToCart(AmazonCartItem Item, Cart cart)
        {

                base.ParameterDictionary.Add("CartId",cart.CartId );
                base.ParameterDictionary.Add("HMAC", cart.HMAC);
                base.ParameterDictionary.Add($"Item.1.ASIN", Item.Asin);
                base.ParameterDictionary.Add($"Item.1.Quantity", Item.Quantity.ToString());
                
        }
    }
}