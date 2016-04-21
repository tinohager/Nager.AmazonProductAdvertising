using System.Collections.Generic;
using System.Linq;

namespace Nager.AmazonProductAdvertising.Model
{
    public class AmazonOperationBase
    {
        public Dictionary<string, string> ParameterDictionary;

        public AmazonOperationBase()
        {
            ParameterDictionary = new Dictionary<string, string>();
        }

        public void ResponseGroup(params AmazonResponseGroup[] responseGroup)
        {
            if (this.ParameterDictionary.ContainsKey("ResponseGroup"))
            {
                this.ParameterDictionary["ResponseGroup"] =  string.Join(",", responseGroup.Select(rg => rg.ToString()));
                return;
            }

            this.ParameterDictionary.Add("ResponseGroup", string.Join(",", responseGroup.Select(rg => rg.ToString())));
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