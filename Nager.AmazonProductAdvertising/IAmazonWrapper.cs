using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Operation;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nager.AmazonProductAdvertising
{
    public interface IAmazonWrapper
    {
        void SetEndpoint(AmazonEndpoint amazonEndpoint);
        void SetUserAgent(string userAgent);

        #region Lookup

        AmazonItemResponse Lookup(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        AmazonItemResponse Lookup(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> LookupAsync(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        #endregion

        #region Search

        AmazonItemResponse Search(string search,short PageNum, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);
        Task<AmazonItemResponse> SearchAsync(string search,short PageNum, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large);

        #endregion

        #region CartCreate

        CartCreateResponse CartCreate(IList<AmazonCartItem> amazonCartItems);
        Task<CartCreateResponse> CartCreateAsync(IList<AmazonCartItem> amazonCartItems);

        #endregion

        #region BrowseNode

        BrowseNodeLookupResponse BrowseNodeLookup(long browseNodeId, AmazonResponseGroup responseGroup = AmazonResponseGroup.BrowseNodeInfo);

        Task<BrowseNodeLookupResponse> BrowseNodeLookupAsync(long browseNodeId, AmazonResponseGroup responseGroup = AmazonResponseGroup.BrowseNodeInfo);

        #endregion

        ExtendedWebResponse Request(AmazonOperationBase amazonOperation);  
        Task<ExtendedWebResponse> RequestAsync(AmazonOperationBase amazonOperation);
    }
}