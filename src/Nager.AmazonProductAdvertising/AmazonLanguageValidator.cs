using System.Collections.Generic;
using System.Linq;
using System;
namespace Nager.AmazonProductAdvertising
{
    public class AmazonLanguageValidator
    {
       private readonly Dictionary<string, AmazonEndpoint[]> _languages;

        /// <summary>
        /// Amazon Valid Languages Validator
        /// </summary>
        public AmazonLanguageValidator()
        {
            this._languages = new Dictionary<string, AmazonEndpoint[]>
            {
                { "cs_CZ", new [] { AmazonEndpoint.DE } },
                { "de_DE", new [] { AmazonEndpoint.DE, AmazonEndpoint.US } },
                { "en_GB", new [] { AmazonEndpoint.DE, AmazonEndpoint.UK } },
                { "nl_NL", new [] { AmazonEndpoint.DE, AmazonEndpoint.NL } },
                { "pl_PL", new [] { AmazonEndpoint.DE } },
                { "tr_TR", new [] { AmazonEndpoint.DE, AmazonEndpoint.TR } },
                { "en_AU", new [] { AmazonEndpoint.AU } },
                { "pt_BR", new [] { AmazonEndpoint.BR, AmazonEndpoint.US } },
                { "en_CA", new [] { AmazonEndpoint.CA } },
                { "fr_CA", new [] { AmazonEndpoint.CA } },
                { "fr_FR", new [] { AmazonEndpoint.FR } },
                { "en_IN", new [] { AmazonEndpoint.IN } },
                { "it_IT", new [] { AmazonEndpoint.IT } },
                { "ja_JP", new [] { AmazonEndpoint.JP } },
                { "zh_CN", new [] { AmazonEndpoint.JP, AmazonEndpoint.US } },
                { "es_MX", new [] { AmazonEndpoint.MX } },
                { "en_SG", new [] { AmazonEndpoint.SG } },
                { "es_ES", new [] { AmazonEndpoint.ES } },
                { "en_AE", new [] { AmazonEndpoint.AE } },
                { "ar_AE", new [] { AmazonEndpoint.AE } },
                { "en_US", new [] { AmazonEndpoint.JP, AmazonEndpoint.US } },
                { "es_US", new [] { AmazonEndpoint.US } },
                { "ko_KR", new [] { AmazonEndpoint.US } },
                { "zh_TW", new [] { AmazonEndpoint.US } },
            };
        }

        /// <summary>
        /// Check languages are valid for endpoint
        /// See https://webservices.amazon.com/paapi5/documentation/locale-reference.html for more information.
        /// </summary>
        /// <param name="languages"></param>
        /// <param name="endpoint"></param>
        /// <returns></returns>
        public bool IsLanguageValid(string[] languages, AmazonEndpoint endpoint)
        {
            if (languages == null)
            {
                return false;
            }

            var items = this._languages.Count(language => 
                languages.Any(x => language.Key.Equals(x, System.StringComparison.OrdinalIgnoreCase) && 
                language.Value.Any(y => y.Equals(endpoint)))
            );

            return items == languages.Length;
        }
    }
}
