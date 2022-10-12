using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Dim_BrandDAO
    {
        public long BrandId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public long StatusId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public Guid RowId { get; set; }
    }
}
