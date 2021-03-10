using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeTableLocks
    {
        public int SdeId { get; set; }
        public int RegistrationId { get; set; }
        public string LockType { get; set; }
        public DateTime LockTime { get; set; }
    }
}
