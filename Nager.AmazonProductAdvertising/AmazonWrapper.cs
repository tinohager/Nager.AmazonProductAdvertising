using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising
{
    public class AmazonWrapper
    {
        private AmazonAuthentication _authentication;

        public AmazonWrapper(AmazonAuthentication amazonAuthentication)
        {
            this._authentication = amazonAuthentication;
        }

        private Dictionary<string, string> ItemLookupOperation(string asin, string associateTag, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
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

        private Dictionary<string, string> ItemSearchOperation(string search, string associateTag, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestArgs = new Dictionary<string, string>
            {
                { "Operation", "ItemSearch" },
                { "ResponseGroup", amazonResponseGroup.ToString() },
                { "Availability", "Available" },
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
                return ParseXml<ItemLookupResponse>(result);
            }
        }

        public ItemSearchResponse Search(string search, AmazonEndpoint amazonEndpoint, string associateTag, AmazonSearchIndex amazonSearchIndex = AmazonSearchIndex.All, AmazonResponseGroup amazonResponseGroup = AmazonResponseGroup.Large)
        {
            var requestParams = ItemSearchOperation(search, associateTag, amazonSearchIndex, amazonResponseGroup);

            using (var amazonSign = new AmazonSign(this._authentication, amazonEndpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                var result = SendRequest(requestUri);
                return ParseXml<ItemSearchResponse>(result);
            }
        }

        public string Request(Dictionary<string, string> requestParams, AmazonEndpoint amazonEndpoint)
        {
            using (var amazonSign = new AmazonSign(this._authentication, amazonEndpoint))
            {
                var requestUri = amazonSign.Sign(requestParams);
                return SendRequest(requestUri);
            }
        }

        private T ParseXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(xml))
            {
                return (T)(serializer.Deserialize(reader));
            }
        }

        private string SendRequest(string uri)
        {
            var request = WebRequest.Create(uri);

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