using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Nager.AmazonProductAdvertising
{
    public class AmazonWrapper
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


    public AmazonItemLookupOperation ItemLookupOperation(string asin, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var operation = new AmazonItemLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Get(asin);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonItemLookupOperation ItemLookupOperation(IList<string> asins, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var operation = new AmazonItemLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Get(asins);
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

        public ItemLookupResponse Lookup(string asin, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return this.Lookup(new string[1] { asin }, responseGroup);
        }

        public ItemLookupResponse Lookup(IList<string> asins, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemLookupOperation(asins, responseGroup);

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

        public ItemSearchResponse Search(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemSearchOperation(search, searchIndex, amazonResponseGroup);

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