# Nager.AmazonProductAdvertising
Allow access to amazon product advertising API, you can search a product over the name or a keyword. Also it is possible to create a shopping cart. You can visit a demo [here](https://shop.nager.at)

### Support this project
Nager.AmazonProductAdvertising is free for you to use, but donations are very welcome. If Nager.AmazonProductAdvertising has ever helped you out on a project or saved you time, please consider sending a donation. :moneybag:

[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.me/nagerat/25)

### Features
- [x] ItemLookup
- [x] ItemSeach
- [x] BrowseNodeLookup
- [x] Cart Operations
  - [x] Create
  - [x] Add
  - [x] Get
  - [x] Clear
  - [ ] Modify
- [x] Async support
- [x] Support multiple Amazon endpoints

### Installation
The package is available on [nuget](https://www.nuget.org/packages/Nager.AmazonProductAdvertising)
```
PM> install-package Nager.AmazonProductAdvertising
```

### Usage

Please check the AmazonEndpoint is correct for your Country.
- Amazon Germany use AmazonEndpoint.DE
- Amazon Spain use AmazonEndpoint.ES
- Amazon United Kingdom use AmazonEndpoint.UK

##### Item Search
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```

##### Item Search with multiple response groups
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Small | AmazonResponseGroup.TopSellers);
```

##### Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Lookup("B00BYPW00I");
```

##### Multi Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Lookup(new string[] { "B00BYPW00I", "B004MKNBJG" });
```

##### Custom Item Search with paging
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var searchOperation = wrapper.ItemSearchOperation("canon eos", AmazonSearchIndex.Electronics);
searchOperation.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
searchOperation.Skip(2);
var xmlResponse = wrapper.Request(searchOperation);

var result = XmlHelper.ParseXml<ItemSearchResponse>(xmlResponse.Content);
```

##### Custom Item Search with minimum price
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var searchOperation = wrapper.ItemSearchOperation("canon eos", AmazonSearchIndex.Electronics);
searchOperation.MinPrice(200000); //2000 USD
var xmlResponse = wrapper.Request(searchOperation);

var result = XmlHelper.ParseXml<ItemSearchResponse>(xmlResponse.Content);
```

##### Debugging (find a problem)
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
wrapper.XmlReceived += (xml) => { System.Diagnostics.Debug.WriteLine(xml); };
wrapper.ErrorReceived += (errorResonse) => { System.Diagnostics.Debug.WriteLine(errorResonse.Error.Message); };
var result = wrapper.Lookup(new string[] { "B00OQVZDJM", "B00ZV9RDKK" });
```

##### Cart Create
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var items = new List<AmazonCartItem>();
items.Add(new AmazonCartItem("B00MH4QM1S"));
items.Add(new AmazonCartItem("B01EUHFAC6"));

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.CartCreate(items);
```

### Amazon Documentation
[API Reference](http://docs.aws.amazon.com/AWSECommerceService/latest/DG/CHAP_ApiReference.html)

### Alternative projects
| Language | Project |
| ------------- | ------------- |
| Phyton | [bottlenose](https://github.com/lionheart/bottlenose) |
