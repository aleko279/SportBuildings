using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeLayerLocks
    {
        public int SdeId { get; set; }
        public int LayerId { get; set; }
        public string Autolock { get; set; }
        public string LockType { get; set; }
        public DateTime LockTime { get; set; }
        public long? Minx { get; set; }
        public long? Miny { get; set; }
        public long? Maxx { get; set; }
        public long? Maxy { get; set; }
    }
}
