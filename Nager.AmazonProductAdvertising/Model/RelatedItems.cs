namespace Nager.AmazonProductAdvertising.Model
{

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    [System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
    public partial class RelatedItems
    {

        private string relationshipField;

        private string relationshipTypeField;

        private byte relatedItemCountField;

        private byte relatedItemPageCountField;

        private byte relatedItemPageField;

        private RelatedItemsRelatedItem[] relatedItemField;

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("RelatedItem")]
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

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
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

    /// <remarks/>
    [System.Serializable()]
    [System.ComponentModel.DesignerCategory("code")]
    [System.Xml.Serialization.XmlType(AnonymousType = true)]
    public partial class RelatedItemsRelatedItemItem
    {

        private string aSINField;

        /// <remarks/>
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
