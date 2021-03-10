using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeXmlIndexTags
    {
        public int IndexId { get; set; }
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int DataType { get; set; }
        public int? TagAlias { get; set; }
        public string Description { get; set; }
        public int IsExcluded { get; set; }

        public virtual SdeXmlIndexes Index { get; set; }
    }
}
