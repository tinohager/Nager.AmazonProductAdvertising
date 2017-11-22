using System.Xml.Serialization;

namespace Nager.AmazonProductAdvertising.Model
{
    [XmlRoot(Namespace = "", IsNullable = false)]
    public class Tracks
    {
        public TracksDisc Disc { get; set; }
    }

    public class TracksDisc
    {
        [XmlElement("Track")]
        public TracksDiscTrack[] Track { get; set; }

        [XmlAttribute()]
        public byte Number { get; set; }
    }

    public class TracksDiscTrack
    {
        [XmlAttribute()]
        public byte Number { get; set; }

        [XmlText()]
        public string Value { get; set; }
    }
}
