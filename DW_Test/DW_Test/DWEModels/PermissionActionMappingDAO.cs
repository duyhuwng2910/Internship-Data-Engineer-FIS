﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class PermissionActionMappingDAO
    {
        public long ActionId { get; set; }
        public long PermissionId { get; set; }

        public virtual ActionDAO Action { get; set; }
        public virtual PermissionDAO Permission { get; set; }
    }
}
