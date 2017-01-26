using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    public class ImageSet
    {
        public Image SwatchImage { get; set; }
        public Image SmallImage { get; set; }
        public Image ThumbnailImage { get; set; }
        public Image TinyImage { get; set; }
        public Image MediumImage { get; set; }
        public Image LargeImage { get; set; }
        [XmlAttribute]
        public string Category { get; set; }

        public override string ToString()
        {
            return string.Format("Category:{0}", this.Category);
        }
    }
}
