using Nager.AmazonProductAdvertising.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nager.AmazonProductAdvertising.Operation
{
    public class AmazonOperationBase
    {
        public Dictionary<string, string> ParameterDictionary;

        public AmazonOperationBase()
        {
            this.ParameterDictionary = new Dictionary<string, string>();
        }

        public void ResponseGroup(IList<AmazonResponseGroup> responseGroups)
        {
            this.AddOrReplace("ResponseGroup", String.Join(",", responseGroups.Select(s => s.ToString())));

            if (responseGroups.Contains(AmazonResponseGroup.RelatedItems))
                RelationshipType(AmazonRelationshipType.Tracks);
        }

        public void RelationshipType(AmazonRelationshipType relationshipType)
        {
            this.AddOrReplace("RelationshipType", relationshipType.ToString());
        }

        public void SearchIndex(AmazonSearchIndex searchIndex)
        {
            this.AddOrReplace("SearchIndex", searchIndex.ToString());
        }

        public void AssociateTag(string associateTag)
        {
            this.AddOrReplace("AssociateTag", associateTag);
        }

        protected void AddOrReplace(string param, object value)
        {
            if (this.ParameterDictionary.ContainsKey(param))
            {
                this.ParameterDictionary[param] = value.ToString();
            }
            else
            {
                this.ParameterDictionary.Add(param, value.ToString());
            }
        }
    }
}
