# Nager.AmazonProductAdvertising
Allow access to amazon product advertising API (`paapi5`), you can search a product over the name or a keyword. You can visit a demo [here](https://shop.nager.at)


### Installation
The package is available on [nuget](https://www.nuget.org/packages/Nager.AmazonProductAdvertising)
```
PM> install-package Nager.AmazonProductAdvertising
```

### Usage

Please check the AmazonEndpoint is correct for your Country.
- Amazon Germany use `AmazonEndpoint.DE`
- Amazon Spain use `AmazonEndpoint.ES`
- Amazon United Kingdom use `AmazonEndpoint.UK`

##### Item Search (simple)
```cs
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var result = await client.SearchItemsAsync("canon eos");
```

##### Item Search (advanced)
```cs
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var searchRequest = new SearchRequest
{
    Keywords = "canon eos",
    ItemPage = 2,
    Resources = new []
    {
        //You can found all available Resources in the documentation
        //https://webservices.amazon.com/paapi5/documentation/search-items.html#resources-parameter
        "Images.Primary.Large",
        "ItemInfo.Title",
        "ItemInfo.Features"
    }
};
var result = await client.SearchItemsAsync(searchRequest);
```

##### Item Lookup
```cs
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var result = await client.GetItemsAsync("B00BYPW00I");
```

##### Multi Item Lookup
```cs
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var result = client.GetItemsAsync(new string[] { "B00BYPW00I", "B004MKNBJG" });
```

### Amazon Documentation
- [API Reference](https://webservices.amazon.com/paapi5/documentation/)
- [Product Advertising API Scratchpad](https://webservices.amazon.com/paapi5/documentation/play-around-using-scratchpad.html)

