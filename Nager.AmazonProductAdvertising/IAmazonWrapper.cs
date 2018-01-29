using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Operation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising
{
    public interface IAmazonWrapper
    {
        void SetEndpoint(AmazonEndpoint amazonEndpoint);
        void SetUserAgent(string userAgent);

        ExtendedWebResponse Request(AmazonOperationBase amazonOperation);
        Task<ExtendedWebResponse> RequestAsync(AmazonOperationBase amazonOperation);

        #region Lookup

        AmazonItemResponse Lookup(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        AmazonItemResponse Lookup(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        #endregion

        #region Search

        AmazonItemResponse Search(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> SearchAsync(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        #endregion

        #region Cart

        CartCreateResponse CartCreate(IList<AmazonCartItem> amazonCartItems);
        Task<CartCreateResponse> CartCreateAsync(IList<AmazonCartItem> amazonCartItems);

        CartAddResponse CartAdd(AmazonCartItem item, string cartId, string Hmac);
        Task<CartAddResponse> CartAddAsync(AmazonCartItem item, string cartId, string Hmac);

        CartGetResponse CartGet(string cartId, string Hmac);
        Task<CartGetResponse> CartGetAsync(string cartId, string Hmac);

        CartClearResponse CartClear(string cartId, string Hmac);
        Task<CartClearResponse> CartClearAsync(string cartId, string Hmac);

        #endregion

        #region BrowseNode

        BrowseNodeLookupResponse BrowseNodeLookup(long browseNodeId, AmazonResponseGroup responseGroup = AmazonResponseGroup.BrowseNodeInfo);

        Task<BrowseNodeLookupResponse> BrowseNodeLookupAsync(long browseNodeId, AmazonResponseGroup responseGroup = AmazonResponseGroup.BrowseNodeInfo);

        #endregion
    }
}