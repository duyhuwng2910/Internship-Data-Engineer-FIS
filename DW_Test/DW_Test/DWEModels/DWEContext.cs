using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DW_Test.DWEModels
{
    public partial class DWEContext : DbContext
    {
        public DWEContext()
        {
        }

        public DWEContext(DbContextOptions<DWEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<ActionPageMapping> ActionPageMapping { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<AppUserRoleMapping> AppUserRoleMapping { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<Dim_AppUser> Dim_AppUser { get; set; }
        public virtual DbSet<Dim_AppUserStoreMapping> Dim_AppUserStoreMapping { get; set; }
        public virtual DbSet<Dim_Brand> Dim_Brand { get; set; }
        public virtual DbSet<Dim_BrandInStoreProductGroupingMapping> Dim_BrandInStoreProductGroupingMapping { get; set; }
        public virtual DbSet<Dim_Country> Dim_Country { get; set; }
        public virtual DbSet<Dim_County> Dim_County { get; set; }
        public virtual DbSet<Dim_Customer> Dim_Customer { get; set; }
        public virtual DbSet<Dim_CustomerC2> Dim_CustomerC2 { get; set; }
        public virtual DbSet<Dim_Date> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMapping> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_Date_Filter> Dim_Date_Filter { get; set; }
        public virtual DbSet<Dim_District> Dim_District { get; set; }
        public virtual DbSet<Dim_Employee> Dim_Employee { get; set; }
        public virtual DbSet<Dim_Item> Dim_Item { get; set; }
        public virtual DbSet<Dim_ItemDMS> Dim_ItemDMS { get; set; }
        public virtual DbSet<Dim_ItemGroup> Dim_ItemGroup { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel> Dim_ItemGroupLevel { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel1> Dim_ItemGroupLevel1 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel2> Dim_ItemGroupLevel2 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel3> Dim_ItemGroupLevel3 { get; set; }
        public virtual DbSet<Dim_ItemLedSmartGroup> Dim_ItemLedSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemMainGroup> Dim_ItemMainGroup { get; set; }
        public virtual DbSet<Dim_ItemMapping> Dim_ItemMapping { get; set; }
        public virtual DbSet<Dim_ItemNCTT> Dim_ItemNCTT { get; set; }
        public virtual DbSet<Dim_ItemNewItemGroup> Dim_ItemNewItemGroup { get; set; }
        public virtual DbSet<Dim_ItemSingleSmartGroup> Dim_ItemSingleSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemType> Dim_ItemType { get; set; }
        public virtual DbSet<Dim_ItemVATGroup> Dim_ItemVATGroup { get; set; }
        public virtual DbSet<Dim_KPIType> Dim_KPIType { get; set; }
        public virtual DbSet<Dim_KPI_Measure> Dim_KPI_Measure { get; set; }
        public virtual DbSet<Dim_KPI_ProductGrouping> Dim_KPI_ProductGrouping { get; set; }
        public virtual DbSet<Dim_KPI_ProductGrouping_Mapping> Dim_KPI_ProductGrouping_Mapping { get; set; }
        public virtual DbSet<Dim_Location> Dim_Location { get; set; }
        public virtual DbSet<Dim_MainBusiness> Dim_MainBusiness { get; set; }
        public virtual DbSet<Dim_Month> Dim_Month { get; set; }
        public virtual DbSet<Dim_OrganizationUnit> Dim_OrganizationUnit { get; set; }
        public virtual DbSet<Dim_OrganizationUnitMapping> Dim_OrganizationUnitMapping { get; set; }
        public virtual DbSet<Dim_Period> Dim_Period { get; set; }
        public virtual DbSet<Dim_Product> Dim_Product { get; set; }
        public virtual DbSet<Dim_Province> Dim_Province { get; set; }
        public virtual DbSet<Dim_Quarter> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_SaleBranch> Dim_SaleBranch { get; set; }
        public virtual DbSet<Dim_SaleChannel> Dim_SaleChannel { get; set; }
        public virtual DbSet<Dim_SaleEmployee> Dim_SaleEmployee { get; set; }
        public virtual DbSet<Dim_SaleEntity> Dim_SaleEntity { get; set; }
        public virtual DbSet<Dim_SaleLevel> Dim_SaleLevel { get; set; }
        public virtual DbSet<Dim_SaleRoom> Dim_SaleRoom { get; set; }
        public virtual DbSet<Dim_SaleUnitMapping> Dim_SaleUnitMapping { get; set; }
        public virtual DbSet<Dim_Store> Dim_Store { get; set; }
        public virtual DbSet<Dim_StoreGrouping> Dim_StoreGrouping { get; set; }
        public virtual DbSet<Dim_StoreMapping> Dim_StoreMapping { get; set; }
        public virtual DbSet<Dim_StoreType> Dim_StoreType { get; set; }
        public virtual DbSet<Dim_Targets_SaleIn> Dim_Targets_SaleIn { get; set; }
        public virtual DbSet<Dim_Targets_SaleOut> Dim_Targets_SaleOut { get; set; }
        public virtual DbSet<Dim_TeamSale_Customer> Dim_TeamSale_Customer { get; set; }
        public virtual DbSet<Dim_Warehouse> Dim_Warehouse { get; set; }
        public virtual DbSet<Dim_Week> Dim_Week { get; set; }
        public virtual DbSet<Dim_Year> Dim_Year { get; set; }
        public virtual DbSet<Fact_Actual_Revenue> Fact_Actual_Revenue { get; set; }
        public virtual DbSet<Fact_BrandInStore> Fact_BrandInStore { get; set; }
        public virtual DbSet<Fact_Company_Month_Plan> Fact_Company_Month_Plan { get; set; }
        public virtual DbSet<Fact_Company_Quarter_Plan> Fact_Company_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Company_Year_Plan> Fact_Company_Year_Plan { get; set; }
        public virtual DbSet<Fact_Country_Month_Plan> Fact_Country_Month_Plan { get; set; }
        public virtual DbSet<Fact_Country_Quarter_Plan> Fact_Country_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Country_Year_Plan> Fact_Country_Year_Plan { get; set; }
        public virtual DbSet<Fact_County_Month_Plan> Fact_County_Month_Plan { get; set; }
        public virtual DbSet<Fact_County_Quarter_Plan> Fact_County_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_County_Year_Plan> Fact_County_Year_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Month_Plan> Fact_Customer_Month_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Quarter_Plan> Fact_Customer_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Year_Plan> Fact_Customer_Year_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Month_Plan> Fact_Employee_Month_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Quarter_Plan> Fact_Employee_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Employee_Year_Plan> Fact_Employee_Year_Plan { get; set; }
        public virtual DbSet<Fact_Incur_Revenue> Fact_Incur_Revenue { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrder> Fact_IndirectSalesOrder { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderStoreGroupingMapping> Fact_IndirectSalesOrderStoreGroupingMapping { get; set; }
        public virtual DbSet<Fact_IndirectSalesOrderTransaction> Fact_IndirectSalesOrderTransaction { get; set; }
        public virtual DbSet<Fact_Item_MinimumInventory> Fact_Item_MinimumInventory { get; set; }
        public virtual DbSet<Fact_Item_Month_Plan> Fact_Item_Month_Plan { get; set; }
        public virtual DbSet<Fact_Item_Quarter_Plan> Fact_Item_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Item_Whs_Inventory> Fact_Item_Whs_Inventory { get; set; }
        public virtual DbSet<Fact_Item_Year_Plan> Fact_Item_Year_Plan { get; set; }
        public virtual DbSet<Fact_KPI_IndirectSalesOrder> Fact_KPI_IndirectSalesOrder { get; set; }
        public virtual DbSet<Fact_KPI_ProductGroupingItem> Fact_KPI_ProductGroupingItem { get; set; }
        public virtual DbSet<Fact_KPI_StoreChecking> Fact_KPI_StoreChecking { get; set; }
        public virtual DbSet<Fact_KPI_StoreTypeHistory> Fact_KPI_StoreTypeHistory { get; set; }
        public virtual DbSet<Fact_MainBusiness_Month_Plan> Fact_MainBusiness_Month_Plan { get; set; }
        public virtual DbSet<Fact_MainBusiness_Quarter_Plan> Fact_MainBusiness_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_MainBusiness_Revenue> Fact_MainBusiness_Revenue { get; set; }
        public virtual DbSet<Fact_MainBusiness_Year_Plan> Fact_MainBusiness_Year_Plan { get; set; }
        public virtual DbSet<Fact_MinimumInventory_Month> Fact_MinimumInventory_Month { get; set; }
        public virtual DbSet<Fact_MinimumInventory_Quarter> Fact_MinimumInventory_Quarter { get; set; }
        public virtual DbSet<Fact_MinimumInventory_Year> Fact_MinimumInventory_Year { get; set; }
        public virtual DbSet<Fact_ProductGrouping> Fact_ProductGrouping { get; set; }
        public virtual DbSet<Fact_RevenueCustomerC2> Fact_RevenueCustomerC2 { get; set; }
        public virtual DbSet<Fact_SaleBranch_Month_Plan> Fact_SaleBranch_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Quarter_Plan> Fact_SaleBranch_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Year_Plan> Fact_SaleBranch_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Month_Plan> Fact_SaleChannel_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Quarter_Plan> Fact_SaleChannel_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Year_Plan> Fact_SaleChannel_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleInRevenue> Fact_SaleInRevenue { get; set; }
        public virtual DbSet<Fact_SaleIn_KpiCollectionResult> Fact_SaleIn_KpiCollectionResult { get; set; }
        public virtual DbSet<Fact_SaleOutRevenue> Fact_SaleOutRevenue { get; set; }
        public virtual DbSet<Fact_SaleOut_KpiCollectionResult> Fact_SaleOut_KpiCollectionResult { get; set; }
        public virtual DbSet<Fact_SaleRoom_Month_Plan> Fact_SaleRoom_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Quarter_Plan> Fact_SaleRoom_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Quarter_Plan> Fact_SaleRoom_TargetProduct_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Week_Plan> Fact_SaleRoom_TargetProduct_Week_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_TargetProduct_Year_Plan> Fact_SaleRoom_TargetProduct_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Year_Plan> Fact_SaleRoom_Year_Plan { get; set; }
        public virtual DbSet<Fact_StoreChecking> Fact_StoreChecking { get; set; }
        public virtual DbSet<Fact_TeamSale_Employee> Fact_TeamSale_Employee { get; set; }
        public virtual DbSet<Field> Field { get; set; }
        public virtual DbSet<FieldType> FieldType { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<ItemGroup> ItemGroup { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<KPIPlanSaleIn> KPIPlanSaleIn { get; set; }
        public virtual DbSet<KPIRevenueSaleIn> KPIRevenueSaleIn { get; set; }
        public virtual DbSet<KPI_Actual_Revenue> KPI_Actual_Revenue { get; set; }
        public virtual DbSet<KPI_CompleteThermosGroup_Revenue> KPI_CompleteThermosGroup_Revenue { get; set; }
        public virtual DbSet<KPI_Dim_SaleEmployeeMapping> KPI_Dim_SaleEmployeeMapping { get; set; }
        public virtual DbSet<KPI_Dim_SaleInKPI> KPI_Dim_SaleInKPI { get; set; }
        public virtual DbSet<KPI_Dim_SaleOutKPI> KPI_Dim_SaleOutKPI { get; set; }
        public virtual DbSet<KPI_Fact_Result_Planned_General> KPI_Fact_Result_Planned_General { get; set; }
        public virtual DbSet<KPI_Fact_Revenue> KPI_Fact_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Month_Revenue> KPI_Fact_SaleBranch_DensityProduct_Month_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue> KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Week_Revenue> KPI_Fact_SaleBranch_DensityProduct_Week_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleBranch_DensityProduct_Year_Revenue> KPI_Fact_SaleBranch_DensityProduct_Year_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1> KPI_Fact_SaleInRevenueC1 { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1NewProduct> KPI_Fact_SaleInRevenueC1NewProduct { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1NewProduct_Plan> KPI_Fact_SaleInRevenueC1NewProduct_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueC1_Plan> KPI_Fact_SaleInRevenueC1_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueReceipt> KPI_Fact_SaleInRevenueReceipt { get; set; }
        public virtual DbSet<KPI_Fact_SaleInRevenueReceipt_Plan> KPI_Fact_SaleInRevenueReceipt_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutImageCount> KPI_Fact_SaleOutImageCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutImageCount_Plan> KPI_Fact_SaleOutImageCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutNewStoreCount_Plan> KPI_Fact_SaleOutNewStoreCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutProblemCount_Plan> KPI_Fact_SaleOutProblemCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenue> KPI_Fact_SaleOutRevenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2SL_Plan> KPI_Fact_SaleOutRevenueC2SL_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2Sum_Plan> KPI_Fact_SaleOutRevenueC2Sum_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2TD_Plan> KPI_Fact_SaleOutRevenueC2TD_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutRevenueC2_Plan> KPI_Fact_SaleOutRevenueC2_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCheckingCount> KPI_Fact_SaleOutStoreCheckingCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCheckingCount_Plan> KPI_Fact_SaleOutStoreCheckingCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCount> KPI_Fact_SaleOutStoreCount { get; set; }
        public virtual DbSet<KPI_Fact_SaleOutStoreCount_Plan> KPI_Fact_SaleOutStoreCount_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Month_Plan> KPI_Fact_SaleOut_Month_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Quarter_Plan> KPI_Fact_SaleOut_Quarter_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleOut_Year_Plan> KPI_Fact_SaleOut_Year_Plan { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Month_Revenue> KPI_Fact_SaleRoom_DensityProduct_Month_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue> KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Week_Revenue> KPI_Fact_SaleRoom_DensityProduct_Week_Revenue { get; set; }
        public virtual DbSet<KPI_Fact_SaleRoom_DensityProduct_Year_Revenue> KPI_Fact_SaleRoom_DensityProduct_Year_Revenue { get; set; }
        public virtual DbSet<KPI_Incur_Revenue> KPI_Incur_Revenue { get; set; }
        public virtual DbSet<KPI_LEDGroup_Revenue> KPI_LEDGroup_Revenue { get; set; }
        public virtual DbSet<KPI_LED_GTGT_Revenue> KPI_LED_GTGT_Revenue { get; set; }
        public virtual DbSet<KPI_LED_NewItem_Revenue> KPI_LED_NewItem_Revenue { get; set; }
        public virtual DbSet<KPI_LED_SmartGroup_Revenue> KPI_LED_SmartGroup_Revenue { get; set; }
        public virtual DbSet<KPI_PremiumThermosGroup_Revenue> KPI_PremiumThermosGroup_Revenue { get; set; }
        public virtual DbSet<KPI_Raw_SaleEmployeeMapping> KPI_Raw_SaleEmployeeMapping { get; set; }
        public virtual DbSet<KPI_Raw_SaleInCountyMapping> KPI_Raw_SaleInCountyMapping { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueC1NewProduct_Plan> KPI_Raw_SaleInRevenueC1NewProduct_Plan { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueReceipt> KPI_Raw_SaleInRevenueReceipt { get; set; }
        public virtual DbSet<KPI_Raw_SaleInRevenueReceipt_Plan> KPI_Raw_SaleInRevenueReceipt_Plan { get; set; }
        public virtual DbSet<KPI_ThermosGroup_Revenue> KPI_ThermosGroup_Revenue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Log_Table> Log_Table { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<NCTT_Dim_ItemCharacteristic> NCTT_Dim_ItemCharacteristic { get; set; }
        public virtual DbSet<NCTT_Dim_ItemClass> NCTT_Dim_ItemClass { get; set; }
        public virtual DbSet<NCTT_Dim_ItemGroup> NCTT_Dim_ItemGroup { get; set; }
        public virtual DbSet<NCTT_Dim_ItemLine> NCTT_Dim_ItemLine { get; set; }
        public virtual DbSet<NCTT_Dim_ItemMapping> NCTT_Dim_ItemMapping { get; set; }
        public virtual DbSet<NCTT_Dim_ItemPropertyDetail> NCTT_Dim_ItemPropertyDetail { get; set; }
        public virtual DbSet<NCTT_Dim_ItemPropertyGroup> NCTT_Dim_ItemPropertyGroup { get; set; }
        public virtual DbSet<NCTT_Dim_ItemType> NCTT_Dim_ItemType { get; set; }
        public virtual DbSet<NCTT_Fact_CountyScope> NCTT_Fact_CountyScope { get; set; }
        public virtual DbSet<NCTT_Fact_KPI_SaleOut_Plan> NCTT_Fact_KPI_SaleOut_Plan { get; set; }
        public virtual DbSet<NCTT_Fact_KPI_SaleOut_Revenue> NCTT_Fact_KPI_SaleOut_Revenue { get; set; }
        public virtual DbSet<NCTT_Fact_Revenue> NCTT_Fact_Revenue { get; set; }
        public virtual DbSet<NCTT_Raw_CountyScope> NCTT_Raw_CountyScope { get; set; }
        public virtual DbSet<NCTT_Raw_NewItem> NCTT_Raw_NewItem { get; set; }
        public virtual DbSet<NCTT_Raw_PBH1_PBH2> NCTT_Raw_PBH1_PBH2 { get; set; }
        public virtual DbSet<NCTT_Raw_ProductGroup> NCTT_Raw_ProductGroup { get; set; }
        public virtual DbSet<NCTT_Raw_ProductGroup_Temp> NCTT_Raw_ProductGroup_Temp { get; set; }
        public virtual DbSet<Page> Page { get; set; }
        public virtual DbSet<Permission> Permission { get; set; }
        public virtual DbSet<PermissionActionMapping> PermissionActionMapping { get; set; }
        public virtual DbSet<PermissionContent> PermissionContent { get; set; }
        public virtual DbSet<PermissionOperator> PermissionOperator { get; set; }
        public virtual DbSet<Raw_A009> Raw_A009 { get; set; }
        public virtual DbSet<Raw_A012> Raw_A012 { get; set; }
        public virtual DbSet<Raw_ActualReport> Raw_ActualReport { get; set; }
        public virtual DbSet<Raw_ActualReportClone> Raw_ActualReportClone { get; set; }
        public virtual DbSet<Raw_ActualReport_T4> Raw_ActualReport_T4 { get; set; }
        public virtual DbSet<Raw_B003> Raw_B003 { get; set; }
        public virtual DbSet<Raw_B1_1_IncurReport_Rep> Raw_B1_1_IncurReport_Rep { get; set; }
        public virtual DbSet<Raw_B1_1_IncurReport_Rep_Test> Raw_B1_1_IncurReport_Rep_Test { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_Rep> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_Rep_Test> Raw_B1_5_ActualExportReport_Rep_Test { get; set; }
        public virtual DbSet<Raw_Customer_Rep> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Customer_Temp> Raw_Customer_Temp { get; set; }
        public virtual DbSet<Raw_Employee> Raw_Employee { get; set; }
        public virtual DbSet<Raw_IncurReport> Raw_IncurReport { get; set; }
        public virtual DbSet<Raw_IncurReport_T4> Raw_IncurReport_T4 { get; set; }
        public virtual DbSet<Raw_Item_Rep> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Item_Temp> Raw_Item_Temp { get; set; }
        public virtual DbSet<Raw_KeyCustomer> Raw_KeyCustomer { get; set; }
        public virtual DbSet<Raw_Location_Rep> Raw_Location_Rep { get; set; }
        public virtual DbSet<Raw_MainBusiness> Raw_MainBusiness { get; set; }
        public virtual DbSet<Raw_MinimumInventory> Raw_MinimumInventory { get; set; }
        public virtual DbSet<Raw_ProductGroup> Raw_ProductGroup { get; set; }
        public virtual DbSet<Raw_Product_Grouping> Raw_Product_Grouping { get; set; }
        public virtual DbSet<Raw_Product_SalePlan> Raw_Product_SalePlan { get; set; }
        public virtual DbSet<Raw_SaleBranchDMSMapping> Raw_SaleBranchDMSMapping { get; set; }
        public virtual DbSet<Raw_SaleIn_Plan> Raw_SaleIn_Plan { get; set; }
        public virtual DbSet<Raw_SaleIn_Plan_Ver2> Raw_SaleIn_Plan_Ver2 { get; set; }
        public virtual DbSet<Raw_SaleOut_Plan> Raw_SaleOut_Plan { get; set; }
        public virtual DbSet<Raw_SaleOut_Plan_Ver2> Raw_SaleOut_Plan_Ver2 { get; set; }
        public virtual DbSet<Raw_SalePlan_Revenue> Raw_SalePlan_Revenue { get; set; }
        public virtual DbSet<Raw_SaleUnit_SalePlan_Quantity> Raw_SaleUnit_SalePlan_Quantity { get; set; }
        public virtual DbSet<Raw_SaleUnit_SalePlan_Revenue> Raw_SaleUnit_SalePlan_Revenue { get; set; }
        public virtual DbSet<Raw_TeamSale_Customer> Raw_TeamSale_Customer { get; set; }
        public virtual DbSet<Raw_TeamSale_Employee> Raw_TeamSale_Employee { get; set; }
        public virtual DbSet<Raw_Warehouse> Raw_Warehouse { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TMDT_Dim_City> TMDT_Dim_City { get; set; }
        public virtual DbSet<TMDT_Dim_Customer> TMDT_Dim_Customer { get; set; }
        public virtual DbSet<TMDT_Dim_OrderSource> TMDT_Dim_OrderSource { get; set; }
        public virtual DbSet<TMDT_Dim_OrderStatus> TMDT_Dim_OrderStatus { get; set; }
        public virtual DbSet<TMDT_Dim_ProcessingDepartment> TMDT_Dim_ProcessingDepartment { get; set; }
        public virtual DbSet<TMDT_Fact_Order> TMDT_Fact_Order { get; set; }
        public virtual DbSet<TMDT_Raw_Order> TMDT_Raw_Order { get; set; }
        public virtual DbSet<test_path> test_path { get; set; }

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

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("Action", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Action)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Action_Menu");
            });

            modelBuilder.Entity<ActionPageMapping>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.PageId });

                entity.ToTable("ActionPageMapping", "PER");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.ActionPageMapping)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPageMapping_Action");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.ActionPageMapping)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPageMapping_Page");
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppUserRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.AppUserId, e.RoleId })
                    .HasName("PK_UserRoleMapping");

                entity.ToTable("AppUserRoleMapping", "MDM");

                entity.HasOne(d => d.AppUser)
                    .WithMany(p => p.AppUserRoleMapping)
                    .HasForeignKey(d => d.AppUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserRoleMapping_Dim_AppUser");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AppUserRoleMapping)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppUserRoleMapping_Role");
            });

            modelBuilder.Entity<Counter>(entity =>
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

            modelBuilder.Entity<Dim_AppUser>(entity =>
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

            modelBuilder.Entity<Dim_AppUserStoreMapping>(entity =>
            {
                entity.HasKey(e => new { e.AppUserId, e.StoreId });

                entity.ToTable("Dim_AppUserStoreMapping", "DMS");
            });

            modelBuilder.Entity<Dim_Brand>(entity =>
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

            modelBuilder.Entity<Dim_BrandInStoreProductGroupingMapping>(entity =>
            {
                entity.HasKey(e => new { e.BrandInStoreId, e.ProductGroupingId })
                    .HasName("PK_BrandInStoreProductGroupingMapping");

                entity.ToTable("Dim_BrandInStoreProductGroupingMapping", "DMS");
            });

            modelBuilder.Entity<Dim_Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Dim_Country", "SAP");

                entity.Property(e => e.CountryCode).HasMaxLength(4000);

                entity.Property(e => e.CountryName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_County>(entity =>
            {
                entity.HasKey(e => e.CountyId);

                entity.ToTable("Dim_County", "SAP");

                entity.Property(e => e.CountyCode).HasMaxLength(4000);

                entity.Property(e => e.CountyName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_Customer", "SAP");

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_CustomerC2>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_CustomerC2", "DMS");

                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Date>(entity =>
            {
                entity.HasKey(e => e.DateKey);

                entity.ToTable("Dim_Date", "SAP");

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_DateMapping>(entity =>
            {
                entity.HasKey(e => e.DateKey);

                entity.ToTable("Dim_DateMapping", "SAP");

                entity.Property(e => e.DateKey).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_Date_Filter>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Dim_Date_Filter", "SAP");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_District>(entity =>
            {
                entity.HasKey(e => e.DistrictId)
                    .HasName("PK_Dim_Province");

                entity.ToTable("Dim_District", "DMS");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Dim_Employee", "PXK");

                entity.Property(e => e.EmployeeCode).HasMaxLength(4000);

                entity.Property(e => e.EmployeeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Item>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_Item", "SAP");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemDMS>(entity =>
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

            modelBuilder.Entity<Dim_ItemGroup>(entity =>
            {
                entity.HasKey(e => e.ItemGroupId)
                    .HasName("PK_Dim_ItemGroup_1");

                entity.ToTable("Dim_ItemGroup", "dbo");

                entity.Property(e => e.ItemGroupId).ValueGeneratedNever();

                entity.Property(e => e.ItemGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevelId);

                entity.ToTable("Dim_ItemGroupLevel", "dbo");

                entity.Property(e => e.ItemGroupLevelId).ValueGeneratedNever();

                entity.Property(e => e.ItemGroupLevelName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel1>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel1Id);

                entity.ToTable("Dim_ItemGroupLevel1", "SAP");

                entity.Property(e => e.ItemGroupLevel1Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel2>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel2Id);

                entity.ToTable("Dim_ItemGroupLevel2", "SAP");

                entity.Property(e => e.ItemGroupLevel2Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel3>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel3Id);

                entity.ToTable("Dim_ItemGroupLevel3", "SAP");

                entity.Property(e => e.ItemGroupLevel3Name).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemLedSmartGroup>(entity =>
            {
                entity.HasKey(e => e.ItemLedSmartGroupId);

                entity.ToTable("Dim_ItemLedSmartGroup", "SAP");

                entity.Property(e => e.ItemLedSmartGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemMainGroup>(entity =>
            {
                entity.HasKey(e => e.ItemMainGroupId);

                entity.ToTable("Dim_ItemMainGroup", "SAP");

                entity.Property(e => e.ItemMainGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_ItemMapping", "SAP");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Dim_ItemMapping)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_Item");

                entity.HasOne(d => d.ItemSingleSmartGroup)
                    .WithMany(p => p.Dim_ItemMapping)
                    .HasForeignKey(d => d.ItemSingleSmartGroupId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_ItemSingleSmartGroup");

                entity.HasOne(d => d.ItemType)
                    .WithMany(p => p.Dim_ItemMapping)
                    .HasForeignKey(d => d.ItemTypeId)
                    .HasConstraintName("FK_Dim_ItemMapping_Dim_ItemType");
            });

            modelBuilder.Entity<Dim_ItemNCTT>(entity =>
            {
                entity.HasKey(e => e.NCTTId)
                    .HasName("PK_Dim_NCTT");

                entity.ToTable("Dim_ItemNCTT", "SAP");

                entity.Property(e => e.NCTTName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemNewItemGroup>(entity =>
            {
                entity.HasKey(e => e.ItemNewItemGroupId)
                    .HasName("PK_DIm_ItemGroup_SPMOI");

                entity.ToTable("Dim_ItemNewItemGroup", "SAP");

                entity.Property(e => e.ItemNewItemGroupName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemSingleSmartGroup>(entity =>
            {
                entity.HasKey(e => e.ItemSingleSmartGroupId);

                entity.ToTable("Dim_ItemSingleSmartGroup", "SAP");

                entity.Property(e => e.ItemSingleSmartGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("Dim_ItemType", "SAP");

                entity.Property(e => e.ItemTypeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_ItemVATGroup>(entity =>
            {
                entity.HasKey(e => e.ItemVATGroupId)
                    .HasName("PK_Dim_ItemGroup_SMART");

                entity.ToTable("Dim_ItemVATGroup", "SAP");

                entity.Property(e => e.ItemVATGroupName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_KPIType>(entity =>
            {
                entity.HasKey(e => e.KPITypeId)
                    .HasName("PK_Dim_DensityProduct");

                entity.ToTable("Dim_KPIType", "dbo");

                entity.Property(e => e.KPITypeId).ValueGeneratedNever();

                entity.Property(e => e.KPITypeName)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_KPI_Measure>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Dim_KPI_Measure", "KPI");
            });

            modelBuilder.Entity<Dim_KPI_ProductGrouping>(entity =>
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

            modelBuilder.Entity<Dim_KPI_ProductGrouping_Mapping>(entity =>
            {
                entity.ToTable("Dim_KPI_ProductGrouping_Mapping", "KPI");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProductGroupingCode)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_Location>(entity =>
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

            modelBuilder.Entity<Dim_MainBusiness>(entity =>
            {
                entity.HasKey(e => e.MainBusinessId);

                entity.ToTable("Dim_MainBusiness", "SAP");

                entity.Property(e => e.MainBusinessName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Month>(entity =>
            {
                entity.HasKey(e => e.MonthKey);

                entity.ToTable("Dim_Month", "SAP");

                entity.Property(e => e.MonthKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.MonthName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_OrganizationUnit>(entity =>
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

            modelBuilder.Entity<Dim_OrganizationUnitMapping>(entity =>
            {
                entity.ToTable("Dim_OrganizationUnitMapping", "KPI");
            });

            modelBuilder.Entity<Dim_Period>(entity =>
            {
                entity.HasKey(e => e.PeriodId);

                entity.ToTable("Dim_Period", "KPI");

                entity.Property(e => e.PeriodId).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.MonthName).HasMaxLength(50);

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

            modelBuilder.Entity<Dim_Product>(entity =>
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

            modelBuilder.Entity<Dim_Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceId)
                    .HasName("PK_Dim_Province_1");

                entity.ToTable("Dim_Province", "DMS");

                entity.Property(e => e.ProvinceId).ValueGeneratedNever();

                entity.Property(e => e.ProvinceName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Quarter>(entity =>
            {
                entity.HasKey(e => e.QuarterKey);

                entity.ToTable("Dim_Quarter", "SAP");

                entity.Property(e => e.QuarterKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.QuarterName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_SaleBranch>(entity =>
            {
                entity.HasKey(e => e.SaleBranchId);

                entity.ToTable("Dim_SaleBranch", "SAP");

                entity.Property(e => e.DMS_Name).HasMaxLength(500);

                entity.Property(e => e.SaleBranchCode).HasMaxLength(4000);

                entity.Property(e => e.SaleBranchName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleChannel>(entity =>
            {
                entity.HasKey(e => e.SaleChannelId);

                entity.ToTable("Dim_SaleChannel", "SAP");

                entity.Property(e => e.SaleChannelName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleEmployee>(entity =>
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

            modelBuilder.Entity<Dim_SaleEntity>(entity =>
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

            modelBuilder.Entity<Dim_SaleLevel>(entity =>
            {
                entity.HasKey(e => e.SaleLevelId)
                    .HasName("PK_Dim_Type");

                entity.ToTable("Dim_SaleLevel", "DMS");

                entity.Property(e => e.SaleLevelId).ValueGeneratedNever();

                entity.Property(e => e.SaleLevelName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleRoom>(entity =>
            {
                entity.HasKey(e => e.SaleRoomId);

                entity.ToTable("Dim_SaleRoom", "SAP");

                entity.Property(e => e.SaleRoomCode).HasMaxLength(4000);

                entity.Property(e => e.SaleRoomName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_SaleUnitMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_SaleUnitMapping", "SAP");
            });

            modelBuilder.Entity<Dim_Store>(entity =>
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

            modelBuilder.Entity<Dim_StoreGrouping>(entity =>
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

            modelBuilder.Entity<Dim_StoreMapping>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_StoreMapping", "DMS");
            });

            modelBuilder.Entity<Dim_StoreType>(entity =>
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

            modelBuilder.Entity<Dim_Targets_SaleIn>(entity =>
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

            modelBuilder.Entity<Dim_Targets_SaleOut>(entity =>
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

            modelBuilder.Entity<Dim_TeamSale_Customer>(entity =>
            {
                entity.ToTable("Dim_TeamSale_Customer", "KPI");
            });

            modelBuilder.Entity<Dim_Warehouse>(entity =>
            {
                entity.HasKey(e => e.WarehouseId);

                entity.ToTable("Dim_Warehouse", "SAP");

                entity.Property(e => e.Location).HasMaxLength(4000);

                entity.Property(e => e.WarehouseLevel1Name).HasMaxLength(4000);

                entity.Property(e => e.WarehouseLevel2Name).HasMaxLength(4000);

                entity.Property(e => e.WhsBranchName).HasMaxLength(4000);

                entity.Property(e => e.WhsCode).HasMaxLength(4000);
            });

            modelBuilder.Entity<Dim_Week>(entity =>
            {
                entity.HasKey(e => e.WeekKey);

                entity.ToTable("Dim_Week", "SAP");

                entity.Property(e => e.WeekKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");

                entity.Property(e => e.WeekName).HasMaxLength(50);
            });

            modelBuilder.Entity<Dim_Year>(entity =>
            {
                entity.ToTable("Dim_Year", "SAP");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_Actual_Revenue>(entity =>
            {
                entity.ToTable("Fact_Actual_Revenue", "SAP");

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_BrandInStore>(entity =>
            {
                entity.HasKey(e => e.BrandInStoreId)
                    .HasName("PK_BrandInStore");

                entity.ToTable("Fact_BrandInStore", "DMS");

                entity.Property(e => e.BrandInStoreId).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DeletedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_Company_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_Company_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Company_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_Company_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Company_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_Company_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Country_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_Country_Month_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Country_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_Country_Quarter_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Country_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_Country_Year_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_County_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_County_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_County_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_County_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_County_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_County_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_Customer_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_Customer_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_Customer_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_Employee_Month_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_Employee_Quarter_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Employee_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_Employee_Year_Plan", "PXK");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Incur_Revenue>(entity =>
            {
                entity.ToTable("Fact_Incur_Revenue", "SAP");

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_IndirectSalesOrder>(entity =>
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

            modelBuilder.Entity<Fact_IndirectSalesOrderStoreGroupingMapping>(entity =>
            {
                entity.HasKey(e => e.IndirectSalesOrderStoreGroupingId)
                    .HasName("PK_Dim_IndirectSalesOrderStoreGroupingMapping");

                entity.ToTable("Fact_IndirectSalesOrderStoreGroupingMapping", "DMS");
            });

            modelBuilder.Entity<Fact_IndirectSalesOrderTransaction>(entity =>
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

            modelBuilder.Entity<Fact_Item_MinimumInventory>(entity =>
            {
                entity.ToTable("Fact_Item_MinimumInventory", "SAP");

                entity.Property(e => e.MinInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_Item_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_Item_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleUnit).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_Item_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_Item_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.SaleUnit).HasMaxLength(4000);
            });

            modelBuilder.Entity<Fact_Item_Whs_Inventory>(entity =>
            {
                entity.ToTable("Fact_Item_Whs_Inventory", "SAP");
            });

            modelBuilder.Entity<Fact_Item_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_Item_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_KPI_IndirectSalesOrder>(entity =>
            {
                entity.ToTable("Fact_KPI_IndirectSalesOrder", "KPI");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_KPI_ProductGroupingItem>(entity =>
            {
                entity.ToTable("Fact_KPI_ProductGroupingItem", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Fact_KPI_StoreChecking>(entity =>
            {
                entity.ToTable("Fact_KPI_StoreChecking", "KPI");

                entity.Property(e => e.CheckOutAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_KPI_StoreTypeHistory>(entity =>
            {
                entity.ToTable("Fact_KPI_StoreTypeHistory", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PreviousCreatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_MainBusiness_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_Revenue>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Revenue", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MainBusiness_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_MainBusiness_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_Month>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Month", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_Quarter>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Quarter", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_MinimumInventory_Year>(entity =>
            {
                entity.ToTable("Fact_MinimumInventory_Year", "SAP");

                entity.Property(e => e.MinimumInventory).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_ProductGrouping>(entity =>
            {
                entity.ToTable("Fact_ProductGrouping", "KPI");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_RevenueCustomerC2>(entity =>
            {
                entity.ToTable("Fact_RevenueCustomerC2", "DMS");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleInRevenue>(entity =>
            {
                entity.ToTable("Fact_SaleInRevenue", "KPI");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleIn_KpiCollectionResult>(entity =>
            {
                entity.ToTable("Fact_SaleIn_KpiCollectionResult", "KPI");

                entity.Property(e => e.Evaluation).HasMaxLength(50);

                entity.Property(e => e.Planned).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Result).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleOutRevenue>(entity =>
            {
                entity.ToTable("Fact_SaleOutRevenue", "KPI");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleOut_KpiCollectionResult>(entity =>
            {
                entity.ToTable("Fact_SaleOut_KpiCollectionResult", "KPI");

                entity.Property(e => e.Evaluation).HasMaxLength(50);

                entity.Property(e => e.Planned).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Result).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Month_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Month_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Quarter_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Quarter_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Quarter_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Week_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Week_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_TargetProduct_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_TargetProduct_Year_Plan", "PKH");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Year_Plan>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Year_Plan", "SAP");

                entity.Property(e => e.QuantityPlan).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(18, 10)");
            });

            modelBuilder.Entity<Fact_StoreChecking>(entity =>
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

            modelBuilder.Entity<Fact_TeamSale_Employee>(entity =>
            {
                entity.ToTable("Fact_TeamSale_Employee", "KPI");

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Field>(entity =>
            {
                entity.ToTable("Field", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.FieldType)
                    .WithMany(p => p.Field)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Field_FieldType");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Field)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionField_Menu");
            });

            modelBuilder.Entity<FieldType>(entity =>
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

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<ItemGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemGroup", "dbo");

                entity.Property(e => e.ItemGroupName).HasMaxLength(500);

                entity.Property(e => e.OrderId).HasMaxLength(4000);
            });

            modelBuilder.Entity<Job>(entity =>
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

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<KPIPlanSaleIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPIPlanSaleIn", "dbo");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPIRevenueSaleIn>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPIRevenueSaleIn", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(23, 4)");
            });

            modelBuilder.Entity<KPI_Actual_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Actual_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_CompleteThermosGroup_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_CompleteThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Dim_SaleEmployeeMapping>(entity =>
            {
                entity.ToTable("KPI_Dim_SaleEmployeeMapping", "NCTT");

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<KPI_Dim_SaleInKPI>(entity =>
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

            modelBuilder.Entity<KPI_Dim_SaleOutKPI>(entity =>
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

            modelBuilder.Entity<KPI_Fact_Result_Planned_General>(entity =>
            {
                entity.ToTable("KPI_Fact_Result_Planned_General", "NCTT");

                entity.Property(e => e.Planned).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Result).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Month_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Month_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Quarter_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Week_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Week_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleBranch_DensityProduct_Year_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleBranch_DensityProduct_Year_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Level1_RevenueId)
                    .HasName("PK_SaleIn_Level1_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueC1", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1NewProduct>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Level1NewItem_RevenueId)
                    .HasName("PK_SaleIn_Level1NewItem_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueC1NewProduct", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1NewProduct_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueC1NewProduct_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueC1_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueC1_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueReceipt>(entity =>
            {
                entity.HasKey(e => e.SaleIn_Receipt_RevenueId)
                    .HasName("PK_NCTT_Fact_SaleIn_Receipt_Revenue");

                entity.ToTable("KPI_Fact_SaleInRevenueReceipt", "NCTT");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleInRevenueReceipt_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleInRevenueReceipt_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutImageCount>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutImageCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutImageCount_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutImageCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutNewStoreCount_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutNewStoreCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutProblemCount_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutProblemCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenue>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenue", "NCTT");

                entity.Property(e => e.Action).HasMaxLength(4000);

                entity.Property(e => e.TotalValue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2SL_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2SL_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2Sum_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2Sum_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2TD_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2TD_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutRevenueC2_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutRevenueC2_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCheckingCount>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCheckingCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCheckingCount_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCheckingCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCount>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCount", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOutStoreCount_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOutStoreCount_Plan", "NCTT");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Month_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Month_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Quarter_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Quarter_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleOut_Year_Plan>(entity =>
            {
                entity.ToTable("KPI_Fact_SaleOut_Year_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Month_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Month_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Quarter_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Week_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Week_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Fact_SaleRoom_DensityProduct_Year_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Fact_SaleRoom_DensityProduct_Year_Revenue", "dbo");

                entity.Property(e => e.Revenue).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<KPI_Incur_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_Incur_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LEDGroup_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LEDGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_GTGT_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_GTGT_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_NewItem_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_NewItem_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_LED_SmartGroup_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_LED_SmartGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_PremiumThermosGroup_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_PremiumThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<KPI_Raw_SaleEmployeeMapping>(entity =>
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

            modelBuilder.Entity<KPI_Raw_SaleInCountyMapping>(entity =>
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

            modelBuilder.Entity<KPI_Raw_SaleInRevenueC1NewProduct_Plan>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueC1NewProduct_Plan", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Raw_SaleInRevenueReceipt>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueReceipt", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_Raw_SaleInRevenueReceipt_Plan>(entity =>
            {
                entity.ToTable("KPI_Raw_SaleInRevenueReceipt_Plan", "NCTT");

                entity.Property(e => e.County).HasMaxLength(500);

                entity.Property(e => e.KPI).HasMaxLength(500);

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<KPI_ThermosGroup_Revenue>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("KPI_ThermosGroup_Revenue", "dbo");
            });

            modelBuilder.Entity<List>(entity =>
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

            modelBuilder.Entity<Log_Table>(entity =>
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

            modelBuilder.Entity<Menu>(entity =>
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

            modelBuilder.Entity<NCTT_Dim_ItemCharacteristic>(entity =>
            {
                entity.HasKey(e => e.ItemCharacteristicId);

                entity.ToTable("NCTT_Dim_ItemCharacteristic", "NCTT");

                entity.Property(e => e.ItemCharacteristicName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemClass>(entity =>
            {
                entity.HasKey(e => e.ItemClassId)
                    .HasName("PK_Dim_ItemClass");

                entity.ToTable("NCTT_Dim_ItemClass", "NCTT");

                entity.Property(e => e.ItemClassName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemGroup>(entity =>
            {
                entity.HasKey(e => e.ItemGroupId)
                    .HasName("PK_Dim_ItemGroup");

                entity.ToTable("NCTT_Dim_ItemGroup", "NCTT");

                entity.Property(e => e.ItemGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemLine>(entity =>
            {
                entity.HasKey(e => e.ItemLineId)
                    .HasName("PK_Dim_ItemLine");

                entity.ToTable("NCTT_Dim_ItemLine", "NCTT");

                entity.Property(e => e.ItemLineName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemMapping>(entity =>
            {
                entity.HasKey(e => e.ItemMappingId)
                    .HasName("PK_Dim_ItemMapping_1");

                entity.ToTable("NCTT_Dim_ItemMapping", "NCTT");
            });

            modelBuilder.Entity<NCTT_Dim_ItemPropertyDetail>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyId)
                    .HasName("PK_Dim_ItemPropertyDetail");

                entity.ToTable("NCTT_Dim_ItemPropertyDetail", "NCTT");

                entity.Property(e => e.ItemPropertyName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemPropertyGroup>(entity =>
            {
                entity.HasKey(e => e.ItemPropertyGroupId)
                    .HasName("PK_Dim_ItemPropertyGroup");

                entity.ToTable("NCTT_Dim_ItemPropertyGroup", "NCTT");

                entity.Property(e => e.ItemPropertyGroupName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Dim_ItemType>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("NCTT_Dim_ItemType", "NCTT");

                entity.Property(e => e.ItemTypeName).HasMaxLength(4000);
            });

            modelBuilder.Entity<NCTT_Fact_CountyScope>(entity =>
            {
                entity.HasKey(e => e.CountyScopeId)
                    .HasName("PK_NCTT_Fact_CityProperty");

                entity.ToTable("NCTT_Fact_CountyScope", "NCTT");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.FDI).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GRDP).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UrbanizationRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Fact_KPI_SaleOut_Plan>(entity =>
            {
                entity.ToTable("NCTT_Fact_KPI_SaleOut_Plan", "NCTT");

                entity.Property(e => e.Plan).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NCTT_Fact_KPI_SaleOut_Revenue>(entity =>
            {
                entity.ToTable("NCTT_Fact_KPI_SaleOut_Revenue", "NCTT");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<NCTT_Fact_Revenue>(entity =>
            {
                entity.ToTable("NCTT_Fact_Revenue", "NCTT");

                entity.Property(e => e.OrderId).HasMaxLength(4000);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Raw_CountyScope>(entity =>
            {
                entity.ToTable("NCTT_Raw_CountyScope", "NCTT");

                entity.Property(e => e.Area).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.County).HasMaxLength(4000);

                entity.Property(e => e.FDI).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.GRDP).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.UrbanizationRate).HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<NCTT_Raw_NewItem>(entity =>
            {
                entity.ToTable("NCTT_Raw_NewItem", "NCTT");

                entity.Property(e => e.ItemCode).HasMaxLength(500);

                entity.Property(e => e.ItemName).HasMaxLength(500);
            });

            modelBuilder.Entity<NCTT_Raw_PBH1_PBH2>(entity =>
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

            modelBuilder.Entity<NCTT_Raw_ProductGroup>(entity =>
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

            modelBuilder.Entity<NCTT_Raw_ProductGroup_Temp>(entity =>
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

            modelBuilder.Entity<Page>(entity =>
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
                    .WithMany(p => p.Page)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Page_Menu");
            });

            modelBuilder.Entity<Permission>(entity =>
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
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.MenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Menu");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Role");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Permission)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Permission_Status");
            });

            modelBuilder.Entity<PermissionActionMapping>(entity =>
            {
                entity.HasKey(e => new { e.ActionId, e.PermissionId })
                    .HasName("PK_ActionPermissionMapping");

                entity.ToTable("PermissionActionMapping", "PER");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.PermissionActionMapping)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPermissionMapping_Action");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionActionMapping)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActionPermissionMapping_Permission");
            });

            modelBuilder.Entity<PermissionContent>(entity =>
            {
                entity.ToTable("PermissionContent", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(500);

                entity.HasOne(d => d.Field)
                    .WithMany(p => p.PermissionContent)
                    .HasForeignKey(d => d.FieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_Field");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionContent)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_Permission");

                entity.HasOne(d => d.PermissionOperator)
                    .WithMany(p => p.PermissionContent)
                    .HasForeignKey(d => d.PermissionOperatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionContent_PermissionOperator");
            });

            modelBuilder.Entity<PermissionOperator>(entity =>
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
                    .WithMany(p => p.PermissionOperator)
                    .HasForeignKey(d => d.FieldTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionOperator_FieldType");
            });

            modelBuilder.Entity<Raw_A009>(entity =>
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

            modelBuilder.Entity<Raw_A012>(entity =>
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

            modelBuilder.Entity<Raw_ActualReport>(entity =>
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

            modelBuilder.Entity<Raw_ActualReportClone>(entity =>
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

            modelBuilder.Entity<Raw_ActualReport_T4>(entity =>
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

            modelBuilder.Entity<Raw_B003>(entity =>
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

            modelBuilder.Entity<Raw_B1_1_IncurReport_Rep>(entity =>
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

            modelBuilder.Entity<Raw_B1_1_IncurReport_Rep_Test>(entity =>
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

            modelBuilder.Entity<Raw_B1_5_ActualExportReport_Rep>(entity =>
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

            modelBuilder.Entity<Raw_B1_5_ActualExportReport_Rep_Test>(entity =>
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

            modelBuilder.Entity<Raw_Customer_Rep>(entity =>
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

            modelBuilder.Entity<Raw_Customer_Temp>(entity =>
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

            modelBuilder.Entity<Raw_Employee>(entity =>
            {
                entity.ToTable("Raw_Employee", "PXK");

                entity.Property(e => e.MaNV).HasMaxLength(4000);

                entity.Property(e => e.TenNV).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_IncurReport>(entity =>
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

            modelBuilder.Entity<Raw_IncurReport_T4>(entity =>
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

            modelBuilder.Entity<Raw_Item_Rep>(entity =>
            {
                entity.ToTable("Raw_Item_Rep", "SAP");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Item_Temp>(entity =>
            {
                entity.ToTable("Raw_Item_Temp", "NCTT");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_KeyCustomer>(entity =>
            {
                entity.ToTable("Raw_KeyCustomer", "NCTT");

                entity.Property(e => e.CustomerCode).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(500);

                entity.Property(e => e.DMS_StoreName).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_Location_Rep>(entity =>
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

            modelBuilder.Entity<Raw_MainBusiness>(entity =>
            {
                entity.ToTable("Raw_MainBusiness", "PKH");

                entity.Property(e => e.Doanhthu).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.Thoidiem).HasColumnType("date");

                entity.Property(e => e.Trucot).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_MinimumInventory>(entity =>
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

            modelBuilder.Entity<Raw_ProductGroup>(entity =>
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

            modelBuilder.Entity<Raw_Product_Grouping>(entity =>
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

            modelBuilder.Entity<Raw_Product_SalePlan>(entity =>
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

            modelBuilder.Entity<Raw_SaleBranchDMSMapping>(entity =>
            {
                entity.ToTable("Raw_SaleBranchDMSMapping", "DMS");

                entity.Property(e => e.DMS_Name).HasMaxLength(500);

                entity.Property(e => e.SaleBranchName).HasMaxLength(500);

                entity.Property(e => e.SaleRoomName).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_SaleIn_Plan>(entity =>
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

            modelBuilder.Entity<Raw_SaleIn_Plan_Ver2>(entity =>
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

            modelBuilder.Entity<Raw_SaleOut_Plan>(entity =>
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

            modelBuilder.Entity<Raw_SaleOut_Plan_Ver2>(entity =>
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

            modelBuilder.Entity<Raw_SalePlan_Revenue>(entity =>
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

            modelBuilder.Entity<Raw_SaleUnit_SalePlan_Quantity>(entity =>
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

            modelBuilder.Entity<Raw_SaleUnit_SalePlan_Revenue>(entity =>
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

            modelBuilder.Entity<Raw_TeamSale_Customer>(entity =>
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

            modelBuilder.Entity<Raw_TeamSale_Employee>(entity =>
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

            modelBuilder.Entity<Raw_Warehouse>(entity =>
            {
                entity.HasKey(e => e.InventoryId)
                    .HasName("PK_Raw_Inventory");

                entity.ToTable("Raw_Warehouse", "PKH");

                entity.Property(e => e.TEN_KHO_C1).HasMaxLength(4000);

                entity.Property(e => e.TEN_KHO_C2).HasMaxLength(4000);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role", "PER");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Status");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat)
                    .HasName("IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(200);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
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

            modelBuilder.Entity<State>(entity =>
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
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Status>(entity =>
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

            modelBuilder.Entity<TMDT_Dim_City>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("TMDT_Dim_City", "TMDT");

                entity.Property(e => e.CityName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("TMDT_Dim_Customer", "TMDT");

                entity.Property(e => e.CustomerAddress).HasMaxLength(4000);

                entity.Property(e => e.CustomerCity).HasMaxLength(4000);

                entity.Property(e => e.CustomerCode).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(4000);

                entity.Property(e => e.CustomerPhoneNumber).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_OrderSource>(entity =>
            {
                entity.HasKey(e => e.OrderSourceId);

                entity.ToTable("TMDT_Dim_OrderSource", "TMDT");

                entity.Property(e => e.OrderSourceName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_OrderStatus>(entity =>
            {
                entity.HasKey(e => e.OrderStatusId);

                entity.ToTable("TMDT_Dim_OrderStatus", "TMDT");

                entity.Property(e => e.OrderStatusName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Dim_ProcessingDepartment>(entity =>
            {
                entity.HasKey(e => e.ProcessingDepartmentId);

                entity.ToTable("TMDT_Dim_ProcessingDepartment", "TMDT");

                entity.Property(e => e.ProcessingDepartmentName).HasMaxLength(4000);
            });

            modelBuilder.Entity<TMDT_Fact_Order>(entity =>
            {
                entity.ToTable("TMDT_Fact_Order", "TMDT");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.OrderValue).HasMaxLength(500);

                entity.Property(e => e.Price).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(22, 10)");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<TMDT_Raw_Order>(entity =>
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

            modelBuilder.Entity<test_path>(entity =>
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
