using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeVersion
    {
        public int Major { get; set; }
        public int Minor { get; set; }
        public int Bugfix { get; set; }
        public string Description { get; set; }
        public int Release { get; set; }
        public int SdesvrRelLow { get; set; }
    }
}
