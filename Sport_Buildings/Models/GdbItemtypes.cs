using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class GdbItemtypes
    {
        public int ObjectId { get; set; }
        public Guid Uuid { get; set; }
        public string Name { get; set; }
        public Guid ParentTypeId { get; set; }
    }
}
