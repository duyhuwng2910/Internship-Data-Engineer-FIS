using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DW_Test.Models
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<AggregatedCounterDAO> AggregatedCounter { get; set; }
        public virtual DbSet<CT_PBH1DAO> CT_PBH1 { get; set; }
        public virtual DbSet<CT_PBH2DAO> CT_PBH2 { get; set; }
        public virtual DbSet<CounterDAO> Counter { get; set; }
        public virtual DbSet<Dim_CountryDAO> Dim_Country { get; set; }
        public virtual DbSet<Dim_CountyDAO> Dim_County { get; set; }
        public virtual DbSet<Dim_CustomerDAO> Dim_Customer { get; set; }
        public virtual DbSet<Dim_CustomerEmployeeMappingDAO> Dim_CustomerEmployeeMapping { get; set; }
        public virtual DbSet<Dim_DateDAO> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMappingDAO> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_Date_FilterDAO> Dim_Date_Filter { get; set; }
        public virtual DbSet<Dim_ItemDAO> Dim_Item { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel1DAO> Dim_ItemGroupLevel1 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel2DAO> Dim_ItemGroupLevel2 { get; set; }
        public virtual DbSet<Dim_ItemGroupLevel3DAO> Dim_ItemGroupLevel3 { get; set; }
        public virtual DbSet<Dim_ItemLedSmartGroupDAO> Dim_ItemLedSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemMainGroupDAO> Dim_ItemMainGroup { get; set; }
        public virtual DbSet<Dim_ItemMappingDAO> Dim_ItemMapping { get; set; }
        public virtual DbSet<Dim_ItemNewItemGroupDAO> Dim_ItemNewItemGroup { get; set; }
        public virtual DbSet<Dim_ItemSingleLedSmartGroupDAO> Dim_ItemSingleLedSmartGroup { get; set; }
        public virtual DbSet<Dim_ItemTypeGroupDAO> Dim_ItemTypeGroup { get; set; }
        public virtual DbSet<Dim_ItemVATGroupDAO> Dim_ItemVATGroup { get; set; }
        public virtual DbSet<Dim_MonthDAO> Dim_Month { get; set; }
        public virtual DbSet<Dim_ProductMappingDAO> Dim_ProductMapping { get; set; }
        public virtual DbSet<Dim_ProductSaleChannelMappingDAO> Dim_ProductSaleChannelMapping { get; set; }
        public virtual DbSet<Dim_QuarterDAO> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_RD_CustomerDAO> Dim_RD_Customer { get; set; }
        public virtual DbSet<Dim_RD_ItemDAO> Dim_RD_Item { get; set; }
        public virtual DbSet<Dim_RD_ItemGroupLevel1DAO> Dim_RD_ItemGroupLevel1 { get; set; }
        public virtual DbSet<Dim_RD_ItemGroupLevel2DAO> Dim_RD_ItemGroupLevel2 { get; set; }
        public virtual DbSet<Dim_RD_SaleChannelDAO> Dim_RD_SaleChannel { get; set; }
        public virtual DbSet<Dim_RegionDAO> Dim_Region { get; set; }
        public virtual DbSet<Dim_SaleBranchDAO> Dim_SaleBranch { get; set; }
        public virtual DbSet<Dim_SaleChannelDAO> Dim_SaleChannel { get; set; }
        public virtual DbSet<Dim_SaleEmployeeDAO> Dim_SaleEmployee { get; set; }
        public virtual DbSet<Dim_SaleRoomDAO> Dim_SaleRoom { get; set; }
        public virtual DbSet<Dim_SpecializedChannelMappingDAO> Dim_SpecializedChannelMapping { get; set; }
        public virtual DbSet<Dim_UnitMappingDAO> Dim_UnitMapping { get; set; }
        public virtual DbSet<Dim_YearDAO> Dim_Year { get; set; }
        public virtual DbSet<Fact_Company_Month_PlanDAO> Fact_Company_Month_Plan { get; set; }
        public virtual DbSet<Fact_Company_Quarter_PlanDAO> Fact_Company_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Company_Year_PlanDAO> Fact_Company_Year_Plan { get; set; }
        public virtual DbSet<Fact_County_Month_PlanDAO> Fact_County_Month_Plan { get; set; }
        public virtual DbSet<Fact_County_Quarter_PlanDAO> Fact_County_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_County_Year_PlanDAO> Fact_County_Year_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Month_PlanDAO> Fact_Customer_Month_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Quarter_PlanDAO> Fact_Customer_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_Customer_Year_PlanDAO> Fact_Customer_Year_Plan { get; set; }
        public virtual DbSet<Fact_Item_Whs_ConsignmentDAO> Fact_Item_Whs_Consignment { get; set; }
        public virtual DbSet<Fact_RD_CustomerMonthPlanDAO> Fact_RD_CustomerMonthPlan { get; set; }
        public virtual DbSet<Fact_RD_CustomerQuarterPlanDAO> Fact_RD_CustomerQuarterPlan { get; set; }
        public virtual DbSet<Fact_RD_CustomerYearPlanDAO> Fact_RD_CustomerYearPlan { get; set; }
        public virtual DbSet<Fact_RD_RegionMonthPlanDAO> Fact_RD_RegionMonthPlan { get; set; }
        public virtual DbSet<Fact_RD_RegionQuarterPlanDAO> Fact_RD_RegionQuarterPlan { get; set; }
        public virtual DbSet<Fact_RD_RegionYearPlanDAO> Fact_RD_RegionYearPlan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannelMonthPlanDAO> Fact_RD_SaleChannelMonthPlan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannelQuarterPlanDAO> Fact_RD_SaleChannelQuarterPlan { get; set; }
        public virtual DbSet<Fact_RD_SaleChannelYearPlanDAO> Fact_RD_SaleChannelYearPlan { get; set; }
        public virtual DbSet<Fact_Report_RevenueDAO> Fact_Report_Revenue { get; set; }
        public virtual DbSet<Fact_SaleBranch_Month_PlanDAO> Fact_SaleBranch_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Quarter_PlanDAO> Fact_SaleBranch_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleBranch_Year_PlanDAO> Fact_SaleBranch_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Month_PlanDAO> Fact_SaleChannel_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Quarter_PlanDAO> Fact_SaleChannel_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleChannel_Year_PlanDAO> Fact_SaleChannel_Year_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Month_PlanDAO> Fact_SaleRoom_Month_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Quarter_PlanDAO> Fact_SaleRoom_Quarter_Plan { get; set; }
        public virtual DbSet<Fact_SaleRoom_Year_PlanDAO> Fact_SaleRoom_Year_Plan { get; set; }
        public virtual DbSet<FormulaDAO> Formula { get; set; }
        public virtual DbSet<HashDAO> Hash { get; set; }
        public virtual DbSet<JobDAO> Job { get; set; }
        public virtual DbSet<JobParameterDAO> JobParameter { get; set; }
        public virtual DbSet<JobQueueDAO> JobQueue { get; set; }
        public virtual DbSet<ListDAO> List { get; set; }
        public virtual DbSet<Raw_A009DAO> Raw_A009 { get; set; }
        public virtual DbSet<Raw_A012DAO> Raw_A012 { get; set; }
        public virtual DbSet<Raw_B003DAO> Raw_B003 { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_Customer_RepDAO> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Item_RepDAO> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Plan_RevenueDAO> Raw_Plan_Revenue { get; set; }
        public virtual DbSet<Raw_Product_GroupDAO> Raw_Product_Group { get; set; }
        public virtual DbSet<Raw_Product_ProductGroupDAO> Raw_Product_ProductGroup { get; set; }
        public virtual DbSet<Raw_SaleEmployeeDAO> Raw_SaleEmployee { get; set; }
        public virtual DbSet<Raw_SaleEmployee_CustomerDAO> Raw_SaleEmployee_Customer { get; set; }
        public virtual DbSet<Raw_SpecializedChannelDAO> Raw_SpecializedChannel { get; set; }
        public virtual DbSet<Raw_SpecializedChannel_SalePlan_RevenueDAO> Raw_SpecializedChannel_SalePlan_Revenue { get; set; }
        public virtual DbSet<SchemaDAO> Schema { get; set; }
        public virtual DbSet<ServerDAO> Server { get; set; }
        public virtual DbSet<SetDAO> Set { get; set; }
        public virtual DbSet<StateDAO> State { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=192.168.20.200;initial catalog=DW_TEST;persist security info=True;user id=TTS_Data;password=1234567;multipleactiveresultsets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AggregatedCounterDAO>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<CT_PBH1DAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CT PBH1");
            });

            modelBuilder.Entity<CT_PBH2DAO>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CT PBH2");
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

            modelBuilder.Entity<Dim_CountryDAO>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Dim_Country", "SAP");

                entity.Property(e => e.CountryCode).HasMaxLength(500);

                entity.Property(e => e.CountryName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_CountyDAO>(entity =>
            {
                entity.HasKey(e => e.CountyId);

                entity.ToTable("Dim_County", "SAP");

                entity.Property(e => e.CountyCode).HasMaxLength(500);

                entity.Property(e => e.CountyName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_CustomerDAO>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Dim_Customer", "SAP");

                entity.Property(e => e.CustomerCode).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(500);
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

                entity.ToView("Dim_Date_Filter");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Dim_ItemDAO>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_Item", "SAP");

                entity.Property(e => e.ItemCode).HasMaxLength(500);

                entity.Property(e => e.ItemName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel1DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel1Id)
                    .HasName("PK_Dim_Item_Group_Level_1");

                entity.ToTable("Dim_ItemGroupLevel1", "SAP");

                entity.Property(e => e.ItemGroupLevel1Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel2DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel2Id)
                    .HasName("PK_Dim_Item_Group_Level_2");

                entity.ToTable("Dim_ItemGroupLevel2", "SAP");

                entity.Property(e => e.ItemGroupLevel2Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemGroupLevel3DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel3Id)
                    .HasName("PK_Dim_Item_Group_Level_3");

                entity.ToTable("Dim_ItemGroupLevel3", "SAP");

                entity.Property(e => e.ItemGroupLevel3Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemLedSmartGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemLedSmartGroupId)
                    .HasName("PK_Dim_Item_Led_Smart_Group");

                entity.ToTable("Dim_ItemLedSmartGroup", "SAP");

                entity.Property(e => e.ItemLedSmartGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemMainGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemMainGroupId)
                    .HasName("PK_Dim_Item_Main_Group");

                entity.ToTable("Dim_ItemMainGroup", "SAP");

                entity.Property(e => e.ItemMainGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemMappingDAO>(entity =>
            {
                entity.HasKey(e => e.Item_MappingId)
                    .HasName("PK_Dim_Item_Mapping");

                entity.ToTable("Dim_ItemMapping", "SAP");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(500)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Dim_ItemNewItemGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemNewItemGroupId)
                    .HasName("PK_Dim_Item_New_Item_Group");

                entity.ToTable("Dim_ItemNewItemGroup", "SAP");

                entity.Property(e => e.ItemNewItemGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemSingleLedSmartGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemSingleLedSmartGroupId)
                    .HasName("PK_Dim_Item_Single_Led_Smart_Group");

                entity.ToTable("Dim_ItemSingleLedSmartGroup", "SAP");

                entity.Property(e => e.ItemSingleLedSmartGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemTypeGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId)
                    .HasName("PK_Dim_Item_Type_Group");

                entity.ToTable("Dim_ItemTypeGroup", "SAP");

                entity.Property(e => e.ItemTypeName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_ItemVATGroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemVATGroupId)
                    .HasName("PK_Dim_Item_VAT_Group");

                entity.ToTable("Dim_ItemVATGroup", "SAP");

                entity.Property(e => e.ItemVATGroupName).HasMaxLength(500);
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

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.CustomerName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RD_ItemDAO>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("Dim_RD_Item", "RD");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(1000);

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

                entity.Property(e => e.SaleChannelName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_RegionDAO>(entity =>
            {
                entity.HasKey(e => e.RegionId);

                entity.ToTable("Dim_Region", "RD");

                entity.Property(e => e.RegionCode).HasMaxLength(1000);

                entity.Property(e => e.RegionName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_SaleBranchDAO>(entity =>
            {
                entity.HasKey(e => e.SaleBranchId);

                entity.ToTable("Dim_SaleBranch", "SAP");

                entity.Property(e => e.SaleBranchName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleChannelDAO>(entity =>
            {
                entity.HasKey(e => e.SaleChannelId);

                entity.ToTable("Dim_SaleChannel", "SAP");

                entity.Property(e => e.SaleChannelName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SaleEmployeeDAO>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("Dim_SaleEmployee", "RD");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.EmployeeName).HasMaxLength(1000);
            });

            modelBuilder.Entity<Dim_SaleRoomDAO>(entity =>
            {
                entity.HasKey(e => e.SaleRoomId);

                entity.ToTable("Dim_SaleRoom", "SAP");

                entity.Property(e => e.SaleRoomName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_SpecializedChannelMappingDAO>(entity =>
            {
                entity.HasKey(e => e.MappingId);

                entity.ToTable("Dim_SpecializedChannelMapping", "RD");
            });

            modelBuilder.Entity<Dim_UnitMappingDAO>(entity =>
            {
                entity.HasKey(e => e.Unit_MappingId)
                    .HasName("PK_Dim_Unit_Mapping");

                entity.ToTable("Dim_UnitMapping", "SAP");

                entity.Property(e => e.dem)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dim_YearDAO>(entity =>
            {
                entity.HasKey(e => e.Yearkey)
                    .HasName("PK_Dim_Year_1");

                entity.ToTable("Dim_Year", "SAP");

                entity.Property(e => e.Yearkey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Fact_Company_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Company_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Company_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Company_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_County_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_County_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_County_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_County_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Customer_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_Customer_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Item_Whs_ConsignmentDAO>(entity =>
            {
                entity.ToTable("Fact_Item_Whs_Consignment", "RD");

                entity.Property(e => e.Consignment).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_CustomerMonthPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_CustomerMonthPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_CustomerQuarterPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_CustomerQuarterPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_CustomerYearPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_CustomerYearPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_RegionMonthPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_RegionMonthPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_RegionQuarterPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_RegionQuarterPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_RegionYearPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_RegionYearPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannelMonthPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannelMonthPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannelQuarterPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannelQuarterPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_RD_SaleChannelYearPlanDAO>(entity =>
            {
                entity.ToTable("Fact_RD_SaleChannelYearPlan", "RD");

                entity.Property(e => e.RevenuePlan).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_Report_RevenueDAO>(entity =>
            {
                entity.ToTable("Fact_Report_Revenue", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleBranch_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleBranch_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleChannel_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleChannel_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Month_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Month_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Quarter_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Quarter_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<Fact_SaleRoom_Year_PlanDAO>(entity =>
            {
                entity.ToTable("Fact_SaleRoom_Year_Plan", "SAP");

                entity.Property(e => e.Revenue).HasColumnType("decimal(22, 10)");
            });

            modelBuilder.Entity<HashDAO>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<JobDAO>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.HasIndex(e => new { e.StateName, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

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

            modelBuilder.Entity<ListDAO>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt)
                    .HasName("IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
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

            modelBuilder.Entity<Raw_Item_RepDAO>(entity =>
            {
                entity.ToTable("Raw_Item_Rep", "SAP");

                entity.Property(e => e.ItemCode).HasMaxLength(4000);

                entity.Property(e => e.ItemName).HasMaxLength(4000);
            });

            modelBuilder.Entity<Raw_Plan_RevenueDAO>(entity =>
            {
                entity.ToTable("Raw_Plan_Revenue", "SAP");

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

                entity.Property(e => e.Kenh).HasMaxLength(500);

                entity.Property(e => e.KhachHang).HasMaxLength(500);

                entity.Property(e => e.MaKhachHang).HasMaxLength(500);

                entity.Property(e => e.PhongBanHang).HasMaxLength(500);

                entity.Property(e => e.Tinh).HasMaxLength(500);

                entity.Property(e => e.TongCongTy).HasMaxLength(500);

                entity.Property(e => e.VungChiNhanh).HasMaxLength(500);
            });

            modelBuilder.Entity<Raw_Product_GroupDAO>(entity =>
            {
                entity.ToTable("Raw_Product_Group", "SAP");

                entity.Property(e => e.GTGT_EndDate).HasColumnType("datetime");

                entity.Property(e => e.GTGT_StartDate).HasColumnType("datetime");

                entity.Property(e => e.ItemCode).HasMaxLength(500);

                entity.Property(e => e.ItemName).HasMaxLength(500);

                entity.Property(e => e.Loai_MHang_KH).HasMaxLength(500);

                entity.Property(e => e.M_EndDate).HasColumnType("datetime");

                entity.Property(e => e.M_StartDate).HasColumnType("datetime");

                entity.Property(e => e.NhomC1).HasMaxLength(500);

                entity.Property(e => e.NhomC2).HasMaxLength(500);

                entity.Property(e => e.NhomC3).HasMaxLength(500);

                entity.Property(e => e.Nhom_LEDSMRT1).HasMaxLength(500);

                entity.Property(e => e.Nhom_SMARTDONLE).HasMaxLength(500);

                entity.Property(e => e.Nhomchinh_KH).HasMaxLength(500);
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

            modelBuilder.Entity<Raw_SaleEmployeeDAO>(entity =>
            {
                entity.ToTable("Raw_SaleEmployee", "RD");

                entity.Property(e => e.MaNV)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.TenNV).HasMaxLength(1000);
            });

            modelBuilder.Entity<Raw_SaleEmployee_CustomerDAO>(entity =>
            {
                entity.ToTable("Raw_SaleEmployee_Customer", "RD");

                entity.Property(e => e.MaKH).HasMaxLength(1000);

                entity.Property(e => e.MaNV).HasMaxLength(1000);

                entity.Property(e => e.TenKH).HasMaxLength(1000);

                entity.Property(e => e.TenNV).HasMaxLength(1000);
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
                    .HasName("IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
