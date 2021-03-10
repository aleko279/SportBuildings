using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class StGeometryColumns
    {
        public string TableSchema { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string TypeSchema { get; set; }
        public string TypeName { get; set; }
        public int SrsId { get; set; }
    }
}
