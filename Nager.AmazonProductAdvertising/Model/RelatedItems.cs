namespace Nager.AmazonProductAdvertising.Model
{
    public class RelatedItems
    {

        private string relationshipField;

        private string relationshipTypeField;

        private byte relatedItemCountField;

        private byte relatedItemPageCountField;

        private byte relatedItemPageField;

        private RelatedItemsRelatedItem[] relatedItemField;

        public string Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }

        public string RelationshipType
        {
            get
            {
                return this.relationshipTypeField;
            }
            set
            {
                this.relationshipTypeField = value;
            }
        }

        public byte RelatedItemCount
        {
            get
            {
                return this.relatedItemCountField;
            }
            set
            {
                this.relatedItemCountField = value;
            }
        }

        public byte RelatedItemPageCount
        {
            get
            {
                return this.relatedItemPageCountField;
            }
            set
            {
                this.relatedItemPageCountField = value;
            }
        }

        public byte RelatedItemPage
        {
            get
            {
                return this.relatedItemPageField;
            }
            set
            {
                this.relatedItemPageField = value;
            }
        }

        public RelatedItemsRelatedItem[] RelatedItem
        {
            get
            {
                return this.relatedItemField;
            }
            set
            {
                this.relatedItemField = value;
            }
        }
    }

    public partial class RelatedItemsRelatedItem
    {

        private RelatedItemsRelatedItemItem itemField;

        /// <remarks/>
        public RelatedItemsRelatedItemItem Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

    public partial class RelatedItemsRelatedItemItem
    {
        private string aSINField;

        public string ASIN
        {
            get
            {
                return this.aSINField;
            }
            set
            {
                this.aSINField = value;
            }
        }
    }


}
