using System;
using System.Collections.Generic;

namespace Sport_Buildings.Models
{
    public partial class SdeTableRegistry
    {
        public SdeTableRegistry()
        {
            SdeColumnRegistry = new HashSet<SdeColumnRegistry>();
            SdeMvtablesModified = new HashSet<SdeMvtablesModified>();
            SdeXmlColumns = new HashSet<SdeXmlColumns>();
        }

        public int RegistrationId { get; set; }
        public string DatabaseName { get; set; }
        public string TableName { get; set; }
        public string Owner { get; set; }
        public string RowidColumn { get; set; }
        public string Description { get; set; }
        public int ObjectFlags { get; set; }
        public int RegistrationDate { get; set; }
        public string ConfigKeyword { get; set; }
        public int? MinimumId { get; set; }
        public string ImvViewName { get; set; }

        public virtual SdeArchives SdeArchivesArchivingReg { get; set; }
        public virtual SdeArchives SdeArchivesHistoryReg { get; set; }
        public virtual ICollection<SdeColumnRegistry> SdeColumnRegistry { get; set; }
        public virtual ICollection<SdeMvtablesModified> SdeMvtablesModified { get; set; }
        public virtual ICollection<SdeXmlColumns> SdeXmlColumns { get; set; }
    }
}
