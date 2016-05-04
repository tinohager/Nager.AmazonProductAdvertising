using System.Collections.Generic;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonOperationBase
    {
        public Dictionary<string, string> ParameterDictionary;

        public AmazonOperationBase()
        {
            ParameterDictionary = new Dictionary<string, string>();
        }

        public void ResponseGroup(AmazonResponseGroup responseGroup)
        {
            if (this.ParameterDictionary.ContainsKey("ResponseGroup"))
            {
                this.ParameterDictionary["ResponseGroup"] = responseGroup.ToString();
                return;
            }

            this.ParameterDictionary.Add("ResponseGroup", responseGroup.ToString());
        }

        public void SearchIndex(AmazonSearchIndex searchIndex)
        {
            if (this.ParameterDictionary.ContainsKey("SearchIndex"))
            {
                this.ParameterDictionary["SearchIndex"] = searchIndex.ToString();
                return;
            }

            this.ParameterDictionary.Add("SearchIndex", searchIndex.ToString());
        }

        public void AssociateTag(string associateTag)
        {
            if (this.ParameterDictionary.ContainsKey("AssociateTag"))
            {
                this.ParameterDictionary["AssociateTag"] = associateTag;
                return;
            }

            this.ParameterDictionary.Add("AssociateTag", associateTag);
        }
    }
}