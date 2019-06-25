Thank you for using the Nager.AmazonProductAdvertising package (https://github.com/tinohager/Nager.AmazonProductAdvertising)
----------------------------------------------------------------
Please support this project with the award of a GitHub Star (★)


Examples:
----------------------------------------------------------------

//Item Search
var authentication = new AmazonAuthentication();
authentication.AccessKey = "accesskey";
authentication.SecretKey = "secretkey";

var wrapper = new AmazonWrapper(authentication, AmazonEndpoint.US, "nager-20");
var result = wrapper.Search("canon eos", AmazonSearchIndex.Electronics, AmazonResponseGroup.Large);
