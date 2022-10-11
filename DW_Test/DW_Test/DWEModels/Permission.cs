using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionActionMapping = new HashSet<PermissionActionMapping>();
            PermissionContent = new HashSet<PermissionContent>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long RoleId { get; set; }
        public long MenuId { get; set; }
        public long StatusId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual Role Role { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<PermissionActionMapping> PermissionActionMapping { get; set; }
        public virtual ICollection<PermissionContent> PermissionContent { get; set; }
    }
}
