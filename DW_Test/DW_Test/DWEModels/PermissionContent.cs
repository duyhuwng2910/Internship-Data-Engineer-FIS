using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class PermissionContent
    {
        public long Id { get; set; }
        public long PermissionId { get; set; }
        public long FieldId { get; set; }
        public long PermissionOperatorId { get; set; }
        public string Value { get; set; }

        public virtual Field Field { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual PermissionOperator PermissionOperator { get; set; }
    }
}
