using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeProcessInformation
    {
        public int SdeId { get; set; }
        public int Spid { get; set; }
        public int ServerId { get; set; }
        public DateTime StartTime { get; set; }
        public int Rcount { get; set; }
        public int Wcount { get; set; }
        public int Opcount { get; set; }
        public int Numlocks { get; set; }
        public int FbPartial { get; set; }
        public int FbCount { get; set; }
        public int FbFcount { get; set; }
        public int FbKbytes { get; set; }
        public string Owner { get; set; }
        public string DirectConnect { get; set; }
        public string Sysname { get; set; }
        public string Nodename { get; set; }
        public string XdrNeeded { get; set; }
        public string TableName { get; set; }
    }
}
