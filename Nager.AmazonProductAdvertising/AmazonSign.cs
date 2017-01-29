/**********************************************************************************************
 * Copyright 2009 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use this file 
 * except in compliance with the License. A copy of the License is located at
 *
 *       http://aws.amazon.com/apache2.0/
 *
 * or in the "LICENSE.txt" file accompanying this file. This file is distributed on an "AS IS"
 * BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under the License. 
 *
 * ********************************************************************************************
 *
 *  Amazon Product Advertising API
 *  Signed Requests Sample Code
 *
 *  API Version: 2009-03-31
 *
 */

using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Nager.AmazonProductAdvertising
{
    internal class AmazonSign : IDisposable
    {
        private string endPoint;
        private string akid;
        private HMAC signer;

        private const string REQUEST_URI = "/onca/xml";
        private const string REQUEST_METHOD = "GET";
        private static readonly string[] UriRfc3986CharsToEscape = new[] { "!", "*", "'", "(", ")" };

        public AmazonSign(AmazonAuthentication amazonAuthentication, AmazonEndpoint amazonEndpoint)
        {
            var domain = AmazonDomain.GetDomain(amazonEndpoint);

            this.endPoint = $"webservices.{domain}";
            this.akid = amazonAuthentication.AccessKey;
            var secret = Encoding.UTF8.GetBytes(amazonAuthentication.SecretKey);
            this.signer = new HMACSHA256(secret);
        }

        public void Dispose()
        {
            if (this.signer == null)
            {
                return;
            }

            this.signer.Dispose();
        }

        public string Sign(AmazonOperationBase amazonOperation)
        {
            return this.Sign(amazonOperation.ParameterDictionary);
        }

        /*
         * Sign a request in the form of a Dictionary of name-value pairs.
         * 
         * This method returns a complete URL to use. Modifying the returned URL
         * in any way invalidates the signature and Amazon will reject the requests.
         */
        public string Sign(IDictionary<string, string> request)
        {
            request.Add("AWSAccessKeyId", this.akid);
            request.Add("Timestamp", DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"));

            request = this.GetRequestArguments(request);

            var canonicalQS = this.ConstructCanonicalQueryString(request);

            var signHeader = string.Format("{0}\n{1}\n{2}\n{3}", REQUEST_METHOD, this.endPoint, REQUEST_URI, canonicalQS);
            var signHeaderBytes = Encoding.UTF8.GetBytes(signHeader);

            // Compute the signature and convert to Base64.
            var sigBytes = signer.ComputeHash(signHeaderBytes);
            var signature = Convert.ToBase64String(sigBytes);

            // now construct the complete URL and return to caller.
            var sb = new StringBuilder();
            sb.Append("http://");
            sb.Append(this.endPoint);
            sb.Append(REQUEST_URI);
            sb.AppendFormat("?{0}", canonicalQS);
            sb.AppendFormat("&Signature={0}", this.EscapeUriDataStringRfc3986(signature));

            return sb.ToString();
        }

        private IDictionary<string, string> GetRequestArguments(IDictionary<string, string> operationArguments)
        {
            var requestArgs = new Dictionary<string, string>();
            requestArgs["Service"] = "AWSECommerceService";
            requestArgs["Version"] = "2009-03-31";
            foreach (var key in operationArguments.Keys)
            {
                requestArgs[key] = operationArguments[key];
            }
            return requestArgs;
        }

        public string EscapeUriDataStringRfc3986(string value)
        {
            // Start with RFC 2396 escaping by calling the .NET method to do the work.
            // This MAY sometimes exhibit RFC 3986 behavior (according to the documentation).
            // If it does, the escaping we do that follows it will be a no-op since the
            // characters we search for to replace can't possibly exist in the string.

            var sb = new StringBuilder(Uri.EscapeDataString(value));

            // Upgrade the escaping to RFC 3986, if necessary.
            for (var i = 0; i < UriRfc3986CharsToEscape.Length; i++)
            {
                sb.Replace(UriRfc3986CharsToEscape[i], Uri.HexEscape(UriRfc3986CharsToEscape[i][0]));
            }

            // Return the fully-RFC3986-escaped string.
            return sb.ToString();
        }

        private string ConstructCanonicalQueryString(IDictionary<string, string> request)
        {
            if (request.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            foreach (var kvp in request.OrderBy(o => o.Key, StringComparer.Ordinal))
            {
                sb.Append(this.EscapeUriDataStringRfc3986(kvp.Key));
                sb.Append("=");
                sb.Append(this.EscapeUriDataStringRfc3986(kvp.Value));
                sb.Append("&");
            }

            return sb.ToString().TrimEnd('&');
        }
    }
}