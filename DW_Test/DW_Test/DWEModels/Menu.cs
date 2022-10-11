using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Menu
    {
        public Menu()
        {
            Action = new HashSet<Action>();
            Field = new HashSet<Field>();
            Page = new HashSet<Page>();
            Permission = new HashSet<Permission>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; }
        public long? SiteId { get; set; }

        public virtual ICollection<Action> Action { get; set; }
        public virtual ICollection<Field> Field { get; set; }
        public virtual ICollection<Page> Page { get; set; }
        public virtual ICollection<Permission> Permission { get; set; }
    }
}
