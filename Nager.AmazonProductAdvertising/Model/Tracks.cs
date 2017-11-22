namespace Nager.AmazonProductAdvertising.Model
{
    public class Tracks
    {

        private TracksDisc discField;

        /// <remarks/>
        public TracksDisc Disc
        {
            get
            {
                return this.discField;
            }
            set
            {
                this.discField = value;
            }
        }
    }

    public class TracksDisc
    {

        private TracksDiscTrack[] trackField;

        private byte numberField;

        public TracksDiscTrack[] Track
        {
            get
            {
                return this.trackField;
            }
            set
            {
                this.trackField = value;
            }
        }

        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    public class TracksDiscTrack
    {

        private byte numberField;

        private string valueField;

        public byte Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
