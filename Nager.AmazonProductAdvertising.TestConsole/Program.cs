using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Extension;
using System;

namespace Nager.AmazonProductAdvertising.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert accesskey");
            var accessKey = Console.ReadLine();
            Console.WriteLine("Please insert secretkey");
            var secretKey = Console.ReadLine();

            var authentication = new AmazonAuthentication();            
            authentication.AccessKey = accessKey;
            authentication.SecretKey = secretKey;

            SearchRequest(authentication);
            LookupRequest(authentication);
            CustomRequest(authentication);

            Console.ReadLine();
        }

        static void SearchRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);

            foreach(var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);
        }

        static void LookupRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Lookup("B007KKKJYK");

            Console.WriteLine("{0}", result.Items.Item[0].ItemAttributes.Title);
        }

        static void CustomRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var searchQuery = wrapper.ItemSearchOperation("canon eos", AmazonSearchIndex.Electronics);
            searchQuery = searchQuery.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
            searchQuery = searchQuery.ItemPage(11);
            var xml = wrapper.Request(searchQuery);

            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);

            foreach (var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);
        }
    }
}
