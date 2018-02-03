using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Operation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Nager.AmazonProductAdvertising
{
    public partial class AmazonWrapper : IAmazonWrapper
    {
        private AmazonAuthentication _authentication;
        private AmazonEndpoint _endpoint;
        private string _associateTag;
        private string _userAgent = null;

        public event Action<string> XmlReceived;
        public event Action<AmazonErrorResponse> ErrorReceived;

        public AmazonWrapper(AmazonAuthentication authentication, AmazonEndpoint endpoint, string associateTag = "nagerat-21")
        {
            this._authentication = authentication;
            this._endpoint = endpoint;
            this._associateTag = associateTag;
        }

        private ExtendedWebResponse SendRequest(string uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = this._userAgent ?? "Nager.AmazonProductAdvertising";

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var xml = streamReader.ReadToEnd();
                        this.XmlReceived?.Invoke(xml);

                        return new ExtendedWebResponse(HttpStatusCode.OK, xml);
                    }
                }
            }
            catch (WebException exception)
            {
                if (exception.Response == null)
                {
                    return new ExtendedWebResponse(HttpStatusCode.SeeOther, exception.Message);
                }

                using (var response = (HttpWebResponse)exception.Response)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var xml = streamReader.ReadToEnd();
                        this.XmlReceived?.Invoke(xml);

                        return new ExtendedWebResponse(response.StatusCode, xml);
                    }
                }
            }
            catch (Exception exception)
            {
                return new ExtendedWebResponse(HttpStatusCode.SeeOther, exception.Message);
            }
        }

        public void SetEndpoint(AmazonEndpoint amazonEndpoint)
        {
            this._endpoint = amazonEndpoint;
        }

        public void SetUserAgent(string userAgent)
        {
            this._userAgent = userAgent;
        }

        public ExtendedWebResponse Request(AmazonOperationBase amazonOperation)
        {
            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(amazonOperation);
                return SendRequest(requestUri);
            }
        }

        #region Operations

        public AmazonItemLookupOperation ItemLookupOperation(IList<string> articleNumbers, IList<AmazonResponseGroup> amazonResponseGroups)
        {
            var operation = new AmazonItemLookupOperation();
            operation.ResponseGroup(amazonResponseGroups);
            operation.Get(articleNumbers);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonItemSearchOperation ItemSearchOperation(string search, IList<AmazonResponseGroup> amazonResponseGroups, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All)
        {
            var operation = new AmazonItemSearchOperation();
            operation.ResponseGroup(amazonResponseGroups);
            operation.Keywords(search);
            operation.SearchIndex(amazonSearchIndex);
            operation.AssociateTag(this._associateTag);
            return operation;
        }

        public AmazonBrowseNodeLookupOperation BrowseNodeLookupOperation(long browseNodeId, IList<AmazonResponseGroup> amazonResponseGroups)
        {
            var operation = new AmazonBrowseNodeLookupOperation();
            operation.ResponseGroup(amazonResponseGroups);
            operation.BrowseNodeId(browseNodeId);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonCartCreateOperation CartCreateOperation(IList<AmazonCartItem> amazonCartItems)
        {
            var operation = new AmazonCartCreateOperation();
            operation.AssociateTag(this._associateTag);
            operation.AddArticles(amazonCartItems);
            return operation;
        }

        public AmazonCartAddOperation CartAddOperation(AmazonCartItem amazonCartItem, Cart cart)
        {
            var operation = new AmazonCartAddOperation();
            operation.AssociateTag(this._associateTag);
            operation.AddItemToCart(amazonCartItem, cart);
            return operation;

        }

        public AmazonCartGetOperation CartGetOperation(Cart cart)
        {
            var operation = new AmazonCartGetOperation();
            operation.AssociateTag(this._associateTag);
            operation.GetCart(cart);
            return operation;
        }

        public AmazonCartClearOperation CartClearOperation(Cart cart)
        {
            var operation = new AmazonCartClearOperation();
            operation.AssociateTag(this._associateTag);
            operation.ParameterDictionary.Add("CartId", cart.CartId);
            operation.ParameterDictionary.Add("HMAC", cart.HMAC);
            return operation;
        }

        #endregion

        #region Lookup

        /// <summary>
        /// ItemLookup
        /// </summary>
        /// <param name="articleNumber">ASIN, EAN, GTIN, ISBN</param>
        /// <param name="responseGroup"></param>
        /// <returns></returns>
        public AmazonItemResponse Lookup(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return this.Lookup(new string[1] { articleNumber }, new AmazonResponseGroup[1] { responseGroup });
        }

        public AmazonItemResponse Lookup(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return this.Lookup(articleNumbers, new AmazonResponseGroup[1] { responseGroup });
        }

        public AmazonItemResponse Lookup(string articleNumber, IList<AmazonResponseGroup> responseGroups)
        {
            return this.Lookup(new string[1] { articleNumber }, responseGroups);
        }

        public AmazonItemResponse Lookup(IList<string> articleNumbers, IList<AmazonResponseGroup> responseGroups)
        {
            var operation = this.ItemLookupOperation(articleNumbers, responseGroups);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<ItemLookupResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<ItemLookupErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        #endregion

        #region Search

        public AmazonItemResponse Search(string search, IList<AmazonResponseGroup> responseGroups, AmazonSearchIndex searchIndex = AmazonSearchIndex.All)
        {
            var operation = this.ItemSearchOperation(search, responseGroups, searchIndex);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<ItemSearchResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<ItemSearchErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        public AmazonItemResponse Search(string search, AmazonResponseGroup responseGroup, AmazonSearchIndex searchIndex = AmazonSearchIndex.All)
        {
            return Search(search, new AmazonResponseGroup[] { responseGroup }, searchIndex);
        }

        #endregion

        #region Cart

        public CartCreateResponse CartCreate(IList<AmazonCartItem> amazonCartItems)
        {
            var operation = this.CartCreateOperation(amazonCartItems);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<CartCreateResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<CartCreateErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        public CartAddResponse CartAdd(AmazonCartItem item, string cartId, string hmac)
        {
            var cart = new Cart { CartId = cartId, HMAC = hmac };
            var operation = this.CartAddOperation(item, cart);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<CartAddResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<CartAddErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        public CartGetResponse CartGet(string cartId, string hmac)
        {
            var cart = new Cart { CartId = cartId, HMAC = hmac };
            var operation = this.CartGetOperation(cart);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<CartGetResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<CartGetErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        public CartClearResponse CartClear(string cartId, string hmac)
        {
            var cart = new Cart { CartId = cartId, HMAC = hmac };
            var operation = this.CartClearOperation(cart);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<CartClearResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<CartClearErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        #endregion

        #region BrowseNode

        public BrowseNodeLookupResponse BrowseNodeLookup(long browseNodeId, IList<AmazonResponseGroup> responseGroups)
        {
            var operation = this.BrowseNodeLookupOperation(browseNodeId, responseGroups);

            var webResponse = this.Request(operation);
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                return XmlHelper.ParseXml<BrowseNodeLookupResponse>(webResponse.Content);
            }
            else
            {
                var errorResponse = XmlHelper.ParseXml<BrowseNodeLookupErrorResponse>(webResponse.Content);
                this.ErrorReceived?.Invoke(errorResponse);
            }

            return null;
        }

        #endregion
    }
}