using System;

namespace Nager.AmazonProductAdvertising.Model
{
    [Flags]
    public enum AmazonResponseGroup
    {
        Tracks, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        TopSellers, //Operations->BrowseNodeLookup
        Variations, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        VariationImages, //Operations->ItemLookup
        VariationMatrix, //Operations->ItemLookup, ItemSearch
        VariationOffers, //Operations->ItemLookup, ItemSearch
        VariationSummary,
        Medium, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        MostGifted, //Operations->BrowseNodeLookup
        MostWishedFor, //Operations->BrowseNodeLookup
        NewReleases,  //Operations->BrowseNodeLookup
        OfferFull, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        OfferListings, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Offers, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        OfferSummary, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        PromotionSummary, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        RelatedItems, //Operations->ItemLookup, ItemSearch
        Request,
        Reviews, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        SalesRank, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        SearchBins, //Operations->ItemSearch
        Similarities, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Small, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Accessories, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        AlternateVersions, //Operations->ItemLookup, ItemSearch
        BrowseNodeInfo, //Operations->BrowseNodeLookup
        BrowseNodes, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        //Cart, //Operations->CartAdd, CartCreate, CartModify, CartGet, CartClear
        //CartNewReleases, //Operations->CartAdd, CartCreate, CartModify, CartGet, CartClear
        //CartTopSellers, //Operations->CartAdd, CartCreate, CartModify, CartGet
        //CartSimilarities, //Operations->CartAdd, CartCreate, CartModify, CartGet
        EditorialReview, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Images, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        ItemAttributes, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        ItemIds, //Operations->SimilarityLookup, ItemLookup, ItemSearch
        Large, //Operations->SimilarityLookup, ItemLookup, ItemSearch
    }
}
