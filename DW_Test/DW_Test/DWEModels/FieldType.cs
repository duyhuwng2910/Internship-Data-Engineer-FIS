using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class FieldType
    {
        public FieldType()
        {
            Field = new HashSet<Field>();
            PermissionOperator = new HashSet<PermissionOperator>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Field> Field { get; set; }
        public virtual ICollection<PermissionOperator> PermissionOperator { get; set; }
    }
}
