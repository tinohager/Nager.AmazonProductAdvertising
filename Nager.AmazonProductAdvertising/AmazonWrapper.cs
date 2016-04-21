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

        public AmazonLookupOperation ItemLookupOperation(string asin, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            return ItemLookupOperation(asin, new[] { amazonResponseGroup });
        }

        public AmazonLookupOperation ItemLookupOperation(string asin, params AmazonResponseGroup[] amazonResponseGroup)
        {
            var operation = new AmazonLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Get(asin);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonLookupOperation ItemLookupOperation(IList<string> asins, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            return ItemLookupOperation(asins, new[] { amazonResponseGroup });
        }

        public AmazonLookupOperation ItemLookupOperation(IList<string> asins, params AmazonResponseGroup[] amazonResponseGroup)
        {
            var operation = new AmazonLookupOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Get(asins);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public AmazonSearchOperation ItemSearchOperation(string search, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            return ItemSearchOperation(search, amazonSearchIndex, new[] { amazonResponseGroup });
        }

        public AmazonSearchOperation ItemSearchOperation(string search, AmazonSearchIndex amazonSearchIndex, params AmazonResponseGroup[] amazonResponseGroup)
        {
            var operation = new AmazonSearchOperation();
            operation.ResponseGroup(amazonResponseGroup);
            operation.Keywords(search);
            operation.SearchIndex(amazonSearchIndex);
            operation.AssociateTag(this._associateTag);

            return operation;
        }

        public ItemLookupResponse Lookup(string asin, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return Lookup(asin, new[] { responseGroup });
        }

        public ItemLookupResponse Lookup(string asin, params AmazonResponseGroup[] responseGroup)
        {
            var requestParams = ItemLookupOperation(asin, responseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var xml = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemLookupResponse>(xml);
            }
        }

        public ItemLookupResponse Lookup(IList<string> asins, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            return Lookup(asins, new[] { responseGroup });
        }

        public ItemLookupResponse Lookup(IList<string> asins, params AmazonResponseGroup[] responseGroup)
        {
            var requestParams = ItemLookupOperation(asins, responseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var xml = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemLookupResponse>(xml);
            }
        }

        public ItemSearchResponse Search(string search, AmazonSearchIndex searchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemSearchOperation(search, searchIndex, amazonResponseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var xml = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemSearchResponse>(xml);
            }
        }

        public ItemSearchResponse Search(string search, AmazonSearchIndex searchIndex, params AmazonResponseGroup[] amazonResponseGroup)
        {
            var requestParams = ItemSearchOperation(search, searchIndex, amazonResponseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var xml = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemSearchResponse>(xml);
            }
        }

        public string Request(AmazonOperationBase amazonOperation)
        {
            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(amazonOperation);
                return SendRequest(requestUri);
            }
        }

        private string SendRequest(string uri)
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

                        return xml;
                    }
                }
            }
            catch (WebException exception)
            {
                return exception.Message;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}