using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemSingleSmartGroupDAO
    {
        public Dim_ItemSingleSmartGroupDAO()
        {
            Dim_ItemMappings = new HashSet<Dim_ItemMappingDAO>();
        }

        public long ItemSingleSmartGroupId { get; set; }
        public string ItemSingleSmartGroupName { get; set; }

        public virtual ICollection<Dim_ItemMappingDAO> Dim_ItemMappings { get; set; }
    }
}
