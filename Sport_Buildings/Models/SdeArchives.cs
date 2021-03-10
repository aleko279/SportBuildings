using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeArchives
    {
        public int ArchivingRegid { get; set; }
        public int HistoryRegid { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public long ArchiveDate { get; set; }
        public long ArchiveFlags { get; set; }

        public virtual SdeTableRegistry ArchivingReg { get; set; }
        public virtual SdeTableRegistry HistoryReg { get; set; }
    }
}
