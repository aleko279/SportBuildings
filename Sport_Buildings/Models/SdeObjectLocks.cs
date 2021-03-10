using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeObjectLocks
    {
        public int SdeId { get; set; }
        public int ObjectId { get; set; }
        public int ObjectType { get; set; }
        public int ApplicationId { get; set; }
        public string Autolock { get; set; }
        public string LockType { get; set; }
        public DateTime LockTime { get; set; }
    }
}
