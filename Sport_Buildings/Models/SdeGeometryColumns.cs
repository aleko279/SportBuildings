using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeGeometryColumns
    {
        public string FTableCatalog { get; set; }
        public string FTableSchema { get; set; }
        public string FTableName { get; set; }
        public string FGeometryColumn { get; set; }
        public string GTableCatalog { get; set; }
        public string GTableSchema { get; set; }
        public string GTableName { get; set; }
        public int? StorageType { get; set; }
        public int? GeometryType { get; set; }
        public int? CoordDimension { get; set; }
        public int? MaxPpr { get; set; }
        public int Srid { get; set; }

        public virtual SdeSpatialReferences Sr { get; set; }
    }
}
