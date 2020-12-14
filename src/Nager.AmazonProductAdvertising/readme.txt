Thank you for using the Nager.AmazonProductAdvertising package (https://github.com/nager/Nager.AmazonProductAdvertising)
----------------------------------------------------------------
Please support this project with the awarding of a GitHub Star (★)
The update to the new api was very intensive and I would be happy about a sponsoring. :)

Examples:
----------------------------------------------------------------

//Item Search
var authentication = new AmazonAuthentication("accesskey", "secretkey");
var client = new AmazonProductAdvertisingClient(authentication, AmazonEndpoint.US, "nager-20");
var result = await client.SearchItemsAsync("canon eos");
