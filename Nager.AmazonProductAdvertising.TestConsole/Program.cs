using Nager.AmazonProductAdvertising.Model;
using System;

namespace Nager.AmazonProductAdvertising.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Please insert accesskey");
            var accessKey = Console.ReadLine();
            Console.WriteLine("Please insert secretkey");
            var secretKey = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            var authentication = new AmazonAuthentication();            
            authentication.AccessKey = accessKey;
            authentication.SecretKey = secretKey;

            ItemLookupRequest(authentication);
            ItemSearchRequest(authentication);
            CustomItemSearchRequest(authentication);
            BrowseNodeLookupRequest(authentication);

            Console.ReadLine();
        }

        static void ItemLookupRequest(AmazonAuthentication authentication)
        {
            Console.WriteLine("ItemLookup");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Lookup("B007KKKJYK");

            Console.WriteLine("{0}", result.Items.Item[0].ItemAttributes.Title);

            Console.WriteLine("Multi Lookup");
            Console.WriteLine("------------------------------------------");

            var result2 = wrapper.Lookup(new string[] { "B007KKKJYK", "B004MKNBJG" });
            foreach (var item in result2.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("------------------------------------------");
        }

        static void ItemSearchRequest(AmazonAuthentication authentication)
        {
            Console.WriteLine("ItemSearch");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);

            foreach(var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);

            Console.WriteLine("------------------------------------------");
        }

        static void CustomItemSearchRequest(AmazonAuthentication authentication)
        {
            Console.WriteLine("Search with skip and sort");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var searchOperation = wrapper.ItemSearchOperation("canon eos", AmazonSearchIndex.Electronics);
            searchOperation.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
            searchOperation.Skip(2);
            var webResponse = wrapper.Request(searchOperation);

            var result = XmlHelper.ParseXml<ItemSearchResponse>(webResponse.Content);

            foreach (var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);

            Console.WriteLine("------------------------------------------");
        }

        static void BrowseNodeLookupRequest(AmazonAuthentication authentication)
        {
            //http://docs.aws.amazon.com/AWSECommerceService/latest/DG/localevalues.html

            Console.WriteLine("BrowseNodeLookup");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.BrowseNodeLookup(569604, AmazonResponseGroup.Large);

            foreach (var item in result.BrowseNodes.BrowseNode.Children)
            {
                Console.WriteLine(item.BrowseNodeId);
            }

            //Console.WriteLine("found {0} items", result.Items.Item.Length);

            Console.WriteLine("------------------------------------------");
        }
    }
}
