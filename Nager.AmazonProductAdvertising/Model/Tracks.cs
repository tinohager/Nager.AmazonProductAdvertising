namespace Nager.AmazonProductAdvertising.Model
{
    public class Tracks
    {
        public TracksDisc Disc { get; set; }
    }

    public class TracksDisc
    {
        public TracksDiscTrack[] Track { get; set; }

        public byte Number { get; set; }
    }

    public class TracksDiscTrack
    {
        public byte Number { get; set; }

        public string Value { get; set; }
    }
}
