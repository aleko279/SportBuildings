using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeMvtablesModified
    {
        public long StateId { get; set; }
        public int RegistrationId { get; set; }

        public virtual SdeTableRegistry Registration { get; set; }
        public virtual SdeStates State { get; set; }
    }
}
