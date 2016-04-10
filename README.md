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
var searchQuery = wrapper.ItemSearchOperation("canon eos", , AmazonSearchIndex.Electronics);
searchQuery = searchQuery.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
searchQuery = searchQuery.ItemPage(2); //pagination
var xml = wrapper.Request(searchQuery);

var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
```