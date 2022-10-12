using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemTypeDAO
    {
        public Dim_ItemTypeDAO()
        {
            Dim_ItemMappings = new HashSet<Dim_ItemMappingDAO>();
        }

        public long ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }

        public virtual ICollection<Dim_ItemMappingDAO> Dim_ItemMappings { get; set; }
    }
}
