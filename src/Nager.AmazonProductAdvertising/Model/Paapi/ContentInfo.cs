using System;

namespace Nager.AmazonProductAdvertising.Model.Paapi
{
    public class ContentInfo
    {
        public Languages Languages { get; set; }
        public DisplayValueItem<int> PagesCount { get; set; }
        public DisplayValueItem<DateTime> PublicationDate { get; set; }
        public DisplayValueItem<string> Edition { get; set; }
    }
}
