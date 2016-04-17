Nager.AmazonProductAdvertising
==========

#####nuget
install-package Nager.AmazonProductAdvertising


#####Example Search
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```

#####Example Lookup
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.DE, "nagerat-21");
var result = wrapper.Lookup("B00BYPW00I");
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