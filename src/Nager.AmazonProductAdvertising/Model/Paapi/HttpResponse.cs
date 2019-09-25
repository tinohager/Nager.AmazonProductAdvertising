using System.Net;

namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class HttpResponse
    {
        public bool Successful { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public string Content { get; set; }
    }
}
