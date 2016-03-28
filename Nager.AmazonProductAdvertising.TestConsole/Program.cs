using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Extension;
using System;

namespace Nager.AmazonProductAdvertising.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var authentication = new AmazonAuthentication();
            authentication.AccessKey = "accesskey";
            authentication.SecretKey = "secretkey";

            SearchRequest(authentication);
            LookupRequest(authentication);
            CustomRequest(authentication);

            Console.ReadLine();
        }

        static void SearchRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication);
            var result = wrapper.Search("canon eos", AmazonEndpoint.DE, "nagerat-21", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);

            foreach(var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);
        }

        static void LookupRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication);
            var result = wrapper.Lookup("B007KKKJYK", AmazonEndpoint.DE, "nagerat-21");

            Console.WriteLine("{0}", result.Items.Item[0].ItemAttributes.Title);
        }

        static void CustomRequest(AmazonAuthentication authentication)
        {
            var wrapper = new AmazonWrapper(authentication);
            var searchQuery = wrapper.ItemSearchOperation("canon eos", "nagerat-21", AmazonSearchIndex.Electronics);
            searchQuery.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
            var xml = wrapper.Request(searchQuery, AmazonEndpoint.DE);

            var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);

            foreach (var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);
        }
    }
}
