using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeColumnRegistry
    {
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string Owner { get; set; }
        public string ColumnName { get; set; }
        public int SdeType { get; set; }
        public int? ColumnSize { get; set; }
        public int? DecimalDigits { get; set; }
        public string Description { get; set; }
        public int ObjectFlags { get; set; }
        public int? ObjectId { get; set; }

        public virtual SdeTableRegistry SdeTableRegistry { get; set; }
    }
}
