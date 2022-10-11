﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Page
    {
        public Page()
        {
            ActionPageMapping = new HashSet<ActionPageMapping>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public bool IsDeleted { get; set; }
        public long MenuId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual ICollection<ActionPageMapping> ActionPageMapping { get; set; }
    }
}
