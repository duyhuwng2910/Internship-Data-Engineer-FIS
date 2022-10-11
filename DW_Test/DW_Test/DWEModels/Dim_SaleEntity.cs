using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Dim_SaleEntity
    {
        public Dim_SaleEntity()
        {
            InverseSaleParent = new HashSet<Dim_SaleEntity>();
        }

        public long SaleEntityId { get; set; }
        public string SaleEntityName { get; set; }
        public long? SaleParentId { get; set; }

        public virtual Dim_SaleEntity SaleParent { get; set; }
        public virtual ICollection<Dim_SaleEntity> InverseSaleParent { get; set; }
    }
}
