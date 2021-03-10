using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeVersions
    {
        public SdeVersions()
        {
            SdeLayerStats = new HashSet<SdeLayerStats>();
        }

        public string Name { get; set; }
        public string Owner { get; set; }
        public int VersionId { get; set; }
        public int Status { get; set; }
        public long StateId { get; set; }
        public string Description { get; set; }
        public string ParentName { get; set; }
        public string ParentOwner { get; set; }
        public int? ParentVersionId { get; set; }
        public DateTime CreationTime { get; set; }

        public virtual ICollection<SdeLayerStats> SdeLayerStats { get; set; }
    }
}
