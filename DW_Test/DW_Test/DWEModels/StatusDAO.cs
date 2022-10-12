using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class StatusDAO
    {
        public StatusDAO()
        {
            Permissions = new HashSet<PermissionDAO>();
            Roles = new HashSet<RoleDAO>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PermissionDAO> Permissions { get; set; }
        public virtual ICollection<RoleDAO> Roles { get; set; }
    }
}
