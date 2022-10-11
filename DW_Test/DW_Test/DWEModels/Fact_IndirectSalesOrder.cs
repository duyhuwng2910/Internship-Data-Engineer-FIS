using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_IndirectSalesOrder
    {
        public long IndirectSalesOrderId { get; set; }
        public string Code { get; set; }
        public long BuyerStoreId { get; set; }
        public long OrganizationId { get; set; }
        public long? SellerStoreId { get; set; }
        public long SaleEmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public long RequestStateId { get; set; }
        public long EditedPriceStatusId { get; set; }
        public decimal SubTotal { get; set; }
        public decimal? GeneralDiscountPercentage { get; set; }
        public decimal? GeneralDiscountAmount { get; set; }
        public decimal? TotalDiscountAmount { get; set; }
        public decimal Total { get; set; }
        public long? StoreCheckingId { get; set; }
        public long? CreatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long BuyerStoreTypeId { get; set; }
        public long GeneralIndirectStateId { get; set; }
    }
}
