using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeRasterColumns
    {
        public int RastercolumnId { get; set; }
        public string Description { get; set; }
        public string DatabaseName { get; set; }
        public string Owner { get; set; }
        public string TableName { get; set; }
        public string RasterColumn { get; set; }
        public int Cdate { get; set; }
        public string ConfigKeyword { get; set; }
        public int? MinimumId { get; set; }
        public int BaseRastercolumnId { get; set; }
        public int RastercolumnMask { get; set; }
        public int? Srid { get; set; }

        public virtual SdeSpatialReferences Sr { get; set; }
    }
}
