using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeStates
    {
        public SdeStates()
        {
            SdeMvtablesModified = new HashSet<SdeMvtablesModified>();
        }

        public long StateId { get; set; }
        public string Owner { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ClosingTime { get; set; }
        public long ParentStateId { get; set; }
        public long LineageName { get; set; }

        public virtual ICollection<SdeMvtablesModified> SdeMvtablesModified { get; set; }
    }
}
