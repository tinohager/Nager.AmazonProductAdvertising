namespace Nager.AmazonProductAdvertising.Model
{
    public enum ArticleNumberType
    {
        ASIN, //Amazon Standard Identification Number
        GTIN, //Global Trade Item Number (previously European Article Number)
        ISBN, //International Standard Book Number (US only, when search index is Books)
        SKU, //Stock keeping unit
        UPC, //UPC is not valid in the CA locale.
    }
}