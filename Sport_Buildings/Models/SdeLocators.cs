using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeLocators
    {
        public int LocatorId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Category { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
    }
}
