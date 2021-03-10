using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeSpatialReferences
    {
        public SdeSpatialReferences()
        {
            SdeGeometryColumns = new HashSet<SdeGeometryColumns>();
            SdeLayersSecondarySr = new HashSet<SdeLayers>();
            SdeLayersSr = new HashSet<SdeLayers>();
            SdeRasterColumns = new HashSet<SdeRasterColumns>();
        }

        public int Srid { get; set; }
        public string Description { get; set; }
        public string AuthName { get; set; }
        public int? AuthSrid { get; set; }
        public double Falsex { get; set; }
        public double Falsey { get; set; }
        public double Xyunits { get; set; }
        public double Falsez { get; set; }
        public double Zunits { get; set; }
        public double Falsem { get; set; }
        public double Munits { get; set; }
        public double? XyclusterTol { get; set; }
        public double? ZclusterTol { get; set; }
        public double? MclusterTol { get; set; }
        public int ObjectFlags { get; set; }
        public string Srtext { get; set; }

        public virtual ICollection<SdeGeometryColumns> SdeGeometryColumns { get; set; }
        public virtual ICollection<SdeLayers> SdeLayersSecondarySr { get; set; }
        public virtual ICollection<SdeLayers> SdeLayersSr { get; set; }
        public virtual ICollection<SdeRasterColumns> SdeRasterColumns { get; set; }
    }
}
