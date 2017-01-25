using Nager.AmazonProductAdvertising.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising
{
    public interface IAmazonWrapper
    {
        void SetEndpoint(AmazonEndpoint amazonEndpoint);
        void SetUserAgent(string userAgent);

        AmazonItemResponse Lookup(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        AmazonItemResponse Lookup(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        AmazonItemResponse Search(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> SearchAsync(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        ExtendedWebResponse Request(AmazonOperationBase amazonOperation);  
        Task<ExtendedWebResponse> RequestAsync(AmazonOperationBase amazonOperation);

        AmazonCreateCartResponse CreateCart(IList<AmazonCartItem> amazonCartItems);
    }
}