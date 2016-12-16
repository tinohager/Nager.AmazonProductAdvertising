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

            //ItemLookupRequest(authentication);
            //ItemSearchRequest(authentication);
            //CustomItemSearchRequest1(authentication);
            CustomItemSearchRequest2(authentication);
            BrowseNodeLookupRequest1(authentication);
            BrowseNodeLookupRequest2(authentication);

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

        static void CustomItemSearchRequest1(AmazonAuthentication authentication)
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

        static void CustomItemSearchRequest2(AmazonAuthentication authentication)
        {
            Console.WriteLine("Search with BrowseNode");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var customOperation = new AmazonOperationBase();
            customOperation.ParameterDictionary.Add("Operation", "ItemSearch");
            customOperation.ParameterDictionary.Add("Keywords", "tall");
            customOperation.ParameterDictionary.Add("SearchIndex", "Apparel");
            customOperation.ParameterDictionary.Add("BrowseNode", "78193031");
            customOperation.ParameterDictionary.Add("AssociateTag", "nagerat-21");


            var webResponse = wrapper.Request(customOperation);

            var result = XmlHelper.ParseXml<ItemSearchResponse>(webResponse.Content);

            foreach (var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);

            Console.WriteLine("------------------------------------------");
        }

        static void BrowseNodeLookupRequest1(AmazonAuthentication authentication)
        {
            Console.WriteLine("BrowseNodeLookup - TopSellers");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.BrowseNodeLookup(78193031, AmazonResponseGroup.TopSellers);

            foreach (var item in result.BrowseNodes.BrowseNode.TopSellers.TopSeller)
            {
                Console.WriteLine("{0} {1}", item.ASIN, item.Title);
            }

            foreach (var item in result.BrowseNodes.BrowseNode.TopItemSet.TopItem)
            {
                Console.WriteLine("{0} {1} {2}", item.ASIN, item.ProductGroup, item.Title);
            }

            Console.WriteLine("------------------------------------------");
        }

        static void BrowseNodeLookupRequest2(AmazonAuthentication authentication)
        {
            Console.WriteLine("BrowseNodeLookup - BrowseNodes");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.BrowseNodeLookup(78193031, AmazonResponseGroup.BrowseNodeInfo);

            foreach (var item in result.BrowseNodes.BrowseNode.Children)
            {
                Console.WriteLine(item.BrowseNodeId);
            }

            Console.WriteLine("------------------------------------------");
        }
    }
}
