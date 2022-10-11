using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Action
    {
        public Action()
        {
            ActionPageMapping = new HashSet<ActionPageMapping>();
            PermissionActionMapping = new HashSet<PermissionActionMapping>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long MenuId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual ICollection<ActionPageMapping> ActionPageMapping { get; set; }
        public virtual ICollection<PermissionActionMapping> PermissionActionMapping { get; set; }
    }
}
