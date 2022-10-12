using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_SaleEntityDAO
    {
        public Dim_SaleEntityDAO()
        {
            InverseSaleParent = new HashSet<Dim_SaleEntityDAO>();
        }

        public long SaleEntityId { get; set; }
        public string SaleEntityName { get; set; }
        public long? SaleParentId { get; set; }

        public virtual Dim_SaleEntityDAO SaleParent { get; set; }
        public virtual ICollection<Dim_SaleEntityDAO> InverseSaleParent { get; set; }
    }
}
