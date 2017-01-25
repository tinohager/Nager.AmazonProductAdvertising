#Nager.AmazonProductAdvertising

###Features
- [x] ItemLookup
- [x] ItemSeach
- [x] BrowseNodeLookup
- [x] Async support
- [ ] Card Operations (Add, Clear, Create, Get, Modify)

###Demo Shop
[Visit the Nager Amazon Product Advertising Shop](http://nagershop.azurewebsites.net)

###nuget
The package is available on [nuget](https://www.nuget.org/packages/Nager.AmazonProductAdvertising)
```
PM> install-package Nager.AmazonProductAdvertising
```

###Donation possibilities
If this project help you reduce time to develop, you can give me a beer :beer:
- [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.me/nagerat/25)
- BTC: 3PjuVRcAaKPv9yLLmrVUY9mqGngPDm3nPc (Bitcoin)

###Exampels

Please check is the AmazonEndpoint correct for your Country.
- Amazon Germany use AmazonEndpoint.DE
- Amazon Spain use AmazonEndpoint.ES
- Amazon United Kingdom use AmazonEndpoint.UK

#####Item Search
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```

#####Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Lookup("B00BYPW00I");
```

#####Multi Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Lookup(new string[] { "B00BYPW00I", "B004MKNBJG" });
```

#####CustomRequest with paging
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

#####Debugging
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
wrapper.XmlReceived += (xml) => { System.Diagnostics.Debug.WriteLine(xml); };
wrapper.ErrorReceived += (errorResonse) => { System.Diagnostics.Debug.WriteLine(errorResonse.Error.Message); };
var result = wrapper.Lookup(new string[] { "B00OQVZDJM", "B00ZV9RDKK" });
```

###Amazon Documentation
http://docs.aws.amazon.com/AWSECommerceService/latest/DG/CHAP_ApiReference.html
