using System;
using System.Collections.Generic;

namespace DW_Test.DWEModels
{
    public partial class Fact_SaleIn_KpiCollectionResultDAO
    {
        public long Id { get; set; }
        public long OrganizationId { get; set; }
        public long TargetSaleInId { get; set; }
        public long PeriodId { get; set; }
        public long Year { get; set; }
        public decimal? Planned { get; set; }
        public decimal? Result { get; set; }
        public string Evaluation { get; set; }
        public long? OrderNumber { get; set; }
    }
}
