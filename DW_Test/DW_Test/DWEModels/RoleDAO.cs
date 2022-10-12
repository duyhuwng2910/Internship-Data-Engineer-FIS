using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class RoleDAO
    {
        public RoleDAO()
        {
            AppUserRoleMappings = new HashSet<AppUserRoleMappingDAO>();
            Permissions = new HashSet<PermissionDAO>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long StatusId { get; set; }
        public bool Used { get; set; }
        public bool IsDeleted { get; set; }
        public long? SiteId { get; set; }

        public virtual StatusDAO Status { get; set; }
        public virtual ICollection<AppUserRoleMappingDAO> AppUserRoleMappings { get; set; }
        public virtual ICollection<PermissionDAO> Permissions { get; set; }
    }
}
