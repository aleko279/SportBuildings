using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class BuildingFoto
    {
        public int Objectid { get; set; }
        public int? BuildingCodeId { get; set; }
        public string FotoPath { get; set; }
        public string BuildingId { get; set; }
    }
}
