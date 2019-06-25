using System;

namespace Nager.AmazonProductAdvertising.Model
{
    [Flags]
    public enum AmazonResponseGroup : long
    {
        Tracks = 1, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        TopSellers = 2, //Operations->BrowseNodeLookup
        Variations = 4, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        VariationImages = 8, //Operations->ItemLookup
        VariationMatrix = 16, //Operations->ItemLookup, ItemSearch
        VariationOffers = 32, //Operations->ItemLookup, ItemSearch
        VariationSummary = 64,
        Medium = 128, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        MostGifted = 256, //Operations->BrowseNodeLookup
        MostWishedFor = 512, //Operations->BrowseNodeLookup
        NewReleases = 1024,  //Operations->BrowseNodeLookup
        OfferFull = 2048, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        OfferListings = 4096, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Offers = 8192, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        OfferSummary = 16384, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        PromotionSummary = 32768, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        RelatedItems = 65536, //Operations->ItemLookup, ItemSearch
        Request = 131072,
        Reviews = 262144, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        SalesRank = 524288, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        SearchBins = 1048576, //Operations->ItemSearch
        Similarities = 2097152, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Small = 4194304, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Accessories = 8388608, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        AlternateVersions = 16777216, //Operations->ItemLookup, ItemSearch
        BrowseNodeInfo = 33554432, //Operations->BrowseNodeLookup
        BrowseNodes = 67108864, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        //Cart, //Operations->CartAdd, CartCreate, CartModify, CartGet, CartClear
        //CartNewReleases, //Operations->CartAdd, CartCreate, CartModify, CartGet, CartClear
        //CartTopSellers, //Operations->CartAdd, CartCreate, CartModify, CartGet
        //CartSimilarities, //Operations->CartAdd, CartCreate, CartModify, CartGet
        EditorialReview = 134217728, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Images = 268435456, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        ItemAttributes = 536870912, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        ItemIds = 1073741824, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Large = 2147483648, //Operations->SimilarityLookup, ItemLookup, ItemSearch
    }
}
