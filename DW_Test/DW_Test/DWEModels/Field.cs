﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Field
    {
        public Field()
        {
            PermissionContent = new HashSet<PermissionContent>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long FieldTypeId { get; set; }
        public long MenuId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual FieldType FieldType { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<PermissionContent> PermissionContent { get; set; }
    }
}
