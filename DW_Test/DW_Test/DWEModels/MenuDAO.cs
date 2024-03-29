﻿using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class MenuDAO
    {
        public MenuDAO()
        {
            Actions = new HashSet<ActionDAO>();
            Fields = new HashSet<FieldDAO>();
            Pages = new HashSet<PageDAO>();
            Permissions = new HashSet<PermissionDAO>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; }
        public long? SiteId { get; set; }

        public virtual ICollection<ActionDAO> Actions { get; set; }
        public virtual ICollection<FieldDAO> Fields { get; set; }
        public virtual ICollection<PageDAO> Pages { get; set; }
        public virtual ICollection<PermissionDAO> Permissions { get; set; }
    }
}
