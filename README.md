# Important
Amazon rolled out a new API version `paapi5`. Only `Nager.AmazonProductAdvertising` Version `2.0.0` or above support new `paapi5`.
On **31 October 2019** old API will be shut down. [Read more](https://dev.to/skatkov/new-amazon-product-advertising-api-is-here-and-you-need-to-migrate-fast-3545)


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

##### Item Search
```cs
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var result = await client.SearchItemsAsync("canon eos");
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

