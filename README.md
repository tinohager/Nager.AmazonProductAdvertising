Nager.AmazonProductAdvertising
==========

#####nuget
install-package Nager.AmazonProductAdvertising


#####Example
```cs
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication);
var result = wrapper.Search("canon eos", AmazonEndpoint.DE, "nagerat-21", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
```