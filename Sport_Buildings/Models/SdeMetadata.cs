using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeMetadata
    {
        public int RecordId { get; set; }
        public string ObjectDatabase { get; set; }
        public string ObjectName { get; set; }
        public string ObjectOwner { get; set; }
        public int ObjectType { get; set; }
        public string ClassName { get; set; }
        public string Property { get; set; }
        public string PropValue { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
