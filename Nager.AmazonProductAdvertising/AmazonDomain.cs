using Nager.AmazonProductAdvertising.Model;

namespace Nager.AmazonProductAdvertising
{
    internal static class AmazonDomain
    {
        internal static string GetDomain(AmazonEndpoint amazonEndpoint)
        {
            switch (amazonEndpoint)
            {
                case AmazonEndpoint.BR:
                    return "amazon.com.br";
                case AmazonEndpoint.CA:
                    return "amazon.ca";
                case AmazonEndpoint.CN:
                    return "amazon.cn";
                case AmazonEndpoint.DE:
                    return "amazon.de";
                case AmazonEndpoint.ES:
                    return "amazon.es";
                case AmazonEndpoint.FR:
                    return "amazon.fr";
                case AmazonEndpoint.IN:
                    return "amazon.in";
                case AmazonEndpoint.IT:
                    return "amazon.it";
                case AmazonEndpoint.JP:
                    return "amazon.co.jp";
                case AmazonEndpoint.MX:
                    return "amazon.com.mx";
                case AmazonEndpoint.UK:
                    return "amazon.co.uk";
                case AmazonEndpoint.US:
                    return "amazon.com";
                default:
                    return "amazon.com";
            }
        }
    }
}