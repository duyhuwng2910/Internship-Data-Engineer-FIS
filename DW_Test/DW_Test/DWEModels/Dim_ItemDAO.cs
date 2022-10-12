using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_ItemDAO
    {
        public Dim_ItemDAO()
        {
            Dim_ItemMappings = new HashSet<Dim_ItemMappingDAO>();
        }

        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public long? UnitPrice { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Dim_ItemMappingDAO> Dim_ItemMappings { get; set; }
    }
}
