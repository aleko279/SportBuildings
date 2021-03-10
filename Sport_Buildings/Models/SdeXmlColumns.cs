using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeXmlColumns
    {
        public int ColumnId { get; set; }
        public int RegistrationId { get; set; }
        public string ColumnName { get; set; }
        public int? IndexId { get; set; }
        public int? MinimumId { get; set; }
        public string ConfigKeyword { get; set; }
        public int Xflags { get; set; }

        public virtual SdeXmlIndexes Index { get; set; }
        public virtual SdeTableRegistry Registration { get; set; }
    }
}
