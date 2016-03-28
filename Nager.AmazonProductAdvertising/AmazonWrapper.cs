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

        public AmazonWrapper(AmazonAuthentication amazonAuthentication)
        {
            this._authentication = amazonAuthentication;
        }

        public IDictionary<string, string> ItemLookupOperation(string asin, string associateTag, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestArgs = new Dictionary<string, string>
            {
                { "Operation", "ItemLookup" },
                { "ResponseGroup", amazonResponseGroup.ToString() },
                { "ItemId", asin },
                { "AssociateTag", associateTag },
            };

            return requestArgs;
        }

        public IDictionary<string, string> ItemSearchOperation(string search, string associateTag, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestArgs = new Dictionary<string, string>
            {
                { "Operation", "ItemSearch" },
                { "ResponseGroup", amazonResponseGroup.ToString() },
                { "Keywords", search },
                { "SearchIndex", amazonSearchIndex.ToString() },
                { "AssociateTag", associateTag },
            };

            return requestArgs;
        }

        public ItemLookupResponse Lookup(string asin, AmazonEndpoint amazonEndpoint, string associateTag, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemLookupOperation(asin, associateTag, amazonResponseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, amazonEndpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var result = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemLookupResponse>(result);
            }
        }

        public ItemSearchResponse Search(string search, AmazonEndpoint amazonEndpoint, string associateTag, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemSearchOperation(search, associateTag, amazonSearchIndex, amazonResponseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, amazonEndpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var result = SendRequest(requestUri);
                return XmlHelper.ParseXml<ItemSearchResponse>(result);
            }
        }

        public string Request(IDictionary<string, string> requestParams, AmazonEndpoint amazonEndpoint)
        {
            using (var amazonSign = new AmazonSign(this._authentication, amazonEndpoint))
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
                    using (var sr = new StreamReader(response.GetResponseStream()))
                    {
                        return sr.ReadToEnd();
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