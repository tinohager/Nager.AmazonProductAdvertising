using System.Net;

namespace Nager.AmazonProductAdvertising.Model
{
    public class ExtendedWebResponse
    {
        public HttpStatusCode StatusCode;
        public string Content;

        public ExtendedWebResponse(HttpStatusCode statusCode, string content)
        {
            this.StatusCode = statusCode;
            this.Content = content;
        }
    }
}