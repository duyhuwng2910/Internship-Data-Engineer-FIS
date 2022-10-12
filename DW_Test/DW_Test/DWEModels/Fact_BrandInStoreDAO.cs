using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_BrandInStoreDAO
    {
        public long BrandInStoreId { get; set; }
        public long StoreId { get; set; }
        public long BrandId { get; set; }
        public long Top { get; set; }
        public long CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid RowId { get; set; }
    }
}
