using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_KPI_StoreTypeHistoryDAO
    {
        public long Id { get; set; }
        public long StoreId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long AppUserId { get; set; }
        public DateTime? PreviousCreatedAt { get; set; }
        public long? PreviousStoreTypeId { get; set; }
        public long StoreTypeId { get; set; }
    }
}
