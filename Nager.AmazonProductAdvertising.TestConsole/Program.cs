using Nager.AmazonProductAdvertising.Model;
using Nager.AmazonProductAdvertising.Operation;
using System;
using System.Collections.Generic;

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

            //LookupCheck.ItemLookupRequest(authentication);
            ItemSearchRequest1(authentication);
            ItemSearchRequest2(authentication);
            //CustomItemSearchRequest1(authentication);
            //CustomItemSearchRequest2(authentication);
            //BrowseNodeLookupRequest1(authentication);
            //BrowseNodeLookupRequest2(authentication);
            //BrowseNodeLookupRequest2(authentication);
            //CreateCart1(authentication);

            Console.ReadLine();
        }

        static void ItemSearchRequest1(AmazonAuthentication authentication)
        {
            Console.WriteLine("ItemSearch");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Small | AmazonResponseGroup.TopSellers);

            foreach (var item in result.Items.Item)
            {
                Console.WriteLine(item.ItemAttributes.Title);
            }

            Console.WriteLine("found {0} items", result.Items.Item.Length);

            Console.WriteLine("------------------------------------------");
        }

        static void ItemSearchRequest2(AmazonAuthentication authentication)
        {
            Console.WriteLine("ItemSearch");
            Console.WriteLine("------------------------------------------");

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Small | AmazonResponseGroup.Accessories);

            foreach (var item in result.Items.Item)
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

        static void CreateCart1(AmazonAuthentication authentication)
        {
            Console.WriteLine("CreateCart1");
            Console.WriteLine("------------------------------------------");

            var items = new List<AmazonCartItem>();
            items.Add(new AmazonCartItem("B00MH4QM1S"));
            items.Add(new AmazonCartItem("B01EUHFAC6"));

            var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE);
            var result = wrapper.CartCreate(items);

            Console.WriteLine("------------------------------------------");
        }
    }
}
