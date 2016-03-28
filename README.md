Nager.AmazonProductAdvertising
==========

#####nuget
install-package Nager.AmazonProductAdvertising


#####Example Search
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication);
var result = wrapper.Search("canon eos", AmazonEndpoint.DE, "nagerat-21", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```

#####Example CustomRequest
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication);
var searchQuery = wrapper.ItemSearchOperation("canon eos", "nagerat-21", AmazonSearchIndex.Electronics);
searchQuery.Sort(AmazonSearchSort.Price, AmazonSearchSortOrder.Descending);
var xml = wrapper.Request(searchQuery, AmazonEndpoint.DE);

var result = XmlHelper.ParseXml<ItemSearchResponse>(xml);
```