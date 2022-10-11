using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class Fact_IndirectSalesOrderTransaction
    {
        public long IndirectSalesOrderTransactionId { get; set; }
        public long IndirectSalesOrderId { get; set; }
        public long? SellerStoreId { get; set; }
        public long BuyerStoreId { get; set; }
        public long OrganizationId { get; set; }
        public long SalesEmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public long RequestStateId { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public long TransactionTypeId { get; set; }
        public long ItemId { get; set; }
        public long? CategoryId { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal? RequestedQuantity { get; set; }
        public decimal? DiscountAmount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        public decimal? GeneralDiscountPercentage { get; set; }
        public decimal? GeneralDiscountAmount { get; set; }
        public decimal? TaxPercentage { get; set; }
        public decimal? TaxAmount { get; set; }
        public decimal Amount { get; set; }
        public long? Factor { get; set; }
        public DateTime? DeletedAt { get; set; }
        public long GeneralIndirectStateId { get; set; }
    }
}
