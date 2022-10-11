using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Status
    {
        public Status()
        {
            Permission = new HashSet<Permission>();
            Role = new HashSet<Role>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
        public virtual ICollection<Role> Role { get; set; }
    }
}
