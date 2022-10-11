using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemSingleSmartGroup
    {
        public Dim_ItemSingleSmartGroup()
        {
            Dim_ItemMapping = new HashSet<Dim_ItemMapping>();
        }

        public long ItemSingleSmartGroupId { get; set; }
        public string ItemSingleSmartGroupName { get; set; }

        public virtual ICollection<Dim_ItemMapping> Dim_ItemMapping { get; set; }
    }
}
