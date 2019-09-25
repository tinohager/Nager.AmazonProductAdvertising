using System;

namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class ProductInfo
    {
        public DisplayValueItem<string> Color { get; set; }
        public ItemDimensions ItemDimensions { get; set; }
        public DisplayValueItem<int> UnitCount { get; set; }
        public DisplayValueItem<DateTime> ReleaseDate { get; set; }
        public DisplayValueItem<string> Size { get; set; }
        public DisplayValueItem<bool> IsAdultProduct { get; set; }
    }
}
