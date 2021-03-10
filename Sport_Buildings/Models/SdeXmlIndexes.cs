using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeXmlIndexes
    {
        public SdeXmlIndexes()
        {
            SdeXmlColumns = new HashSet<SdeXmlColumns>();
            SdeXmlIndexTags = new HashSet<SdeXmlIndexTags>();
        }

        public int IndexId { get; set; }
        public string IndexName { get; set; }
        public string Owner { get; set; }
        public int IndexType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<SdeXmlColumns> SdeXmlColumns { get; set; }
        public virtual ICollection<SdeXmlIndexTags> SdeXmlIndexTags { get; set; }
    }
}
