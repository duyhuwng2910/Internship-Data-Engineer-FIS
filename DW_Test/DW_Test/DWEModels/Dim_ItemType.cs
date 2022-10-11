using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemType
    {
        public Dim_ItemType()
        {
            Dim_ItemMapping = new HashSet<Dim_ItemMapping>();
        }

        public long ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }

        public virtual ICollection<Dim_ItemMapping> Dim_ItemMapping { get; set; }
    }
}
