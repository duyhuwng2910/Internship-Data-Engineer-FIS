using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class AppUserRoleMapping
    {
        public long AppUserId { get; set; }
        public long RoleId { get; set; }

        public virtual Dim_AppUser AppUser { get; set; }
        public virtual Role Role { get; set; }
    }
}
