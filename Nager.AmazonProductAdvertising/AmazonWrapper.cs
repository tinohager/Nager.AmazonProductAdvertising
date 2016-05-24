using Nager.AmazonProductAdvertising.Model;
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

        public void SetEndpoint(AmazonEndpoint amazonEndpoint)
        {
            this._endpoint = amazonEndpoint;
        }

        public void SetUserAgent(string userAgent)
        {  
            this._userAgent = userAgent;  
        }

        public AmazonItemLookupOperation ItemLookupOperation(IList<string> articleNumbers, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var operation = new AmazonItemLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Get(articleNumbers);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonItemSearchOperation ItemSearchOperation(string search, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var operation = new AmazonItemSearchOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Keywords(search);
            operation.SearchIndex(amazonSearchIndex);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonBrowseNodeLookupOperation BrowseNodeLookupOperation(int browseNodeId, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.BrowseNodeInfo)
        {
            var operation = new AmazonBrowseNodeLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.BrowseNodeId(browseNodeId);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        /// <summary>
        /// ItemLookup
        /// </summary>
        /// <param name="articleNumber">ASIN, EAN, GTIN, ISBN</param>
        /// <param name="responseGroup"></param>
        /// <returns></returns>
        public ItemLookupResponse Lookup(string articleNumber, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return this.Lookup(new string[1] { articleNumber }, responseGroup);
        }

        public ItemLookupResponse Lookup(IList<string> articleNumbers, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemLookupOperation(articleNumbers, responseGroup);

            var webResponse = this.Request(requestParams);
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

        public ItemSearchResponse Search(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemSearchOperation(search, searchIndex, responseGroup);

            var webResponse = this.Request(requestParams);
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

        public BrowseNodeLookupResponse BrowseNodeLookup(int browseNodeId, AmazonResponseGroup responseGroup = AmazonResponseGroup.BrowseNodeInfo)
        {
            var requestParams = BrowseNodeLookupOperation(browseNodeId, responseGroup);

            var webResponse = this.Request(requestParams);
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

        public ExtendedWebResponse Request(AmazonOperationBase amazonOperation)
        {
            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(amazonOperation);
                return SendRequest(requestUri);
            }
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
    }
}