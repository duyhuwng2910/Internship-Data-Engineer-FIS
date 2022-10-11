using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Role
    {
        public Role()
        {
            AppUserRoleMapping = new HashSet<AppUserRoleMapping>();
            Permission = new HashSet<Permission>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long StatusId { get; set; }
        public bool Used { get; set; }
        public bool IsDeleted { get; set; }
        public long? SiteId { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<AppUserRoleMapping> AppUserRoleMapping { get; set; }
        public virtual ICollection<Permission> Permission { get; set; }
    }
}
