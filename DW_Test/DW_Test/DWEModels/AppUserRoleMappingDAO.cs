using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class AppUserRoleMappingDAO
    {
        public long AppUserId { get; set; }
        public long RoleId { get; set; }

        public virtual Dim_AppUserDAO AppUser { get; set; }
        public virtual RoleDAO Role { get; set; }
    }
}
