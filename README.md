Nager.AmazonProductAdvertising
==========

#####Features
* ItemLookup
* ItemSeach
* BrowseNodeLookup
* Async support

#####Demo Website (For donation shop over this website)
http://amazonshop.azurewebsites.net/

#####nuget
The package is available on nuget
https://www.nuget.org/packages/Nager.AmazonProductAdvertising/
```
install-package Nager.AmazonProductAdvertising
```


#####Example Item Search
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```

#####Example Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var result = wrapper.Lookup("B00BYPW00I");
```

#####Example Multi Item Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var result = wrapper.Lookup(new string[] { "B00BYPW00I", "B004MKNBJG" });
```

#####Example CustomRequest
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var searchOperation = wrapper.ItemSearchOperation("canon eos", AmazonSearchIndex.Electronics);
searchOperation.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
searchOperation.Skip(2);
var xml = wrapper.Request(searchQuery);

var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
```