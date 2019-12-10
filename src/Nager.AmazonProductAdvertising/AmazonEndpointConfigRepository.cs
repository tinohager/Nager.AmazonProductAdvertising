using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising
{
    /// <summary>
    /// Amazon Endpoint Config Repository
    /// </summary>
    public class AmazonEndpointConfigRepository
    {
        private readonly Dictionary<AmazonEndpoint, AmazonEndpointConfig> _configs = new Dictionary<AmazonEndpoint, AmazonEndpointConfig>();

        /// <summary>
        /// Amazon Endpoint Config Repository
        /// </summary>
        public AmazonEndpointConfigRepository()
        {
            this._configs = new Dictionary<AmazonEndpoint, AmazonEndpointConfig>
            {
                { AmazonEndpoint.AU, new AmazonEndpointConfig { Host = "amazon.com.au", Region = "us-west-2" } },
                { AmazonEndpoint.BR, new AmazonEndpointConfig { Host = "amazon.com.br", Region = "us-east-1" } },
                { AmazonEndpoint.CA, new AmazonEndpointConfig { Host = "amazon.ca", Region = "us-east-1" } },
                { AmazonEndpoint.FR, new AmazonEndpointConfig { Host = "amazon.fr", Region = "eu-west-1" } },
                { AmazonEndpoint.DE, new AmazonEndpointConfig { Host = "amazon.de", Region = "eu-west-1" } },
                { AmazonEndpoint.IN, new AmazonEndpointConfig { Host = "amazon.in", Region = "eu-west-1" } },
                { AmazonEndpoint.IT, new AmazonEndpointConfig { Host = "amazon.it", Region = "eu-west-1" } },
                { AmazonEndpoint.JP, new AmazonEndpointConfig { Host = "amazon.co.jp", Region = "us-west-2" } },
                { AmazonEndpoint.MX, new AmazonEndpointConfig { Host = "amazon.com.mx", Region = "us-east-1" } },
                { AmazonEndpoint.ES, new AmazonEndpointConfig { Host = "amazon.es", Region = "eu-west-1" } },
                { AmazonEndpoint.TR, new AmazonEndpointConfig { Host = "amazon.com.tr", Region = "eu-west-1" } },
                { AmazonEndpoint.AE, new AmazonEndpointConfig { Host = "amazon.ae", Region = "eu-west-1" } },
                { AmazonEndpoint.UK, new AmazonEndpointConfig { Host = "amazon.co.uk", Region = "eu-west-1" } },
                { AmazonEndpoint.US, new AmazonEndpointConfig { Host = "amazon.com", Region = "us-east-1" } },
            };
        }

        /// <summary>
        /// Get Amazon Endpoint config
        /// </summary>
        /// <param name="amazonEndpoint"></param>
        /// <returns></returns>
        public AmazonEndpointConfig Get(AmazonEndpoint amazonEndpoint)
        {
            this._configs.TryGetValue(amazonEndpoint, out var config);
            return config;
        }
    }
}
