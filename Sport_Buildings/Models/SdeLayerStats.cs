using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeLayerStats
    {
        public int Oid { get; set; }
        public int LayerId { get; set; }
        public int? VersionId { get; set; }
        public double Minx { get; set; }
        public double Miny { get; set; }
        public double Maxx { get; set; }
        public double Maxy { get; set; }
        public double? Minz { get; set; }
        public double? Minm { get; set; }
        public double? Maxz { get; set; }
        public double? Maxm { get; set; }
        public int TotalFeatures { get; set; }
        public int TotalPoints { get; set; }
        public DateTime LastAnalyzed { get; set; }

        public virtual SdeLayers Layer { get; set; }
        public virtual SdeVersions Version { get; set; }
    }
}
