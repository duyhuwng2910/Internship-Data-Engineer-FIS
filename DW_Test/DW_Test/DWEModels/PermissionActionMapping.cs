﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class PermissionActionMapping
    {
        public long ActionId { get; set; }
        public long PermissionId { get; set; }

        public virtual Action Action { get; set; }
        public virtual Permission Permission { get; set; }
    }
}