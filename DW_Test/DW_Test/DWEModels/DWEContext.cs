using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DW_Test.DWEModels
{
    public partial class DWEContext : DbContext
    {
        public virtual DbSet<ActionDAO> Action { get; set; }
        public virtual DbSet<ActionPageMappingDAO> ActionPageMapping { get; set; }
        public virtual DbSet<AggregatedCounterDAO> AggregatedCounter { get; set; }
        public virtual DbSet<AppUserRoleMappingDAO> AppUserRoleMapping { get; set; }
        public virtual DbSet<CounterDAO> Counter { get; set; }
        public virtual DbSet<Dim_AppUserDAO> Dim_AppUser { get; set; }
        public virtual DbSet<Dim_AppUserStoreMappingDAO> Dim_AppUserStoreMapping { get; set; }
        public virtual DbSet<Dim_BrandDAO> Dim_Brand { get; set; }
        public virtual DbSet<Dim_BrandInStoreProductGroupingMappingDAO> Dim_BrandInStoreProductGroupingMapping { get; set; }
        public virtual DbSet<Dim_C4LED_SaleBranchDAO> Dim_C4LED_SaleBranch { get; set; }
        public virtual DbSet<Dim_C4LED_SaleUnitMappingDAO> Dim_C4LED_SaleUnitMapping { get; set; }
        public virtual DbSet<Dim_C4LED_WeekDAO> Dim_C4LED_Week { get; set; }
        public virtual DbSet<Dim_CountryDAO> Dim_Country { get; set; }
        public virtual DbSet<Dim_CountyDAO> Dim_County { get; set; }
        public virtual DbSet<Dim_CustomerDAO> Dim_Customer { get; set; }
        public virtual DbSet<Dim_CustomerC2DAO> Dim_CustomerC2 { get; set; }
        public virtual DbSet<Dim_CustomerEmployeeMappingDAO> Dim_CustomerEmployeeMapping { get; set; }
        public virtual DbSet<Dim_DateDAO> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMappingDAO> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_Date_FilterDAO> Dim_Date_Filter { get; set; }
        public virtual DbSet<Dim_DistrictDAO> Dim_District { get; set; }
        public virtual DbSet<Dim_EmployeeDAO> Dim_Employee { get; set; }
        public virtual DbSet<Dim_ItemDAO> Dim_Item { get; set; }
        public virtual DbSet<Dim_ItemDMSDAO> Dim_ItemDMS { get; set; }
        public virtual DbSet<Dim_ItemGroupDAO> Dim_ItemGroup { get; set; }
        public virtual DbSet<Dim_ItemGroupLevelDAO> Dim_ItemGroupLevel { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel1DAO> Dim_ItemGroupLevel1 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel2DAO> Dim_ItemGroupLevel2 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel3DAO> Dim_ItemGroupLevel3 { get; set; }
        public virtual DbSet<Dim_ItemLedSmartGroupDAO> Dim_ItemLedSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemMainGroupDAO> Dim_ItemMainGroup { get; set; }
        public virtual DbSet<Dim_ItemMappingDAO> Dim_ItemMapping { get; set; }
        public virtual DbSet<Dim_ItemNCTTDAO> Dim_ItemNCTT { get; set; }
        public virtual DbSet<Dim_ItemNewItemGroupDAO> Dim_ItemNewItemGroup { get; set; }
        public virtual DbSet<Dim_ItemSingleSmartGroupDAO> Dim_ItemSingleSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemTypeDAO> Dim_ItemType { get; set; }
        public virtual DbSet<Dim_ItemVATGroupDAO> Dim_ItemVATGroup { get; set; }
        public virtual DbSet<Dim_KPITypeDAO> Dim_KPIType { get; set; }
        public virtual DbSet<Dim_KPI_MeasureDAO> Dim_KPI_Measure { get; set; }
        public virtual DbSet<Dim_KPI_ProductGroupingDAO> Dim_KPI_ProductGrouping { get; set; }
        public virtual DbSet<Dim_KPI_ProductGrouping_MappingDAO> Dim_KPI_ProductGrouping_Mapping { get; set; }
        public virtual DbSet<Dim_LocationDAO> Dim_Location { get; set; }
        public virtual DbSet<Dim_MainBusinessDAO> Dim_MainBusiness { get; set; }
        public virtual DbSet<Dim_MonthDAO> Dim_Month { get; set; }
        public virtual DbSet<Dim_OrganizationUnitDAO> Dim_OrganizationUnit { get; set; }
        public virtual DbSet<Dim_OrganizationUnitMappingDAO> Dim_OrganizationUnitMapping { get; set; }
        public virtual DbSet<Dim_PeriodDAO> Dim_Period { get; set; }
        public virtual DbSet<Dim_ProductDAO> Dim_Product { get; set; }
        public virtual DbSet<Dim_ProductMappingDAO> Dim_ProductMapping { get; set; }
        public virtual DbSet<Dim_ProductSaleChannelMappingDAO> Dim_ProductSaleChannelMapping { get; set; }
        public virtual DbSet<Dim_ProvinceDAO> Dim_Province { get; set; }
        public virtual DbSet<Dim_QuarterDAO> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_RD_CustomerDAO> Dim_RD_Customer { get; set; }
        public virtual DbSet<Dim_RD_ItemDAO> Dim_RD_Item { get; set; }
        public virtual DbSet<Dim_RD_ItemGroupLevel1DAO> Dim_RD_ItemGroupLevel1 { get; set; }
        public virtual DbSet<Dim_RD_ItemGroupLevel2DAO> Dim_RD_ItemGroupLevel2 { get; set; }
        public virtual DbSet<Dim_RD_SaleChannelDAO> Dim_RD_SaleChannel { get; set; }
        public virtual DbSet<Dim_RD_SaleEmployeeDAO> Dim_RD_SaleEmployee { get; set; }
        public virtual DbSet<Dim_RegionDAO> Dim_Region { get; set; }
        public virtual DbSet<Dim_SaleArrayDAO> Dim_SaleArray { get; set; }
        public virtual DbSet<Dim_SaleBranchDAO> Dim_SaleBranch { get; set; }
        public virtual DbSet<Dim_SaleCenterDAO> Dim_SaleCenter { get; set; }
        public virtual DbSet<Dim_SaleChannelDAO> Dim_SaleChannel { get; set; }
        public virtual DbSet<Dim_SaleEmployeeDAO> Dim_SaleEmployee { get; set; }
        public virtual DbSet<Dim_SaleEntityDAO> Dim_SaleEntity { get; set; }
        public virtual DbSet<Dim_SaleFieldDAO> Dim_SaleField { get; set; }
        public virtual DbSet<Dim_SaleLevelDAO> Dim_SaleLevel { get; set; }
        public virtual DbSet<Dim_SaleRoomDAO> Dim_SaleRoom { get; set; }
        public virtual DbSet<Dim_SaleUnitDAO> Dim_SaleUnit { get; set; }
        public virtual DbSet<Dim_SaleUnitMappingDAO> Dim_SaleUnitMapping { get; set; }
        public virtual DbSet<Dim_SpecializedChannelMappingDAO> Dim_SpecializedChannelMapping { get; set; }
        public virtual DbSet<Dim_StoreDAO> Dim_Store { get; set; }
        public virtual DbSet<Dim_StoreGroupingDAO> Dim_StoreGrouping { get; set; }
        public virtual DbSet<Dim_StoreMappingDAO> Dim_StoreMapping { get; set; }
        public virtual DbSet<Dim_StoreTypeDAO> Dim_StoreType { get; set; }
        public virtual DbSet<Dim_Targets_SaleInDAO> Dim_Targets_SaleIn { get; set; }
        public virtual DbSet<Dim_Targets_SaleOutDAO> Dim_Targets_SaleOut { get; set; }
        public virtual DbSet<Dim_TeamSale_CustomerDAO> Dim_TeamSale_Customer { get; set; }
        public virtual DbSet<Dim_WarehouseDAO> Dim_Warehouse { get; set; }
        public virtual DbSet<Dim_WeekDAO> Dim_Week { get; set; }
        public virtual DbSet<Dim_YearDAO> Dim_Year { get; set; }
        public virtual DbSet<Fact_Actual_RevenueDAO> Fact_Actual_Revenue { get; set; }
        public virtual DbSet<Fact_BrandInStoreDAO> Fact_BrandInStore { get; set; }
        public virtual DbSet<Fact_C4LED_Revenue_MonthDAO> Fact_C4LED_Revenue_Month { get; set; }
        public virtual DbSet<Fact_C4LED_Revenue_WeekDAO> Fact_C4LED_Revenue_Week { get; set; }
        public virtual DbSet<Fact_C4LED_SalePlan_MonthDAO> Fact_C4LED_SalePlan_Month { get; set; }
        public virtual DbSet<Fact_C4LED_SalePlan_QuarterDAO> Fact_C4LED_SalePlan_Quarter { get; set; }
        public virtual DbSet<Fact_C4LED_SalePlan_YearDAO> Fact_C4LED_SalePlan_Year { get; set; }
        public virtual DbSet<Fact_Company_Month_PlanDAO> Fact_Company_Month_Plan { get; set; }
        public virtual DbSet<Fact_Company_Quarter_PlanDAO> Fact_Company_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Company_Year_PlanDAO> Fact_Company_Year_Plan { get; set; }
        public virtual DbSet<Fact_Country_Month_PlanDAO> Fact_Country_Month_Plan { get; set; }
        public virtual DbSet<Fact_Country_Quarter_PlanDAO> Fact_Country_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Country_Year_PlanDAO> Fact_Country_Year_Plan { get; set; }
        public virtual DbSet<Fact_County_Month_PlanDAO> Fact_County_Month_Plan { get; set; }
        public virtual DbSet<Fact_County_Quarter_PlanDAO> Fact_County_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_County_Year_PlanDAO> Fact_County_Year_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Month_PlanDAO> Fact_Customer_Month_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Quarter_PlanDAO> Fact_Customer_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Year_PlanDAO> Fact_Customer_Year_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Month_PlanDAO> Fact_Employee_Month_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Quarter_PlanDAO> Fact_Employee_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Year_PlanDAO> Fact_Employee_Year_Plan { get; set; }
        public virtual DbSet<Fact_Incur_RevenueDAO> Fact_Incur_Revenue { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderDAO> Fact_IndirectSalesOrder { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderStoreGroupingMappingDAO> Fact_IndirectSalesOrderStoreGroupingMapping { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderTransactionDAO> Fact_IndirectSalesOrderTransaction { get; set; }
        public virtual DbSet<Fact_Item_MinimumInventoryDAO> Fact_Item_MinimumInventory { get; set; }
        public virtual DbSet<Fact_Item_Month_PlanDAO> Fact_Item_Month_Plan { get; set; }
        public virtual DbSet<Fact_Item_Quarter_PlanDAO> Fact_Item_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Item_Whs_ConsignmentDAO> Fact_Item_Whs_Consignment { get; set; }
        public virtual DbSet<Fact_Item_Whs_InventoryDAO> Fact_Item_Whs_Inventory { get; set; }
        public virtual DbSet<Fact_Item_Year_PlanDAO> Fact_Item_Year_Plan { get; set; }
        public virtual DbSet<Fact_KPI_IndirectSalesOrderDAO> Fact_KPI_IndirectSalesOrder { get; set; }
        public virtual DbSet<Fact_KPI_ProductGroupingItemDAO> Fact_KPI_ProductGroupingItem { get; set; }
        public virtual DbSet<Fact_KPI_StoreCheckingDAO> Fact_KPI_StoreChecking { get; set; }
        public virtual DbSet<Fact_KPI_StoreTypeHistoryDAO> Fact_KPI_StoreTypeHistory { get; set; }
        public virtual DbSet<Fact_MainBusiness_Month_PlanDAO> Fact_MainBusiness_Month_Plan { get; set; }
        public virtual DbSet<Fact_MainBusiness_Quarter_PlanDAO> Fact_MainBusiness_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_MainBusiness_RevenueDAO> Fact_MainBusiness_Revenue { get; set; }
        public virtual DbSet<Fact_MainBusiness_Year_PlanDAO> Fact_MainBusiness_Year_Plan { get; set; }
        public virtual DbSet<Fact_MinimumInventory_MonthDAO> Fact_MinimumInventory_Month { get; set; }
        public virtual DbSet<Fact_MinimumInventory_QuarterDAO> Fact_MinimumInventory_Quarter { get; set; }
        public virtual DbSet<Fact_MinimumInventory_YearDAO> Fact_MinimumInventory_Year { get; set; }
        public virtual DbSet<Fact_ProductGroupingDAO> Fact_ProductGrouping { get; set; }
        public virtual DbSet<Fact_RD_Customer_Month_PlanDAO> Fact_RD_Customer_Month_Plan { get; set; }
        public virtual DbSet<Fact_RD_Customer_Quarter_PlanDAO> Fact_RD_Customer_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_RD_Customer_Year_PlanDAO> Fact_RD_Customer_Year_Plan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannel_Month_PlanDAO> Fact_RD_SaleChannel_Month_Plan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannel_Quarter_PlanDAO> Fact_RD_SaleChannel_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannel_Year_PlanDAO> Fact_RD_SaleChannel_Year_Plan { get; set; }
        public virtual DbSet<Fact_Region_Month_PlanDAO> Fact_Region_Month_Plan { get; set; }
        public virtual DbSet<Fact_Region_Quarter_PlanDAO> Fact_Region_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Region_Year_PlanDAO> Fact_Region_Year_Plan { get; set; }
        public virtual DbSet<Fact_RevenueCustomerC2DAO> Fact_RevenueCustomerC2 { get; set; }
        public virtual DbSet<Fact_SaleBranch_Month_PlanDAO> Fact_SaleBranch_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Quarter_PlanDAO> Fact_SaleBranch_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Year_PlanDAO> Fact_SaleBranch_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Month_PlanDAO> Fact_SaleChannel_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Quarter_PlanDAO> Fact_SaleChannel_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Year_PlanDAO> Fact_SaleChannel_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleInRevenueDAO> Fact_SaleInRevenue { get; set; }
        public virtual DbSet<Fact_SaleIn_ActualRevenueDAO> Fact_SaleIn_ActualRevenue { get; set; }
        public virtual DbSet<Fact_SaleIn_IncurRevenueDAO> Fact_SaleIn_IncurRevenue { get; set; }
        public virtual DbSet<Fact_SaleIn_KpiCollectionResultDAO> Fact_SaleIn_KpiCollectionResult { get; set; }
        public virtual DbSet<Fact_SaleOutRevenueDAO> Fact_SaleOutRevenue { get; set; }
        public virtual DbSet<Fact_SaleOut_KpiCollectionResultDAO> Fact_SaleOut_KpiCollectionResult { get; set; }
        public virtual DbSet<Fact_SaleRoom_Month_PlanDAO> Fact_SaleRoom_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Quarter_PlanDAO> Fact_SaleRoom_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Quarter_PlanDAO> Fact_SaleRoom_TargetProduct_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Week_PlanDAO> Fact_SaleRoom_TargetProduct_Week_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Year_PlanDAO> Fact_SaleRoom_TargetProduct_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Year_PlanDAO> Fact_SaleRoom_Year_Plan { get; set; }
        public virtual DbSet<Fact_StoreCheckingDAO> Fact_StoreChecking { get; set; }
        public virtual DbSet<Fact_TeamSale_EmployeeDAO> Fact_TeamSale_Employee { get; set; }
        public virtual DbSet<FieldDAO> Field { get; set; }
        public virtual DbSet<FieldTypeDAO> FieldType { get; set; }
        public virtual DbSet<HashDAO> Hash { get; set; }
        public virtual DbSet<ItemGroupDAO> ItemGroup { get; set; }
        public virtual DbSet<JobDAO> Job { get; set; }
        public virtual DbSet<JobParameterDAO> JobParameter { get; set; }
        public virtual DbSet<JobQueueDAO> JobQueue { get; set; }
        public virtual DbSet<KPIPlanSaleInDAO> KPIPlanSaleIn { get; set; }
        public virtual DbSet<KPIRevenueSaleInDAO> KPIRevenueSaleIn { get; set; }
        public virtual DbSet<KPI_Actual_RevenueDAO> KPI_Actual_Revenue { get; set; }
        public virtual DbSet<KPI_CompleteThermosGroup_RevenueDAO> KPI_CompleteThermosGroup_Revenue { get; set; }
        public virtual DbSet<KPI_Dim_SaleEmployeeMappingDAO> KPI_Dim_SaleEmployeeMapping { get; set; }
        public virtual DbSet<KPI_Dim_SaleInKPIDAO> KPI_Dim_SaleInKPI { get; set; }
        public virtual DbSet<KPI_Dim_SaleOutKPIDAO> KPI_Dim_SaleOutKPI { get; set; }
        public virtual DbSet<KPI_Fact_Result_Planned_GeneralDAO> KPI_Fact_Result_Planned_General { get; set; }
        public virtual DbSet<KPI_Fact_RevenueDAO> KPI_Fact_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Month_RevenueDAO> KPI_Fact_SaleBranch_DensityProduct_Month_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Quarter_RevenueDAO> KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Week_RevenueDAO> KPI_Fact_SaleBranch_DensityProduct_Week_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Year_RevenueDAO> KPI_Fact_SaleBranch_DensityProduct_Year_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1DAO> KPI_Fact_SaleInRevenueC1 { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1NewProductDAO> KPI_Fact_SaleInRevenueC1NewProduct { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1NewProduct_PlanDAO> KPI_Fact_SaleInRevenueC1NewProduct_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1_PlanDAO> KPI_Fact_SaleInRevenueC1_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueReceiptDAO> KPI_Fact_SaleInRevenueReceipt { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueReceipt_PlanDAO> KPI_Fact_SaleInRevenueReceipt_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutImageCountDAO> KPI_Fact_SaleOutImageCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutImageCount_PlanDAO> KPI_Fact_SaleOutImageCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutNewStoreCount_PlanDAO> KPI_Fact_SaleOutNewStoreCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutProblemCount_PlanDAO> KPI_Fact_SaleOutProblemCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueDAO> KPI_Fact_SaleOutRevenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2SL_PlanDAO> KPI_Fact_SaleOutRevenueC2SL_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2Sum_PlanDAO> KPI_Fact_SaleOutRevenueC2Sum_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2TD_PlanDAO> KPI_Fact_SaleOutRevenueC2TD_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2_PlanDAO> KPI_Fact_SaleOutRevenueC2_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCheckingCountDAO> KPI_Fact_SaleOutStoreCheckingCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCheckingCount_PlanDAO> KPI_Fact_SaleOutStoreCheckingCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCountDAO> KPI_Fact_SaleOutStoreCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCount_PlanDAO> KPI_Fact_SaleOutStoreCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Month_PlanDAO> KPI_Fact_SaleOut_Month_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Quarter_PlanDAO> KPI_Fact_SaleOut_Quarter_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Year_PlanDAO> KPI_Fact_SaleOut_Year_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Month_RevenueDAO> KPI_Fact_SaleRoom_DensityProduct_Month_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Quarter_RevenueDAO> KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Week_RevenueDAO> KPI_Fact_SaleRoom_DensityProduct_Week_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Year_RevenueDAO> KPI_Fact_SaleRoom_DensityProduct_Year_Revenue { get; set; }
        public virtual DbSet<KPI_Incur_RevenueDAO> KPI_Incur_Revenue { get; set; }
        public virtual DbSet<KPI_LEDGroup_RevenueDAO> KPI_LEDGroup_Revenue { get; set; }
        public virtual DbSet<KPI_LED_GTGT_RevenueDAO> KPI_LED_GTGT_Revenue { get; set; }
        public virtual DbSet<KPI_LED_NewItem_RevenueDAO> KPI_LED_NewItem_Revenue { get; set; }
        public virtual DbSet<KPI_LED_SmartGroup_RevenueDAO> KPI_LED_SmartGroup_Revenue { get; set; }
        public virtual DbSet<KPI_PremiumThermosGroup_RevenueDAO> KPI_PremiumThermosGroup_Revenue { get; set; }
        public virtual DbSet<KPI_Raw_SaleEmployeeMappingDAO> KPI_Raw_SaleEmployeeMapping { get; set; }
        public virtual DbSet<KPI_Raw_SaleInCountyMappingDAO> KPI_Raw_SaleInCountyMapping { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueC1NewProduct_PlanDAO> KPI_Raw_SaleInRevenueC1NewProduct_Plan { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueReceiptDAO> KPI_Raw_SaleInRevenueReceipt { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueReceipt_PlanDAO> KPI_Raw_SaleInRevenueReceipt_Plan { get; set; }
        public virtual DbSet<KPI_ThermosGroup_RevenueDAO> KPI_ThermosGroup_Revenue { get; set; }
        public virtual DbSet<ListDAO> List { get; set; }
        public virtual DbSet<Log_TableDAO> Log_Table { get; set; }
        public virtual DbSet<MenuDAO> Menu { get; set; }
        public virtual DbSet<NCTT_Dim_ItemCharacteristicDAO> NCTT_Dim_ItemCharacteristic { get; set; }
        public virtual DbSet<NCTT_Dim_ItemClassDAO> NCTT_Dim_ItemClass { get; set; }
        public virtual DbSet<NCTT_Dim_ItemGroupDAO> NCTT_Dim_ItemGroup { get; set; }
        public virtual DbSet<NCTT_Dim_ItemLineDAO> NCTT_Dim_ItemLine { get; set; }
        public virtual DbSet<NCTT_Dim_ItemMappingDAO> NCTT_Dim_ItemMapping { get; set; }
        public virtual DbSet<NCTT_Dim_ItemPropertyDetailDAO> NCTT_Dim_ItemPropertyDetail { get; set; }
        public virtual DbSet<NCTT_Dim_ItemPropertyGroupDAO> NCTT_Dim_ItemPropertyGroup { get; set; }
        public virtual DbSet<NCTT_Dim_ItemTypeDAO> NCTT_Dim_ItemType { get; set; }
        public virtual DbSet<NCTT_Fact_CountyScopeDAO> NCTT_Fact_CountyScope { get; set; }
        public virtual DbSet<NCTT_Fact_KPI_SaleOut_PlanDAO> NCTT_Fact_KPI_SaleOut_Plan { get; set; }
        public virtual DbSet<NCTT_Fact_KPI_SaleOut_RevenueDAO> NCTT_Fact_KPI_SaleOut_Revenue { get; set; }
        public virtual DbSet<NCTT_Fact_RevenueDAO> NCTT_Fact_Revenue { get; set; }
        public virtual DbSet<NCTT_Raw_CountyScopeDAO> NCTT_Raw_CountyScope { get; set; }
        public virtual DbSet<NCTT_Raw_NewItemDAO> NCTT_Raw_NewItem { get; set; }
        public virtual DbSet<NCTT_Raw_PBH1_PBH2DAO> NCTT_Raw_PBH1_PBH2 { get; set; }
        public virtual DbSet<NCTT_Raw_ProductGroupDAO> NCTT_Raw_ProductGroup { get; set; }
        public virtual DbSet<NCTT_Raw_ProductGroup_TempDAO> NCTT_Raw_ProductGroup_Temp { get; set; }
        public virtual DbSet<PageDAO> Page { get; set; }
        public virtual DbSet<PermissionDAO> Permission { get; set; }
        public virtual DbSet<PermissionActionMappingDAO> PermissionActionMapping { get; set; }
        public virtual DbSet<PermissionContentDAO> PermissionContent { get; set; }
        public virtual DbSet<PermissionOperatorDAO> PermissionOperator { get; set; }
        public virtual DbSet<Raw_A009DAO> Raw_A009 { get; set; }
        public virtual DbSet<Raw_A012DAO> Raw_A012 { get; set; }
        public virtual DbSet<Raw_ActualReportDAO> Raw_ActualReport { get; set; }
        public virtual DbSet<Raw_ActualReportCloneDAO> Raw_ActualReportClone { get; set; }
        public virtual DbSet<Raw_ActualReport_T4DAO> Raw_ActualReport_T4 { get; set; }
        public virtual DbSet<Raw_B003DAO> Raw_B003 { get; set; }
        public virtual DbSet<Raw_B1_1_IncurReport_RepDAO> Raw_B1_1_IncurReport_Rep { get; set; }
        public virtual DbSet<Raw_B1_1_IncurReport_Rep_TestDAO> Raw_B1_1_IncurReport_Rep_Test { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_Rep_TestDAO> Raw_B1_5_ActualExportReport_Rep_Test { get; set; }
        public virtual DbSet<Raw_C4LED_Revenue_MonthDAO> Raw_C4LED_Revenue_Month { get; set; }
        public virtual DbSet<Raw_C4LED_Revenue_WeekDAO> Raw_C4LED_Revenue_Week { get; set; }
        public virtual DbSet<Raw_C4LED_SalePlan_MonthDAO> Raw_C4LED_SalePlan_Month { get; set; }
        public virtual DbSet<Raw_C4LED_SalePlan_QuarterDAO> Raw_C4LED_SalePlan_Quarter { get; set; }
        public virtual DbSet<Raw_C4LED_SalePlan_YearDAO> Raw_C4LED_SalePlan_Year { get; set; }
        public virtual DbSet<Raw_Customer_RepDAO> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Customer_TempDAO> Raw_Customer_Temp { get; set; }
        public virtual DbSet<Raw_EmployeeDAO> Raw_Employee { get; set; }
        public virtual DbSet<Raw_IncurReportDAO> Raw_IncurReport { get; set; }
        public virtual DbSet<Raw_IncurReport_T4DAO> Raw_IncurReport_T4 { get; set; }
        public virtual DbSet<Raw_Item_RepDAO> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Item_TempDAO> Raw_Item_Temp { get; set; }
        public virtual DbSet<Raw_KPI_ProductProductGroupOrgPeriodDAO> Raw_KPI_ProductProductGroupOrgPeriod { get; set; }
        public virtual DbSet<Raw_KeyCustomerDAO> Raw_KeyCustomer { get; set; }
        public virtual DbSet<Raw_Location_RepDAO> Raw_Location_Rep { get; set; }
        public virtual DbSet<Raw_MainBusinessDAO> Raw_MainBusiness { get; set; }
        public virtual DbSet<Raw_MinimumInventoryDAO> Raw_MinimumInventory { get; set; }
        public virtual DbSet<Raw_ProductGroupDAO> Raw_ProductGroup { get; set; }
        public virtual DbSet<Raw_Product_GroupingDAO> Raw_Product_Grouping { get; set; }
        public virtual DbSet<Raw_Product_ProductGroupDAO> Raw_Product_ProductGroup { get; set; }
        public virtual DbSet<Raw_Product_SalePlanDAO> Raw_Product_SalePlan { get; set; }
        public virtual DbSet<Raw_RD_EmployeeDAO> Raw_RD_Employee { get; set; }
        public virtual DbSet<Raw_SaleBranchDMSMappingDAO> Raw_SaleBranchDMSMapping { get; set; }
        public virtual DbSet<Raw_SaleEmployee_CustomerDAO> Raw_SaleEmployee_Customer { get; set; }
        public virtual DbSet<Raw_SaleIn_PlanDAO> Raw_SaleIn_Plan { get; set; }
        public virtual DbSet<Raw_SaleIn_Plan_Ver2DAO> Raw_SaleIn_Plan_Ver2 { get; set; }
        public virtual DbSet<Raw_SaleOut_PlanDAO> Raw_SaleOut_Plan { get; set; }
        public virtual DbSet<Raw_SaleOut_Plan_Ver2DAO> Raw_SaleOut_Plan_Ver2 { get; set; }
        public virtual DbSet<Raw_SalePlan_RevenueDAO> Raw_SalePlan_Revenue { get; set; }
        public virtual DbSet<Raw_SaleUnit_SalePlan_QuantityDAO> Raw_SaleUnit_SalePlan_Quantity { get; set; }
        public virtual DbSet<Raw_SaleUnit_SalePlan_RevenueDAO> Raw_SaleUnit_SalePlan_Revenue { get; set; }
        public virtual DbSet<Raw_SpecializedChannelDAO> Raw_SpecializedChannel { get; set; }
        public virtual DbSet<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SpecializedChannel_SalePlan_Revenue { get; set; }
        public virtual DbSet<Raw_TeamSale_CustomerDAO> Raw_TeamSale_Customer { get; set; }
        public virtual DbSet<Raw_TeamSale_EmployeeDAO> Raw_TeamSale_Employee { get; set; }
        public virtual DbSet<Raw_WarehouseDAO> Raw_Warehouse { get; set; }
        public virtual DbSet<RoleDAO> Role { get; set; }
        public virtual DbSet<SchemaDAO> Schema { get; set; }
        public virtual DbSet<ServerDAO> Server { get; set; }
        public virtual DbSet<SetDAO> Set { get; set; }
        public virtual DbSet<StateDAO> State { get; set; }
        public virtual DbSet<StatusDAO> Status { get; set; }
        public virtual DbSet<TMDT_Dim_CityDAO> TMDT_Dim_City { get; set; }
        public virtual DbSet<TMDT_Dim_CustomerDAO> TMDT_Dim_Customer { get; set; }
        public virtual DbSet<TMDT_Dim_OrderSourceDAO> TMDT_Dim_OrderSource { get; set; }
        public virtual DbSet<TMDT_Dim_OrderStatusDAO> TMDT_Dim_OrderStatus { get; set; }
        public virtual DbSet<TMDT_Dim_ProcessingDepartmentDAO> TMDT_Dim_ProcessingDepartment { get; set; }
        public virtual DbSet<TMDT_Fact_OrderDAO> TMDT_Fact_Order { get; set; }
        public virtual DbSet<TMDT_Raw_OrderDAO> TMDT_Raw_Order { get; set; }
        public virtual DbSet<test_pathDAO> test_path { get; set; }

        public DWEContext(DbContextOptions<DWEContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=192.168.20.200;initial catalog=dwe;persist security info=True;user id=TTS_Data;password=1234567;multipleactiveresultsets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "db_datareader");

            modelBuilder.Entity<ActionDAO>(entity =>
            {
                entity.ToTable("Action", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Actions)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Action_Menu");
            });

            modelBuilder.Entity<ActionPageMappingDAO>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.PageId });

                entity.ToTable("ActionPageMapping", "PER");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionPageMappings)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPageMapping_Action");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.ActionPageMappings)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPageMapping_Page");
            });

            modelBuilder.Entity<AggregatedCounterDAO>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserRoleMappingDAO>(entity =>
            {
                entity.HasKey(e => new { e.AppUserId, e.RoleId })
                    .HasName("PK_UserRoleMapping");

                entity.ToTable("AppUserRoleMapping", "MDM");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.AppUserRoleMappings)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserRoleMapping_Dim_AppUser");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppUserRoleMappings)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserRoleMapping_Role");
            });

            modelBuilder.Entity<CounterDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key)
                    .HasName("CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Dim_AppUserDAO>(entity =>
            {
                entity.HasKey(e => e.AppUserId)
                    .HasName("PK_Dim_AppUser_1");

                entity.ToTable("Dim_AppUser", "DMS");

                entity.Property(e => e.AppUserId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Avatar).HasMaxLength(4000);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(500);

                entity.Property(e => e.Phone).HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_AppUserStoreMappingDAO>(entity =>
            {
                entity.HasKey(e => new { e.AppUserId, e.StoreId });

                entity.ToTable("Dim_AppUserStoreMapping", "DMS");
            });

            modelBuilder.Entity<Dim_BrandDAO>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("Dim_Brand", "DMS");

                entity.Property(e => e.BrandId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_BrandInStoreProductGroupingMappingDAO>(entity =>
            {
                entity.HasKey(e => new { e.BrandInStoreId, e.ProductGroupingId })
                    .HasName("PK_BrandInStoreProductGroupingMapping");

                entity.ToTable("Dim_BrandInStoreProductGroupingMapping", "DMS");
            });

            modelBuilder.Entity<Dim_C4LED_SaleBranchDAO>(entity =>
            {
                entity.HasKey(e => e.SaleBranchId);

                entity.ToTable("Dim_C4LED_SaleBranch", "C4LED");

                entity.Property(e => e.SaleBranchId).ValueGeneratedNever();

                entity.Property(e => e.SaleBranchName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_C4LED_SaleUnitMappingDAO>(entity =>
            {
                entity.HasKey(e => e.SaleUnitMappingId);

                entity.ToTable("Dim_C4LED_SaleUnitMapping", "C4LED");

                entity.Property(e => e.SaleUnitMappingId).ValueGeneratedNever();

                entity.Property(e => e.MappingName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_C4LED_WeekDAO>(entity =>
            {
                entity.HasKey(e => e.WeekKey);

                entity.ToTable("Dim_C4LED_Week", "C4LED");

                entity.Property(e => e.WeekKey).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MonthName).HasMaxLength(500);

                entity.Property(e => e.QuarterName).HasMaxLength(500);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WeekName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_CountryDAO>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Dim_Country", "SAP");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_CountyDAO>(entity =>
            {
                entity.HasKey(e => e.CountyId);

                entity.ToTable("Dim_County", "SAP");

                entity.Property(e => e.CountyCode).HasMaxLength(4000);

                entity.Property(e => e.CountyName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_CustomerDAO>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_Customer", "SAP");

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_CustomerC2DAO>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_CustomerC2", "DMS");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_CustomerEmployeeMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_CustomerEmployeeMapping", "RD");
            });

            modelBuilder.Entity<Dim_DateDAO>(entity =>
            {
                entity.HasKey(e => e.DateKey);

                entity.ToTable("Dim_Date", "SAP");

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_DateMappingDAO>(entity =>
            {
                entity.HasKey(e => e.DateKey);

                entity.ToTable("Dim_DateMapping", "SAP");

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Date_FilterDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Dim_Date_Filter", "SAP");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_DistrictDAO>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_Dim_Province");

                entity.ToTable("Dim_District", "DMS");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_EmployeeDAO>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Dim_Employee", "PXK");

                entity.Property(e => e.EmployeeCode).HasMaxLength(4000);

                entity.Property(e => e.EmployeeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemDAO>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_Item", "SAP");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemDMSDAO>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_ItemDMS", "DMS");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.ERPCode).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Note).HasMaxLength(3000);

                entity.Property(e => e.OtherName).HasMaxLength(1000);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ScanCode).HasMaxLength(4000);

                entity.Property(e => e.SupplierCode).HasMaxLength(500);

                entity.Property(e => e.TechnicalName).HasMaxLength(1000);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ItemGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupId)
                    .HasName("PK_Dim_ItemGroup_1");

                entity.ToTable("Dim_ItemGroup", "dbo");

                entity.Property(e => e.ItemGroupId).ValueGeneratedNever();

                entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemGroupLevelDAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevelId);

                entity.ToTable("Dim_ItemGroupLevel", "dbo");

                entity.Property(e => e.ItemGroupLevelId).ValueGeneratedNever();

                entity.Property(e => e.ItemGroupLevelName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel1DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel1Id);

                entity.ToTable("Dim_ItemGroupLevel1", "SAP");

                entity.Property(e => e.ItemGroupLevel1Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel2DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel2Id);

                entity.ToTable("Dim_ItemGroupLevel2", "SAP");

                entity.Property(e => e.ItemGroupLevel2Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel3DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel3Id);

                entity.ToTable("Dim_ItemGroupLevel3", "SAP");

                entity.Property(e => e.ItemGroupLevel3Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemLedSmartGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemLedSmartGroupId);

                entity.ToTable("Dim_ItemLedSmartGroup", "SAP");

                entity.Property(e => e.ItemLedSmartGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemMainGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemMainGroupId);

                entity.ToTable("Dim_ItemMainGroup", "SAP");

                entity.Property(e => e.ItemMainGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_ItemMapping", "SAP");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Dim_ItemMappings)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_Item");

                entity.HasOne(d => d.ItemSingleSmartGroup)
                    .WithMany(p => p.Dim_ItemMappings)
                    .HasForeignKey(d => d.ItemSingleSmartGroupId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_ItemSingleSmartGroup");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Dim_ItemMappings)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_ItemType");
            });

            modelBuilder.Entity<Dim_ItemNCTTDAO>(entity =>
            {
                entity.HasKey(e => e.NCTTId)
                    .HasName("PK_Dim_NCTT");

                entity.ToTable("Dim_ItemNCTT", "SAP");

                entity.Property(e => e.NCTTName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemNewItemGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemNewItemGroupId)
                    .HasName("PK_DIm_ItemGroup_SPMOI");

                entity.ToTable("Dim_ItemNewItemGroup", "SAP");

                entity.Property(e => e.ItemNewItemGroupName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemSingleSmartGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemSingleSmartGroupId);

                entity.ToTable("Dim_ItemSingleSmartGroup", "SAP");

                entity.Property(e => e.ItemSingleSmartGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemTypeDAO>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("Dim_ItemType", "SAP");

                entity.Property(e => e.ItemTypeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemVATGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemVATGroupId)
                    .HasName("PK_Dim_ItemGroup_SMART");

                entity.ToTable("Dim_ItemVATGroup", "SAP");

                entity.Property(e => e.ItemVATGroupName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_KPITypeDAO>(entity =>
            {
                entity.HasKey(e => e.KPITypeId)
                    .HasName("PK_Dim_DensityProduct");

                entity.ToTable("Dim_KPIType", "dbo");

                entity.Property(e => e.KPITypeId).ValueGeneratedNever();

                entity.Property(e => e.KPITypeName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_KPI_MeasureDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dim_KPI_Measure", "KPI");
            });

            modelBuilder.Entity<Dim_KPI_ProductGroupingDAO>(entity =>
            {
                entity.HasKey(e => e.ProductGroupingId);

                entity.ToTable("Dim_KPI_ProductGrouping", "MDM");

                entity.Property(e => e.ProductGroupingId).ValueGeneratedNever();

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.ProductGroupingCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProductGroupingName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_KPI_ProductGrouping_MappingDAO>(entity =>
            {
                entity.ToTable("Dim_KPI_ProductGrouping_Mapping", "KPI");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProductGroupingCode)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_LocationDAO>(entity =>
            {
                entity.ToTable("Dim_Location", "SAP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_MainBusinessDAO>(entity =>
            {
                entity.HasKey(e => e.MainBusinessId);

                entity.ToTable("Dim_MainBusiness", "SAP");

                entity.Property(e => e.MainBusinessName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_MonthDAO>(entity =>
            {
                entity.HasKey(e => e.MonthKey);

                entity.ToTable("Dim_Month", "SAP");

                entity.Property(e => e.MonthKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.MonthName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_OrganizationUnitDAO>(entity =>
            {
                entity.HasKey(e => e.OrganizationId);

                entity.ToTable("Dim_OrganizationUnit", "KPI");

                entity.Property(e => e.OrganizationCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.OrganizationGroupingLvl1).HasMaxLength(1000);

                entity.Property(e => e.OrganizationGroupingLvl2).HasMaxLength(1000);

                entity.Property(e => e.OrganizationName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_OrganizationUnitMappingDAO>(entity =>
            {
                entity.ToTable("Dim_OrganizationUnitMapping", "KPI");
            });

            modelBuilder.Entity<Dim_PeriodDAO>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Dim_Period", "KPI");

                entity.Property(e => e.PeriodId).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.MonthName).HasMaxLength(50);

                entity.Property(e => e.PeriodBIName).HasMaxLength(1000);

                entity.Property(e => e.PeriodCode).HasMaxLength(50);

                entity.Property(e => e.PeriodGroupingName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.PeriodName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.QuarterName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ProductDAO>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("Dim_Product", "DMS");

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(3000);

                entity.Property(e => e.ERPCode).HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Note).HasMaxLength(3000);

                entity.Property(e => e.OtherName).HasMaxLength(1000);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ScanCode).HasMaxLength(500);

                entity.Property(e => e.SupplierCode).HasMaxLength(500);

                entity.Property(e => e.TechnicalName).HasMaxLength(1000);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ProductMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_ProductMapping", "RD");
            });

            modelBuilder.Entity<Dim_ProductSaleChannelMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_ProductSaleChannelMapping", "RD");
            });

            modelBuilder.Entity<Dim_ProvinceDAO>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK_Dim_Province_1");

                entity.ToTable("Dim_Province", "DMS");

                entity.Property(e => e.ProvinceId).ValueGeneratedNever();

                entity.Property(e => e.ProvinceName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_QuarterDAO>(entity =>
            {
                entity.HasKey(e => e.QuarterKey);

                entity.ToTable("Dim_Quarter", "SAP");

                entity.Property(e => e.QuarterKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.QuarterName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_RD_CustomerDAO>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_RD_Customer", "RD");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(1000);

                entity.Property(e => e.CustomerName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RD_ItemDAO>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_RD_Item", "RD");

                entity.Property(e => e.ItemId).ValueGeneratedNever();

                entity.Property(e => e.ItemCode).HasMaxLength(1000);

                entity.Property(e => e.ItemName).HasMaxLength(1000);

                entity.Property(e => e.LightColor).HasMaxLength(1000);

                entity.Property(e => e.Performance).HasMaxLength(1000);

                entity.Property(e => e.Quality).HasMaxLength(1000);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Dim_RD_ItemGroupLevel1DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel1Id);

                entity.ToTable("Dim_RD_ItemGroupLevel1", "RD");

                entity.Property(e => e.ItemGroupLevel1Name).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RD_ItemGroupLevel2DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel2Id);

                entity.ToTable("Dim_RD_ItemGroupLevel2", "RD");

                entity.Property(e => e.ItemGroupLevel2Name).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RD_SaleChannelDAO>(entity =>
            {
                entity.HasKey(e => e.SaleChannelId);

                entity.ToTable("Dim_RD_SaleChannel", "RD");

                entity.Property(e => e.SaleChannelName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RD_SaleEmployeeDAO>(entity =>
            {
                entity.HasKey(e => e.EmployeeId)
                    .HasName("PK_Dim_SaleEmployee");

                entity.ToTable("Dim_RD_SaleEmployee", "RD");

                entity.Property(e => e.EmployeeCode).HasMaxLength(1000);

                entity.Property(e => e.EmployeeName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RegionDAO>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("Dim_Region", "RD");

                entity.Property(e => e.RegionName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_SaleArrayDAO>(entity =>
            {
                entity.HasKey(e => e.SaleArrayId);

                entity.ToTable("Dim_SaleArray", "C4LED");

                entity.Property(e => e.SaleArrayId).ValueGeneratedNever();

                entity.Property(e => e.SaleArrayName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleBranchDAO>(entity =>
            {
                entity.HasKey(e => e.SaleBranchId);

                entity.ToTable("Dim_SaleBranch", "SAP");

                entity.Property(e => e.DMS_Name).HasMaxLength(500);

                entity.Property(e => e.SaleBranchCode).HasMaxLength(4000);

                entity.Property(e => e.SaleBranchName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleCenterDAO>(entity =>
            {
                entity.HasKey(e => e.SaleCenterId);

                entity.ToTable("Dim_SaleCenter", "C4LED");

                entity.Property(e => e.SaleCenterId).ValueGeneratedNever();

                entity.Property(e => e.SaleCenterName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleChannelDAO>(entity =>
            {
                entity.HasKey(e => e.SaleChannelId);

                entity.ToTable("Dim_SaleChannel", "SAP");

                entity.Property(e => e.SaleChannelName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleEmployeeDAO>(entity =>
            {
                entity.HasKey(e => e.AppUserId)
                    .HasName("PK_Dim_AppUser");

                entity.ToTable("Dim_SaleEmployee", "DMS");

                entity.Property(e => e.AppUserId)
                    .HasComment("Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasComment("Địa chỉ nhà");

                entity.Property(e => e.Avatar)
                    .HasMaxLength(4000)
                    .HasComment("Ảnh đại diện");

                entity.Property(e => e.Birthday)
                    .HasColumnType("datetime")
                    .HasComment("Ngày sinh");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày tạo");

                entity.Property(e => e.DeletedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày xoá");

                entity.Property(e => e.Department)
                    .HasMaxLength(500)
                    .HasComment("Phòng ban");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(500)
                    .HasComment("Tên hiển thị");

                entity.Property(e => e.Email)
                    .HasMaxLength(500)
                    .HasComment("Địa chỉ email");

                entity.Property(e => e.OrganizationId).HasComment("Đơn vị công tác");

                entity.Property(e => e.Phone)
                    .HasMaxLength(500)
                    .HasComment("Số điện thoại liên hệ");

                entity.Property(e => e.RowId).HasComment("Trường để đồng bộ");

                entity.Property(e => e.StatusId).HasComment("Trạng thái");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnType("datetime")
                    .HasComment("Ngày cập nhật");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasComment("Tên đăng nhập");
            });

            modelBuilder.Entity<Dim_SaleEntityDAO>(entity =>
            {
                entity.HasKey(e => e.SaleEntityId);

                entity.ToTable("Dim_SaleEntity", "PKH");

                entity.Property(e => e.SaleEntityName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.SaleParent)
                    .WithMany(p => p.InverseSaleParent)
                    .HasForeignKey(d => d.SaleParentId)
                    .HasConstraintName("FK_Dim_SaleEntity_Dim_SaleEntity");
            });

            modelBuilder.Entity<Dim_SaleFieldDAO>(entity =>
            {
                entity.HasKey(e => e.SaleFieldId);

                entity.ToTable("Dim_SaleField", "C4LED");

                entity.Property(e => e.SaleFieldId).ValueGeneratedNever();

                entity.Property(e => e.SaleFieldName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleLevelDAO>(entity =>
            {
                entity.HasKey(e => e.SaleLevelId)
                    .HasName("PK_Dim_Type");

                entity.ToTable("Dim_SaleLevel", "DMS");

                entity.Property(e => e.SaleLevelId).ValueGeneratedNever();

                entity.Property(e => e.SaleLevelName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleRoomDAO>(entity =>
            {
                entity.HasKey(e => e.SaleRoomId);

                entity.ToTable("Dim_SaleRoom", "SAP");

                entity.Property(e => e.SaleRoomCode).HasMaxLength(4000);

                entity.Property(e => e.SaleRoomName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleUnitDAO>(entity =>
            {
                entity.HasKey(e => e.SaleUnitId);

                entity.ToTable("Dim_SaleUnit", "C4LED");

                entity.Property(e => e.SaleUnitId).ValueGeneratedNever();

                entity.Property(e => e.SaleUnitName)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleUnitMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_SaleUnitMapping", "SAP");
            });

            modelBuilder.Entity<Dim_SpecializedChannelMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_SpecializedChannelMapping", "RD");
            });

            modelBuilder.Entity<Dim_StoreDAO>(entity =>
            {
                entity.HasKey(e => e.StoreId);

                entity.ToTable("Dim_Store", "DMS");

                entity.Property(e => e.StoreId).ValueGeneratedNever();

                entity.Property(e => e.Address).HasMaxLength(3000);

                entity.Property(e => e.Code).HasMaxLength(400);

                entity.Property(e => e.CodeDraft).HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryAddress).HasMaxLength(3000);

                entity.Property(e => e.DeliveryLatitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.DeliveryLongitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.LegalEntity).HasMaxLength(500);

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.OwnerEmail).HasMaxLength(500);

                entity.Property(e => e.OwnerName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OwnerPhone)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.TaxCode).HasMaxLength(500);

                entity.Property(e => e.Telephone).HasMaxLength(500);

                entity.Property(e => e.UnsignAddress).HasMaxLength(3000);

                entity.Property(e => e.UnsignName).HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_StoreGroupingDAO>(entity =>
            {
                entity.HasKey(e => e.StoreGroupingId);

                entity.ToTable("Dim_StoreGrouping", "DMS");

                entity.Property(e => e.StoreGroupingId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_StoreMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_StoreMapping", "DMS");
            });

            modelBuilder.Entity<Dim_StoreTypeDAO>(entity =>
            {
                entity.HasKey(e => e.StoreTypeId);

                entity.ToTable("Dim_StoreType", "DMS");

                entity.Property(e => e.StoreTypeId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Targets_SaleInDAO>(entity =>
            {
                entity.HasKey(e => e.TargetSaleInId);

                entity.ToTable("Dim_Targets_SaleIn", "KPI");

                entity.Property(e => e.TargetCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TargetGroupingName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TargetName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_Targets_SaleOutDAO>(entity =>
            {
                entity.HasKey(e => e.TargetSaleOutId);

                entity.ToTable("Dim_Targets_SaleOut", "KPI");

                entity.Property(e => e.TargetCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TargetGroupingName)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TargetName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_TeamSale_CustomerDAO>(entity =>
            {
                entity.ToTable("Dim_TeamSale_Customer", "KPI");
            });

            modelBuilder.Entity<Dim_WarehouseDAO>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.ToTable("Dim_Warehouse", "SAP");

                entity.Property(e => e.Location).HasMaxLength(4000);

                entity.Property(e => e.WarehouseLevel1Name).HasMaxLength(4000);

                entity.Property(e => e.WarehouseLevel2Name).HasMaxLength(4000);

                entity.Property(e => e.WhsBranchName).HasMaxLength(4000);

                entity.Property(e => e.WhsCode).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_WeekDAO>(entity =>
            {
                entity.HasKey(e => e.WeekKey);

                entity.ToTable("Dim_Week", "SAP");

                entity.Property(e => e.WeekKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");

                entity.Property(e => e.WeekName).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_YearDAO>(entity =>
            {
                entity.ToTable("Dim_Year", "SAP");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_Actual_RevenueDAO>(entity =>
            {
                entity.ToTable("Fact_Actual_Revenue", "SAP");

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_BrandInStoreDAO>(entity =>
            {
                entity.HasKey(e => e.BrandInStoreId)
                    .HasName("PK_BrandInStore");

                entity.ToTable("Fact_BrandInStore", "DMS");

                entity.Property(e => e.BrandInStoreId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_C4LED_Revenue_MonthDAO>(entity =>
            {
                entity.ToTable("Fact_C4LED_Revenue_Month", "C4LED");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_C4LED_Revenue_WeekDAO>(entity =>
            {
                entity.ToTable("Fact_C4LED_Revenue_Week", "C4LED");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_C4LED_SalePlan_MonthDAO>(entity =>
            {
                entity.ToTable("Fact_C4LED_SalePlan_Month", "C4LED");

                entity.Property(e => e.Plan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_C4LED_SalePlan_QuarterDAO>(entity =>
            {
                entity.ToTable("Fact_C4LED_SalePlan_Quarter", "C4LED");

                entity.Property(e => e.Plan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_C4LED_SalePlan_YearDAO>(entity =>
            {
                entity.ToTable("Fact_C4LED_SalePlan_Year", "C4LED");

                entity.Property(e => e.Plan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Company_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Company_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Company_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Country_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Country_Month_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Country_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Country_Quarter_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Country_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Country_Year_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_County_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_County_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_County_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Employee_Month_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Employee_Quarter_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Employee_Year_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Incur_RevenueDAO>(entity =>
            {
                entity.ToTable("Fact_Incur_Revenue", "SAP");

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_IndirectSalesOrderDAO>(entity =>
            {
                entity.HasKey(e => e.IndirectSalesOrderId);

                entity.ToTable("Fact_IndirectSalesOrder", "DMS");

                entity.Property(e => e.IndirectSalesOrderId).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.GeneralDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountPercentage).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TotalDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_IndirectSalesOrderStoreGroupingMappingDAO>(entity =>
            {
                entity.HasKey(e => e.IndirectSalesOrderStoreGroupingId)
                    .HasName("PK_Dim_IndirectSalesOrderStoreGroupingMapping");

                entity.ToTable("Fact_IndirectSalesOrderStoreGroupingMapping", "DMS");
            });

            modelBuilder.Entity<Fact_IndirectSalesOrderTransactionDAO>(entity =>
            {
                entity.HasKey(e => new { e.IndirectSalesOrderTransactionId, e.IndirectSalesOrderId, e.TransactionTypeId });

                entity.ToTable("Fact_IndirectSalesOrderTransaction", "DMS");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GeneralDiscountPercentage).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.RequestedQuantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.SalePrice).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TaxPercentage).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Fact_Item_MinimumInventoryDAO>(entity =>
            {
                entity.ToTable("Fact_Item_MinimumInventory", "SAP");

                entity.Property(e => e.MinInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Item_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleUnit).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_Item_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleUnit).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_Item_Whs_ConsignmentDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Whs_Consignment", "RD");

                entity.Property(e => e.Consignment).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Item_Whs_InventoryDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Whs_Inventory", "SAP");
            });

            modelBuilder.Entity<Fact_Item_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_KPI_IndirectSalesOrderDAO>(entity =>
            {
                entity.ToTable("Fact_KPI_IndirectSalesOrder", "KPI");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_KPI_ProductGroupingItemDAO>(entity =>
            {
                entity.ToTable("Fact_KPI_ProductGroupingItem", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Fact_KPI_StoreCheckingDAO>(entity =>
            {
                entity.ToTable("Fact_KPI_StoreChecking", "KPI");

                entity.Property(e => e.CheckOutAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_KPI_StoreTypeHistoryDAO>(entity =>
            {
                entity.ToTable("Fact_KPI_StoreTypeHistory", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PreviousCreatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_MainBusiness_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_RevenueDAO>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Revenue", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_MonthDAO>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Month", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_QuarterDAO>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Quarter", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_YearDAO>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Year", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_ProductGroupingDAO>(entity =>
            {
                entity.ToTable("Fact_ProductGrouping", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_RD_Customer_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_Customer_Month_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_Customer_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_Customer_Quarter_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_Customer_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_Customer_Year_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannel_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannel_Month_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannel_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannel_Quarter_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannel_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannel_Year_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Region_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Region_Month_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Region_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Region_Quarter_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Region_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Region_Year_Plan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RevenueCustomerC2DAO>(entity =>
            {
                entity.ToTable("Fact_RevenueCustomerC2", "DMS");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleInRevenueDAO>(entity =>
            {
                entity.ToTable("Fact_SaleInRevenue", "KPI");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleIn_ActualRevenueDAO>(entity =>
            {
                entity.ToTable("Fact_SaleIn_ActualRevenue", "KPI");
            });

            modelBuilder.Entity<Fact_SaleIn_IncurRevenueDAO>(entity =>
            {
                entity.ToTable("Fact_SaleIn_IncurRevenue", "KPI");
            });

            modelBuilder.Entity<Fact_SaleIn_KpiCollectionResultDAO>(entity =>
            {
                entity.ToTable("Fact_SaleIn_KpiCollectionResult", "KPI");

                entity.Property(e => e.Evaluation).HasMaxLength(50);

                entity.Property(e => e.Planned).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Result).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleOutRevenueDAO>(entity =>
            {
                entity.ToTable("Fact_SaleOutRevenue", "KPI");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleOut_KpiCollectionResultDAO>(entity =>
            {
                entity.ToTable("Fact_SaleOut_KpiCollectionResult", "KPI");

                entity.Property(e => e.Evaluation).HasMaxLength(50);

                entity.Property(e => e.Planned).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Result).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Quarter_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Week_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Week_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Year_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_StoreCheckingDAO>(entity =>
            {
                entity.HasKey(e => e.StoreCheckingId);

                entity.ToTable("Fact_StoreChecking", "DMS");

                entity.Property(e => e.StoreCheckingId).ValueGeneratedNever();

                entity.Property(e => e.CheckInAt).HasColumnType("datetime");

                entity.Property(e => e.CheckOutAt).HasColumnType("datetime");

                entity.Property(e => e.CheckOutLatitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.CheckOutLongitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.DeviceName).HasMaxLength(200);

                entity.Property(e => e.Latitude).HasColumnType("decimal(18, 15)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(18, 15)");
            });

            modelBuilder.Entity<Fact_TeamSale_EmployeeDAO>(entity =>
            {
                entity.ToTable("Fact_TeamSale_Employee", "KPI");

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<FieldDAO>(entity =>
            {
                entity.ToTable("Field", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Field_FieldType");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Fields)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionField_Menu");
            });

            modelBuilder.Entity<FieldTypeDAO>(entity =>
            {
                entity.ToTable("FieldType", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HashDAO>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<ItemGroupDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemGroup", "dbo");

                entity.Property(e => e.ItemGroupName).HasMaxLength(500);

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<JobDAO>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameterDAO>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueueDAO>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<KPIPlanSaleInDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPIPlanSaleIn", "dbo");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPIRevenueSaleInDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPIRevenueSaleIn", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(23, 4)");
            });

            modelBuilder.Entity<KPI_Actual_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Actual_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_CompleteThermosGroup_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_CompleteThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Dim_SaleEmployeeMappingDAO>(entity =>
            {
                entity.ToTable("KPI_Dim_SaleEmployeeMapping", "NCTT");

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<KPI_Dim_SaleInKPIDAO>(entity =>
            {
                entity.HasKey(e => e.KPIId)
                    .HasName("PK_NCTT_Dim_KPI");

                entity.ToTable("KPI_Dim_SaleInKPI", "NCTT");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<KPI_Dim_SaleOutKPIDAO>(entity =>
            {
                entity.HasKey(e => e.KPIId);

                entity.ToTable("KPI_Dim_SaleOutKPI", "NCTT");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<KPI_Fact_Result_Planned_GeneralDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_Result_Planned_General", "NCTT");

                entity.Property(e => e.Planned).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Result).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Month_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Month_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Quarter_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Week_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Week_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Year_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Year_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1DAO>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Level1_RevenueId)
                    .HasName("PK_SaleIn_Level1_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueC1", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1NewProductDAO>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Level1NewItem_RevenueId)
                    .HasName("PK_SaleIn_Level1NewItem_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueC1NewProduct", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1NewProduct_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueC1NewProduct_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueC1_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueReceiptDAO>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Receipt_RevenueId)
                    .HasName("PK_NCTT_Fact_SaleIn_Receipt_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueReceipt", "NCTT");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueReceipt_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueReceipt_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutImageCountDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutImageCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutImageCount_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutImageCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutNewStoreCount_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutNewStoreCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutProblemCount_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutProblemCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenue", "NCTT");

                entity.Property(e => e.Action).HasMaxLength(4000);

                entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2SL_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2SL_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2Sum_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2Sum_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2TD_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2TD_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCheckingCountDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCheckingCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCheckingCount_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCheckingCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCountDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCount_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Month_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Month_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Quarter_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Year_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Year_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Month_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Month_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Quarter_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Week_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Week_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Year_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Year_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Incur_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Incur_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LEDGroup_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LEDGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_GTGT_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_GTGT_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_NewItem_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_NewItem_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_SmartGroup_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_SmartGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_PremiumThermosGroup_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_PremiumThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Raw_SaleEmployeeMappingDAO>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleEmployeeMapping", "NCTT");

                entity.Property(e => e.Country).HasMaxLength(500);

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.SaleBranch).HasMaxLength(500);

                entity.Property(e => e.SaleChannel).HasMaxLength(500);

                entity.Property(e => e.SaleEmployeeCode)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SaleEmployeeName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SaleRoom)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<KPI_Raw_SaleInCountyMappingDAO>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInCountyMapping", "NCTT");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);

                entity.Property(e => e.CountyCode).HasMaxLength(4000);

                entity.Property(e => e.CountyName).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);

                entity.Property(e => e.SaleBranch).HasMaxLength(4000);

                entity.Property(e => e.SaleChannel).HasMaxLength(4000);

                entity.Property(e => e.SaleRoom).HasMaxLength(4000);
            });

            modelBuilder.Entity<KPI_Raw_SaleInRevenueC1NewProduct_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueC1NewProduct_Plan", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Raw_SaleInRevenueReceiptDAO>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueReceipt", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Raw_SaleInRevenueReceipt_PlanDAO>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueReceipt_Plan", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_ThermosGroup_RevenueDAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_ThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<ListDAO>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Log_TableDAO>(entity =>
            {
                entity.ToTable("Log_Table", "dbo");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Duration).HasMaxLength(4000);

                entity.Property(e => e.Source).HasMaxLength(4000);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(4000);

                entity.Property(e => e.TimeDAOtoEntityLocal).HasMaxLength(4000);

                entity.Property(e => e.TimeDAOtoEntityRemote).HasMaxLength(4000);

                entity.Property(e => e.TimeGetLocal).HasMaxLength(4000);

                entity.Property(e => e.TimeGetRemote).HasMaxLength(4000);

                entity.Property(e => e.TimeToDelete).HasMaxLength(4000);

                entity.Property(e => e.TimeToInsert).HasMaxLength(4000);

                entity.Property(e => e.TimeToRunSplit).HasMaxLength(4000);

                entity.Property(e => e.TimeToUpdate).HasMaxLength(4000);
            });

            modelBuilder.Entity<MenuDAO>(entity =>
            {
                entity.ToTable("Menu", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(3000);

                entity.Property(e => e.Path).HasMaxLength(3000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemCharacteristicDAO>(entity =>
            {
                entity.HasKey(e => e.ItemCharacteristicId);

                entity.ToTable("NCTT_Dim_ItemCharacteristic", "NCTT");

                entity.Property(e => e.ItemCharacteristicName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemClassDAO>(entity =>
            {
                entity.HasKey(e => e.ItemClassId)
                    .HasName("PK_Dim_ItemClass");

                entity.ToTable("NCTT_Dim_ItemClass", "NCTT");

                entity.Property(e => e.ItemClassName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupId)
                    .HasName("PK_Dim_ItemGroup");

                entity.ToTable("NCTT_Dim_ItemGroup", "NCTT");

                entity.Property(e => e.ItemGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemLineDAO>(entity =>
            {
                entity.HasKey(e => e.ItemLineId)
                    .HasName("PK_Dim_ItemLine");

                entity.ToTable("NCTT_Dim_ItemLine", "NCTT");

                entity.Property(e => e.ItemLineName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemMappingDAO>(entity =>
            {
                entity.HasKey(e => e.ItemMappingId)
                    .HasName("PK_Dim_ItemMapping_1");

                entity.ToTable("NCTT_Dim_ItemMapping", "NCTT");
            });

            modelBuilder.Entity<NCTT_Dim_ItemPropertyDetailDAO>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyId)
                    .HasName("PK_Dim_ItemPropertyDetail");

                entity.ToTable("NCTT_Dim_ItemPropertyDetail", "NCTT");

                entity.Property(e => e.ItemPropertyName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemPropertyGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyGroupId)
                    .HasName("PK_Dim_ItemPropertyGroup");

                entity.ToTable("NCTT_Dim_ItemPropertyGroup", "NCTT");

                entity.Property(e => e.ItemPropertyGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemTypeDAO>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("NCTT_Dim_ItemType", "NCTT");

                entity.Property(e => e.ItemTypeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Fact_CountyScopeDAO>(entity =>
            {
                entity.HasKey(e => e.CountyScopeId)
                    .HasName("PK_NCTT_Fact_CityProperty");

                entity.ToTable("NCTT_Fact_CountyScope", "NCTT");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FDI).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GRDP).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UrbanizationRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Fact_KPI_SaleOut_PlanDAO>(entity =>
            {
                entity.ToTable("NCTT_Fact_KPI_SaleOut_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NCTT_Fact_KPI_SaleOut_RevenueDAO>(entity =>
            {
                entity.ToTable("NCTT_Fact_KPI_SaleOut_Revenue", "NCTT");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NCTT_Fact_RevenueDAO>(entity =>
            {
                entity.ToTable("NCTT_Fact_Revenue", "NCTT");

                entity.Property(e => e.OrderId).HasMaxLength(4000);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Raw_CountyScopeDAO>(entity =>
            {
                entity.ToTable("NCTT_Raw_CountyScope", "NCTT");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.County).HasMaxLength(4000);

                entity.Property(e => e.FDI).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GRDP).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UrbanizationRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Raw_NewItemDAO>(entity =>
            {
                entity.ToTable("NCTT_Raw_NewItem", "NCTT");

                entity.Property(e => e.ItemCode).HasMaxLength(500);

                entity.Property(e => e.ItemName).HasMaxLength(500);
            });

            modelBuilder.Entity<NCTT_Raw_PBH1_PBH2DAO>(entity =>
            {
                entity.ToTable("NCTT_Raw_PBH1_PBH2", "NCTT");

                entity.Property(e => e.Chung_loai).HasMaxLength(4000);

                entity.Property(e => e.Cong_suat).HasMaxLength(4000);

                entity.Property(e => e.Dac_tinh).HasMaxLength(4000);

                entity.Property(e => e.Dai_ly_tieu_thu).HasMaxLength(4000);

                entity.Property(e => e.Doi_tuong_KH).HasMaxLength(4000);

                entity.Property(e => e.Don_vi_tieu_thu).HasMaxLength(4000);

                entity.Property(e => e.Dong_san_pham).HasMaxLength(4000);

                entity.Property(e => e.Kenh_ban).HasMaxLength(4000);

                entity.Property(e => e.Kieu_dang).HasMaxLength(4000);

                entity.Property(e => e.Loai).HasMaxLength(4000);

                entity.Property(e => e.Lop_san_pham).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_TP).HasMaxLength(4000);

                entity.Property(e => e.Ma_don).HasMaxLength(4000);

                entity.Property(e => e.Ma_san_pham).HasMaxLength(4000);

                entity.Property(e => e.Mien).HasMaxLength(4000);

                entity.Property(e => e.Ngay).HasColumnType("datetime");

                entity.Property(e => e.Nhom_san_pham).HasMaxLength(4000);

                entity.Property(e => e.PBH).HasMaxLength(4000);

                entity.Property(e => e.So_luong).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Ten_nhan_vien_phu_trach_dai_ly).HasMaxLength(4000);

                entity.Property(e => e.Ten_san_pham).HasMaxLength(4000);

                entity.Property(e => e.Tinh).HasMaxLength(4000);

                entity.Property(e => e.Tinh_Qlik).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Raw_ProductGroupDAO>(entity =>
            {
                entity.ToTable("NCTT_Raw_ProductGroup", "NCTT");

                entity.Property(e => e.Chung_loai).HasMaxLength(4000);

                entity.Property(e => e.Cong_suat).HasMaxLength(4000);

                entity.Property(e => e.Dac_tinh).HasMaxLength(4000);

                entity.Property(e => e.GTGT).HasMaxLength(4000);

                entity.Property(e => e.ItemClass).HasMaxLength(4000);

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemGroup).HasMaxLength(4000);

                entity.Property(e => e.ItemLine).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Kieu_dang).HasMaxLength(4000);

                entity.Property(e => e.Loai).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Raw_ProductGroup_TempDAO>(entity =>
            {
                entity.ToTable("NCTT_Raw_ProductGroup_Temp", "NCTT");

                entity.Property(e => e.Chung_loai).HasMaxLength(4000);

                entity.Property(e => e.Cong_suat).HasMaxLength(4000);

                entity.Property(e => e.Dac_tinh).HasMaxLength(4000);

                entity.Property(e => e.GTGT).HasMaxLength(4000);

                entity.Property(e => e.ItemClass).HasMaxLength(4000);

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemGroup).HasMaxLength(4000);

                entity.Property(e => e.ItemLine).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Kieu_dang).HasMaxLength(4000);

                entity.Property(e => e.Loai).HasMaxLength(4000);
            });

            modelBuilder.Entity<PageDAO>(entity =>
            {
                entity.ToTable("Page", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Page_Menu");
            });

            modelBuilder.Entity<PermissionDAO>(entity =>
            {
                entity.ToTable("Permission", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Menu");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Role");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Status");
            });

            modelBuilder.Entity<PermissionActionMappingDAO>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.PermissionId })
                    .HasName("PK_ActionPermissionMapping");

                entity.ToTable("PermissionActionMapping", "PER");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.PermissionActionMappings)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPermissionMapping_Action");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionActionMappings)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPermissionMapping_Permission");
            });

            modelBuilder.Entity<PermissionContentDAO>(entity =>
            {
                entity.ToTable("PermissionContent", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.PermissionContents)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_Field");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionContents)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_Permission");

                entity.HasOne(d => d.PermissionOperator)
                    .WithMany(p => p.PermissionContents)
                    .HasForeignKey(d => d.PermissionOperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_PermissionOperator");
            });

            modelBuilder.Entity<PermissionOperatorDAO>(entity =>
            {
                entity.ToTable("PermissionOperator", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.PermissionOperators)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionOperator_FieldType");
            });

            modelBuilder.Entity<Raw_A009DAO>(entity =>
            {
                entity.ToTable("Raw_A009", "SAP");

                entity.Property(e => e.HangGui).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.Loai_SP).HasMaxLength(500);

                entity.Property(e => e.Nhap).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NhapLKThang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nhom_SP).HasMaxLength(500);

                entity.Property(e => e.TenThuKho).HasMaxLength(500);

                entity.Property(e => e.ThucXuat).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ThucXuatLKThang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TonChungTu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TonThucTe).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.WhsCode).HasMaxLength(50);

                entity.Property(e => e.XuatBan).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XuatBanLKThang).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XuatChungTu).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.XuatChungTuLKThang).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Raw_A012DAO>(entity =>
            {
                entity.ToTable("Raw_A012", "SAP");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.P0000_GiaCoSo).HasMaxLength(1000);

                entity.Property(e => e.P0001_GiaXuatChoChiNhanh).HasMaxLength(1000);

                entity.Property(e => e.P0002_Price_Level1).HasMaxLength(4000);

                entity.Property(e => e.P0003_GiaC1MN).HasMaxLength(1000);

                entity.Property(e => e.P0004_GiaC2MN).HasMaxLength(1000);

                entity.Property(e => e.P0005_GiaXuatCPC).HasMaxLength(1000);

                entity.Property(e => e.P0006_GiaXK).HasMaxLength(1000);

                entity.Property(e => e.P0007_GiaKenhSTMB).HasMaxLength(1000);

                entity.Property(e => e.P0008_GiaKenhSTMN).HasMaxLength(1000);

                entity.Property(e => e.P0009_GiaMegaEB).HasMaxLength(1000);

                entity.Property(e => e.P0010_GiaTMDT).HasMaxLength(1000);

                entity.Property(e => e.P0011_GiaBanLeTruCoChe).HasMaxLength(1000);

                entity.Property(e => e.P0012_GiaNoiBo).HasMaxLength(1000);

                entity.Property(e => e.P0013_GiaCBCNV).HasMaxLength(1000);

                entity.Property(e => e.P0014_GiaBNGiaLe).HasMaxLength(1000);

                entity.Property(e => e.P0015_GiaBNTruCoChe).HasMaxLength(1000);

                entity.Property(e => e.P0016_GiaTheoDonHang).HasMaxLength(1000);

                entity.Property(e => e.P0017_GiaCoSoGLP).HasMaxLength(1000);

                entity.Property(e => e.P0018_GiaLeNiemYet).HasMaxLength(1000);

                entity.Property(e => e.U_IGroupName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_ActualReportDAO>(entity =>
            {
                entity.ToTable("Raw_ActualReport", "PKH");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_Nhom).HasMaxLength(4000);

                entity.Property(e => e.Ma_Vung).HasMaxLength(4000);

                entity.Property(e => e.Ngay_LapPHD).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.SLuong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.STien).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.So_HDon).HasMaxLength(4000);

                entity.Property(e => e.Ten_DKKD).HasMaxLength(4000);

                entity.Property(e => e.Tinh_QuocGia).HasMaxLength(4000);

                entity.Property(e => e.Trang_Thai).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_ActualReportCloneDAO>(entity =>
            {
                entity.ToTable("Raw_ActualReportClone", "PKH");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_Nhom).HasMaxLength(4000);

                entity.Property(e => e.Ma_Tinh).HasMaxLength(4000);

                entity.Property(e => e.Ma_Vung).HasMaxLength(4000);

                entity.Property(e => e.Ngay_LapPHD).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.SLuong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.STien).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.So_HDon).HasMaxLength(4000);

                entity.Property(e => e.Ten_DKKD).HasMaxLength(4000);

                entity.Property(e => e.Tinh_QuocGia).HasMaxLength(4000);

                entity.Property(e => e.Trang_Thai).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_ActualReport_T4DAO>(entity =>
            {
                entity.ToTable("Raw_ActualReport_T4", "PKH");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_Nhom).HasMaxLength(4000);

                entity.Property(e => e.Ma_Vung).HasMaxLength(4000);

                entity.Property(e => e.Ngay_LapPHD).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.SLuong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.STien).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.So_HDon).HasMaxLength(4000);

                entity.Property(e => e.Ten_DKKD).HasMaxLength(4000);

                entity.Property(e => e.Tinh_QuocGia).HasMaxLength(4000);

                entity.Property(e => e.Trang_Thai).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_B003DAO>(entity =>
            {
                entity.ToTable("Raw_B003", "SAP");

                entity.Property(e => e.BP).HasMaxLength(50);

                entity.Property(e => e.BPLName).HasMaxLength(100);

                entity.Property(e => e.Conton).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.DocEntry).HasMaxLength(100);

                entity.Property(e => e.DonGiaHoaDon).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.Donvitinh).HasMaxLength(100);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Kho)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KhoaHD).HasMaxLength(500);

                entity.Property(e => e.LineNum).HasMaxLength(100);

                entity.Property(e => e.Loai_NX).HasMaxLength(50);

                entity.Property(e => e.Luongxuat).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.Ma_KH).HasMaxLength(100);

                entity.Property(e => e.NgayHoaDon).HasColumnType("datetime");

                entity.Property(e => e.PhongBH).HasMaxLength(100);

                entity.Property(e => e.Seri).HasMaxLength(100);

                entity.Property(e => e.SoHD).HasMaxLength(100);

                entity.Property(e => e.Soluong_gui).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.TenKH).HasMaxLength(500);

                entity.Property(e => e.TenKHLe).HasMaxLength(500);

                entity.Property(e => e.Ten_HH).HasMaxLength(500);

                entity.Property(e => e.ThanhTien).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.Thuesuat).HasColumnType("decimal(22, 6)");

                entity.Property(e => e.Thukho).HasMaxLength(500);

                entity.Property(e => e.U_Code).HasMaxLength(100);

                entity.Property(e => e.U_Description_vn).HasMaxLength(500);

                entity.Property(e => e.U_KM).HasMaxLength(100);

                entity.Property(e => e.XN).HasMaxLength(10);
            });

            modelBuilder.Entity<Raw_B1_1_IncurReport_RepDAO>(entity =>
            {
                entity.ToTable("Raw_B1_1_IncurReport_Rep", "SAP");

                entity.Property(e => e.Co_so).HasMaxLength(4000);

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.Kenh).HasMaxLength(4000);

                entity.Property(e => e.Khoa_HD).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ngay_ghiso).HasColumnType("datetime");

                entity.Property(e => e.Ngay_lapHD).HasColumnType("datetime");

                entity.Property(e => e.Nguoi_mua).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.Seri).HasMaxLength(4000);

                entity.Property(e => e.So_HD).HasMaxLength(4000);

                entity.Property(e => e.Ten_HH).HasMaxLength(4000);

                entity.Property(e => e.Tinh_thanh).HasMaxLength(4000);

                entity.Property(e => e.Trang_thai).HasMaxLength(4000);

                entity.Property(e => e.Vung).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_B1_1_IncurReport_Rep_TestDAO>(entity =>
            {
                entity.ToTable("Raw_B1_1_IncurReport_Rep_Test", "SAP");

                entity.Property(e => e.Co_so).HasMaxLength(4000);

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.Kenh).HasMaxLength(4000);

                entity.Property(e => e.Khoa_HD).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ngay_ghiso).HasColumnType("datetime");

                entity.Property(e => e.Ngay_lapHD).HasColumnType("datetime");

                entity.Property(e => e.Nguoi_mua).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.Seri).HasMaxLength(4000);

                entity.Property(e => e.So_HD).HasMaxLength(4000);

                entity.Property(e => e.Ten_HH).HasMaxLength(4000);

                entity.Property(e => e.Tinh_thanh).HasMaxLength(4000);

                entity.Property(e => e.Trang_thai).HasMaxLength(4000);

                entity.Property(e => e.Vung).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_B1_5_ActualExportReport_RepDAO>(entity =>
            {
                entity.ToTable("Raw_B1_5_ActualExportReport_Rep", "SAP");

                entity.Property(e => e.Donvitinh).HasMaxLength(4000);

                entity.Property(e => e.Huy).HasMaxLength(4000);

                entity.Property(e => e.Khach_hang).HasMaxLength(4000);

                entity.Property(e => e.KhoaHD).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.Ma_HH).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ngay_xuat).HasColumnType("datetime");

                entity.Property(e => e.Seri).HasMaxLength(4000);

                entity.Property(e => e.SoHD).HasMaxLength(4000);

                entity.Property(e => e.Ten_HH).HasMaxLength(4000);

                entity.Property(e => e.XN).HasMaxLength(4000);

                entity.Property(e => e.coso).HasMaxLength(4000);

                entity.Property(e => e.thoidiem).HasColumnType("datetime");
            });

            modelBuilder.Entity<Raw_B1_5_ActualExportReport_Rep_TestDAO>(entity =>
            {
                entity.ToTable("Raw_B1_5_ActualExportReport_Rep_Test", "SAP");

                entity.Property(e => e.Donvitinh).HasMaxLength(4000);

                entity.Property(e => e.Huy).HasMaxLength(4000);

                entity.Property(e => e.Khach_hang).HasMaxLength(4000);

                entity.Property(e => e.KhoaHD).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.Ma_HH).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ngay_xuat).HasColumnType("datetime");

                entity.Property(e => e.Seri).HasMaxLength(4000);

                entity.Property(e => e.SoHD).HasMaxLength(4000);

                entity.Property(e => e.Ten_HH).HasMaxLength(4000);

                entity.Property(e => e.XN).HasMaxLength(4000);

                entity.Property(e => e.coso).HasMaxLength(4000);

                entity.Property(e => e.thoidiem).HasColumnType("datetime");
            });

            modelBuilder.Entity<Raw_C4LED_Revenue_MonthDAO>(entity =>
            {
                entity.ToTable("Raw_C4LED_Revenue_Month", "C4LED");

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Donvi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Linhvuc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Mang)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_C4LED_Revenue_WeekDAO>(entity =>
            {
                entity.ToTable("Raw_C4LED_Revenue_Week", "C4LED");

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Donvi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Linhvuc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Mang)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_C4LED_SalePlan_MonthDAO>(entity =>
            {
                entity.ToTable("Raw_C4LED_SalePlan_Month", "C4LED");

                entity.Property(e => e.Donvi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.KHThang1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Linhvuc)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Mang)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_C4LED_SalePlan_QuarterDAO>(entity =>
            {
                entity.ToTable("Raw_C4LED_SalePlan_Quarter", "C4LED");

                entity.Property(e => e.Donvi).HasMaxLength(500);

                entity.Property(e => e.KHQuy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Mang)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Trungtam).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_C4LED_SalePlan_YearDAO>(entity =>
            {
                entity.ToTable("Raw_C4LED_SalePlan_Year", "C4LED");

                entity.Property(e => e.Donvi)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.KHNam).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Mang).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_Customer_RepDAO>(entity =>
            {
                entity.ToTable("Raw_Customer_Rep", "SAP");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);

                entity.Property(e => e.CountyCode).HasMaxLength(4000);

                entity.Property(e => e.CountyName).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);

                entity.Property(e => e.SaleBranch).HasMaxLength(4000);

                entity.Property(e => e.SaleChannel).HasMaxLength(4000);

                entity.Property(e => e.SaleRoom).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Customer_TempDAO>(entity =>
            {
                entity.ToTable("Raw_Customer_Temp", "NCTT");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);

                entity.Property(e => e.CountyCode).HasMaxLength(4000);

                entity.Property(e => e.CountyName).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);

                entity.Property(e => e.SaleBranch).HasMaxLength(4000);

                entity.Property(e => e.SaleChannel).HasMaxLength(4000);

                entity.Property(e => e.SaleRoom).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_EmployeeDAO>(entity =>
            {
                entity.ToTable("Raw_Employee", "PXK");

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.TenNV).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_IncurReportDAO>(entity =>
            {
                entity.ToTable("Raw_IncurReport", "PKH");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_Nhom).HasMaxLength(4000);

                entity.Property(e => e.Ma_Vung).HasMaxLength(4000);

                entity.Property(e => e.Ngay_LapPHD).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.SLuong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.STien).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.So_HDon).HasMaxLength(4000);

                entity.Property(e => e.Ten_DKKD).HasMaxLength(4000);

                entity.Property(e => e.Tinh_QuocGia).HasMaxLength(4000);

                entity.Property(e => e.Trang_Thai).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_IncurReport_T4DAO>(entity =>
            {
                entity.ToTable("Raw_IncurReport_T4", "PKH");

                entity.Property(e => e.DonGia).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.Loai_NX).HasMaxLength(4000);

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.Ma_KH).HasMaxLength(4000);

                entity.Property(e => e.Ma_Nhom).HasMaxLength(4000);

                entity.Property(e => e.Ma_Vung).HasMaxLength(4000);

                entity.Property(e => e.Ngay_LapPHD).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);

                entity.Property(e => e.Phong).HasMaxLength(4000);

                entity.Property(e => e.SLuong).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.STien).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.So_HDon).HasMaxLength(4000);

                entity.Property(e => e.Ten_DKKD).HasMaxLength(4000);

                entity.Property(e => e.Tinh_QuocGia).HasMaxLength(4000);

                entity.Property(e => e.Trang_Thai).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Item_RepDAO>(entity =>
            {
                entity.ToTable("Raw_Item_Rep", "SAP");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Item_TempDAO>(entity =>
            {
                entity.ToTable("Raw_Item_Temp", "NCTT");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_KPI_ProductProductGroupOrgPeriodDAO>(entity =>
            {
                entity.ToTable("Raw_KPI_ProductProductGroupOrgPeriod", "KPI");

                entity.Property(e => e.ChonDanhSachSP).HasMaxLength(4000);

                entity.Property(e => e.Ky)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MaDonVi)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.MaNhom)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TenNhom)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Raw_KeyCustomerDAO>(entity =>
            {
                entity.ToTable("Raw_KeyCustomer", "NCTT");

                entity.Property(e => e.CustomerCode).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.DMS_StoreName).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_Location_RepDAO>(entity =>
            {
                entity.ToTable("Raw_Location_Rep", "SAP");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.U_Kho).HasMaxLength(50);

                entity.Property(e => e.U_Location).HasMaxLength(100);
            });

            modelBuilder.Entity<Raw_MainBusinessDAO>(entity =>
            {
                entity.ToTable("Raw_MainBusiness", "PKH");

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Thoidiem).HasColumnType("date");

                entity.Property(e => e.Trucot).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_MinimumInventoryDAO>(entity =>
            {
                entity.ToTable("Raw_MinimumInventory", "PKH");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.KH2021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.MaKho).HasMaxLength(4000);

                entity.Property(e => e.Q012021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q022021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q032021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q042021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T012021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T022021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T032021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T042021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T052021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T062021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T072021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T082021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T092021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T102021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T112021).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.T122021).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Raw_ProductGroupDAO>(entity =>
            {
                entity.ToTable("Raw_ProductGroup", "PKH");

                entity.Property(e => e.GTGT_EndDate).HasColumnType("datetime");

                entity.Property(e => e.GTGT_StartDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(4000);

                entity.Property(e => e.M_EndDate).HasColumnType("datetime");

                entity.Property(e => e.M_StartDate).HasColumnType("datetime");

                entity.Property(e => e.NCTT).HasMaxLength(4000);

                entity.Property(e => e.NhomC1).HasMaxLength(4000);

                entity.Property(e => e.NhomC2).HasMaxLength(4000);

                entity.Property(e => e.NhomC3).HasMaxLength(4000);

                entity.Property(e => e.NhomChinh_KH).HasMaxLength(4000);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(4000);

                entity.Property(e => e.Nhom_SMRTDONLEHT).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Product_GroupingDAO>(entity =>
            {
                entity.ToTable("Raw_Product_Grouping", "KPI");

                entity.Property(e => e.DON_VI)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.KY)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.MA_NHOMSP)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.MA_SP)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_SP)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_Product_ProductGroupDAO>(entity =>
            {
                entity.ToTable("Raw_Product_ProductGroup", "RD");

                entity.Property(e => e.ChatLuong).HasMaxLength(1000);

                entity.Property(e => e.CongSuat).HasMaxLength(1000);

                entity.Property(e => e.MaSP).HasMaxLength(1000);

                entity.Property(e => e.NhietDoMau).HasMaxLength(1000);

                entity.Property(e => e.SPC1).HasMaxLength(1000);

                entity.Property(e => e.SPC2).HasMaxLength(1000);

                entity.Property(e => e.TenSP).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_Product_SalePlanDAO>(entity =>
            {
                entity.ToTable("Raw_Product_SalePlan", "PKH");

                entity.Property(e => e.ERPGroup).HasMaxLength(4000);

                entity.Property(e => e.M01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M05Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M06Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M07Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M08Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M09Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M10Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M11Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M12Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.ProductCode).HasMaxLength(4000);

                entity.Property(e => e.ProductName).HasMaxLength(4000);

                entity.Property(e => e.ProductType).HasMaxLength(4000);

                entity.Property(e => e.Q01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SPC1Group).HasMaxLength(4000);

                entity.Property(e => e.SPC2Group).HasMaxLength(4000);

                entity.Property(e => e.SPC3Group).HasMaxLength(4000);

                entity.Property(e => e.YearPlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Raw_RD_EmployeeDAO>(entity =>
            {
                entity.ToTable("Raw_RD_Employee", "RD");

                entity.Property(e => e.MaNV).HasMaxLength(1000);

                entity.Property(e => e.TenNV).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SaleBranchDMSMappingDAO>(entity =>
            {
                entity.ToTable("Raw_SaleBranchDMSMapping", "DMS");

                entity.Property(e => e.DMS_Name).HasMaxLength(500);

                entity.Property(e => e.SaleBranchName).HasMaxLength(500);

                entity.Property(e => e.SaleRoomName).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_SaleEmployee_CustomerDAO>(entity =>
            {
                entity.ToTable("Raw_SaleEmployee_Customer", "RD");

                entity.Property(e => e.MaKH).HasMaxLength(1000);

                entity.Property(e => e.MaNV).HasMaxLength(1000);

                entity.Property(e => e.TenKH).HasMaxLength(1000);

                entity.Property(e => e.TenNV).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SaleIn_PlanDAO>(entity =>
            {
                entity.ToTable("Raw_SaleIn_Plan", "KPI");

                entity.Property(e => e.KH_Nam).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan13).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan14).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan15).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan16).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan17).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan18).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan19).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan20).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan21).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan22).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan23).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan24).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan25).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan26).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan27).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan28).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan29).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan30).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan31).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan32).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan33).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan34).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan35).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan36).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan37).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan38).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan39).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan40).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan41).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan42).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan43).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan44).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan45).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan46).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan47).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan48).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan49).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan50).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan51).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan52).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan53).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.MA_DV)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NHOM_CTieu)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_CTieu)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_DV)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SaleIn_Plan_Ver2DAO>(entity =>
            {
                entity.ToTable("Raw_SaleIn_Plan_Ver2", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KH_Quy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang01).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang02).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang03).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang04).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang05).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang06).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang07).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang08).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang09).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan01).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan02).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan03).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan04).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan05).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan06).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan07).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan08).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan09).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan13).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan14).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan15).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan16).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan17).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan18).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan19).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan20).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan21).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan22).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan23).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan24).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan25).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan26).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan27).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan28).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan29).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan30).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan31).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan32).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan33).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan34).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan35).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan36).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan37).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan38).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan39).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan40).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan41).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan42).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan43).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan44).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan45).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan46).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan47).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan48).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan49).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan50).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan51).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan52).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan53).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Raw_SaleOut_PlanDAO>(entity =>
            {
                entity.ToTable("Raw_SaleOut_Plan", "KPI");

                entity.Property(e => e.KH_Nam).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan13).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan14).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan15).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan16).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan17).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan18).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan19).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan20).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan21).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan22).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan23).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan24).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan25).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan26).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan27).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan28).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan29).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan30).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan31).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan32).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan33).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan34).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan35).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan36).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan37).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan38).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan39).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan40).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan41).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan42).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan43).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan44).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan45).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan46).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan47).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan48).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan49).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan50).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan51).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan52).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan53).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.MA_DV)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.NHOM_CTieu)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_CTieu)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_DV)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SaleOut_Plan_Ver2DAO>(entity =>
            {
                entity.ToTable("Raw_SaleOut_Plan_Ver2", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.KH_Quy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Quy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang01).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang02).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang03).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang04).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang05).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang06).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang07).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang08).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang09).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Thang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan01).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan02).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan03).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan04).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan05).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan06).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan07).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan08).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan09).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan13).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan14).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan15).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan16).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan17).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan18).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan19).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan20).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan21).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan22).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan23).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan24).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan25).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan26).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan27).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan28).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan29).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan30).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan31).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan32).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan33).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan34).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan35).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan36).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan37).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan38).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan39).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan40).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan41).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan42).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan43).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan44).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan45).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan46).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan47).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan48).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan49).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan50).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan51).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan52).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KH_Tuan53).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Raw_SalePlan_RevenueDAO>(entity =>
            {
                entity.ToTable("Raw_SalePlan_Revenue", "PXK");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);

                entity.Property(e => e.Customer).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.EmployeeCode).HasMaxLength(4000);

                entity.Property(e => e.EmployeeName).HasMaxLength(4000);

                entity.Property(e => e.M01Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M02Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M03Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M04Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M05Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M06Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M07Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M08Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M09Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M10Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M11Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.M12Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Q01Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Q02Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Q03Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Q04Plan).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.YearPlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Raw_SaleUnit_SalePlan_QuantityDAO>(entity =>
            {
                entity.ToTable("Raw_SaleUnit_SalePlan_Quantity", "PKH");

                entity.Property(e => e.Company).HasMaxLength(4000);

                entity.Property(e => e.Customer).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.M01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M05Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M06Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M07Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M08Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M09Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M10Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M11Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M12Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleBranch).HasMaxLength(4000);

                entity.Property(e => e.SaleChannel).HasMaxLength(4000);

                entity.Property(e => e.SaleMainBusiness).HasMaxLength(4000);

                entity.Property(e => e.SaleProvince).HasMaxLength(4000);

                entity.Property(e => e.SaleRoom).HasMaxLength(4000);

                entity.Property(e => e.YearPlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Raw_SaleUnit_SalePlan_RevenueDAO>(entity =>
            {
                entity.ToTable("Raw_SaleUnit_SalePlan_Revenue", "PKH");

                entity.Property(e => e.Company).HasMaxLength(4000);

                entity.Property(e => e.Customer).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.M01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M05Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M06Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M07Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M08Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M09Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M10Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M11Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.M12Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q01Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q02Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q03Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Q04Plan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleBranch).HasMaxLength(4000);

                entity.Property(e => e.SaleChannel).HasMaxLength(4000);

                entity.Property(e => e.SaleMainBusiness).HasMaxLength(4000);

                entity.Property(e => e.SaleProvince).HasMaxLength(4000);

                entity.Property(e => e.SaleRoom).HasMaxLength(4000);

                entity.Property(e => e.YearPlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Raw_SpecializedChannelDAO>(entity =>
            {
                entity.ToTable("Raw_SpecializedChannel", "RD");

                entity.Property(e => e.SPC1).HasMaxLength(1000);

                entity.Property(e => e.TenKenh).HasMaxLength(1000);

                entity.Property(e => e.TenMien).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SpecializedChannel_SalePlan_RevenueDAO>(entity =>
            {
                entity.ToTable("Raw_SpecializedChannel_SalePlan_Revenue", "RD");

                entity.Property(e => e.KHNam).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHQuy4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang1).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang10).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang11).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang12).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang2).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang3).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang4).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang5).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang6).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang7).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang8).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.KHThang9).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.MaKH).HasMaxLength(1000);

                entity.Property(e => e.TenKH).HasMaxLength(1000);

                entity.Property(e => e.TenKenh).HasMaxLength(1000);

                entity.Property(e => e.TenMien).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_TeamSale_CustomerDAO>(entity =>
            {
                entity.ToTable("Raw_TeamSale_Customer", "KPI");

                entity.Property(e => e.MA_KH)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_DOI)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_KH)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_TeamSale_EmployeeDAO>(entity =>
            {
                entity.ToTable("Raw_TeamSale_Employee", "KPI");

                entity.Property(e => e.END_DATE).HasColumnType("datetime");

                entity.Property(e => e.MA_NV)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.START_DATE).HasColumnType("datetime");

                entity.Property(e => e.TEN_DOI)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TEN_NV)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_WarehouseDAO>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK_Raw_Inventory");

                entity.ToTable("Raw_Warehouse", "PKH");

                entity.Property(e => e.TEN_KHO_C1).HasMaxLength(4000);

                entity.Property(e => e.TEN_KHO_C2).HasMaxLength(4000);
            });

            modelBuilder.Entity<RoleDAO>(entity =>
            {
                entity.ToTable("Role", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Status");
            });

            modelBuilder.Entity<SchemaDAO>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<ServerDAO>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<SetDAO>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Score })
                    .HasName("IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<StateDAO>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<StatusDAO>(entity =>
            {
                entity.ToTable("Status", "ENUM");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TMDT_Dim_CityDAO>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("TMDT_Dim_City", "TMDT");

                entity.Property(e => e.CityName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_CustomerDAO>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("TMDT_Dim_Customer", "TMDT");

                entity.Property(e => e.CustomerAddress).HasMaxLength(4000);

                entity.Property(e => e.CustomerCity).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);

                entity.Property(e => e.CustomerPhoneNumber).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_OrderSourceDAO>(entity =>
            {
                entity.HasKey(e => e.OrderSourceId);

                entity.ToTable("TMDT_Dim_OrderSource", "TMDT");

                entity.Property(e => e.OrderSourceName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_OrderStatusDAO>(entity =>
            {
                entity.HasKey(e => e.OrderStatusId);

                entity.ToTable("TMDT_Dim_OrderStatus", "TMDT");

                entity.Property(e => e.OrderStatusName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_ProcessingDepartmentDAO>(entity =>
            {
                entity.HasKey(e => e.ProcessingDepartmentId);

                entity.ToTable("TMDT_Dim_ProcessingDepartment", "TMDT");

                entity.Property(e => e.ProcessingDepartmentName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Fact_OrderDAO>(entity =>
            {
                entity.ToTable("TMDT_Fact_Order", "TMDT");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OrderCode).HasMaxLength(100);

                entity.Property(e => e.OrderValue).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<TMDT_Raw_OrderDAO>(entity =>
            {
                entity.ToTable("TMDT_Raw_Order", "TMDT");

                entity.Property(e => e.DCHI).HasMaxLength(4000);

                entity.Property(e => e.DGIA).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.DTHOAI).HasMaxLength(4000);

                entity.Property(e => e.DVI_XLY).HasMaxLength(4000);

                entity.Property(e => e.MA_DHANG).HasMaxLength(4000);

                entity.Property(e => e.MA_KHANG).HasMaxLength(4000);

                entity.Property(e => e.MA_PHIENBAN).HasMaxLength(4000);

                entity.Property(e => e.MA_SAP).HasMaxLength(4000);

                entity.Property(e => e.NGAY_TAO).HasColumnType("datetime");

                entity.Property(e => e.NGUON_BHANG).HasMaxLength(4000);

                entity.Property(e => e.Ngay_RAW).HasMaxLength(4000);

                entity.Property(e => e.SOLUONG).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.TEN_KHANG).HasMaxLength(4000);

                entity.Property(e => e.TEN_SP).HasMaxLength(4000);

                entity.Property(e => e.TINH_THANHPHO).HasMaxLength(4000);

                entity.Property(e => e.TONG_TIEN).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.TRANG_THAI).HasMaxLength(4000);
            });

            modelBuilder.Entity<test_pathDAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevelId);

                entity.ToTable("test_path", "dbo");

                entity.Property(e => e.ItemGroupLevelId).ValueGeneratedNever();

                entity.Property(e => e.ItemGroupLevelName).HasMaxLength(4000);

                entity.Property(e => e.Level1Name).HasMaxLength(4000);

                entity.Property(e => e.Level2Name).HasMaxLength(4000);

                entity.Property(e => e.ParentId)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Path).HasMaxLength(4000);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
