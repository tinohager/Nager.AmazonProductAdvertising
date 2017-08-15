using System;

namespace Nager.AmazonProductAdvertising.TestConsole
{
    public static class LookupCheck
    {
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
    }
}
