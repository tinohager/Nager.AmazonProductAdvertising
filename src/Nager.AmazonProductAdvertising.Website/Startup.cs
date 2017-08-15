using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Nager.AmazonProductAdvertising.Website.Startup))]
namespace Nager.AmazonProductAdvertising.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
