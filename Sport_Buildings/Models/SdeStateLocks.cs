using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeStateLocks
    {
        public int SdeId { get; set; }
        public long StateId { get; set; }
        public string Autolock { get; set; }
        public string LockType { get; set; }
        public DateTime LockTime { get; set; }
    }
}
