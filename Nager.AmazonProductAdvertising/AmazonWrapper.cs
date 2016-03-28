using Nager.AmazonProductAdvertising.Extension;
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

        public IDictionary<string, string> ItemLookupOperation(string asin, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestArgs = new Dictionary<string, string>
            {
                { "Operation", "ItemLookup" },
                { "ResponseGroup", amazonResponseGroup.ToString() },
                { "ItemId", asin },
                { "AssociateTag", this._associateTag },
            };

            return requestArgs;
        }

        public IDictionary<string, string> ItemSearchOperation(string search, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestArgs = new Dictionary<string, string>
            {
                { "Operation", "ItemSearch" },
                { "ResponseGroup", amazonResponseGroup.ToString() },
                { "Keywords", search },
                { "SearchIndex", amazonSearchIndex.ToString() },
                { "AssociateTag", this._associateTag },
            };

            return requestArgs;
        }

        public ItemLookupResponse Lookup(string asin, AmazonResponseGroup responseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemLookupOperation(asin, responseGroup);

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

        public string Request(IDictionary<string, string> requestParams)
        {
            using (var amazonSign = new AmazonSign(this._authentication, this._endpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                return SendRequest(requestUri);
            }
        }

        private string SendRequest(string uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.UserAgent = "Nager.AmazonProductAdvertising";

            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var xml = streamReader.ReadToEnd();
                        if (this.XmlReceived != null)
                        {
                            this.XmlReceived(xml);
                        }

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