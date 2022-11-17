using DW_Test.HashModels;
using Microsoft.EntityFrameworkCore;

namespace DW_Test.Models
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<Dim_CountryDAO> Dim_Country { get; set; }
        public virtual DbSet<Dim_CountyDAO> Dim_County { get; set; }
        public virtual DbSet<Dim_CustomerDAO> Dim_Customer { get; set; }
        public virtual DbSet<Dim_DateDAO> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMappingDAO> Dim_DateMapping { get; set; }
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
        public virtual DbSet<Dim_QuarterDAO> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_SaleBranchDAO> Dim_SaleBranch { get; set; }
        public virtual DbSet<Dim_SaleChannelDAO> Dim_SaleChannel { get; set; }
        public virtual DbSet<Dim_SaleRoomDAO> Dim_SaleRoom { get; set; }
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
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_Customer_RepDAO> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Item_RepDAO> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Plan_RevenueDAO> Raw_Plan_Revenue { get; set; }
        public virtual DbSet<Raw_Product_GroupDAO> Raw_Product_Group { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("data source=NGUYENDUYHUNG;initial catalog=DW_TEST;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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

                entity.Property(e => e.ItemSingleLedSmartGroupId)
                    .HasMaxLength(10)
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

            modelBuilder.Entity<Dim_QuarterDAO>(entity =>
            {
                entity.HasKey(e => e.QuarterKey);

                entity.ToTable("Dim_Quarter", "SAP");

                entity.Property(e => e.QuarterKey).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.QuarterName).HasMaxLength(50);

                entity.Property(e => e.StartAt).HasColumnType("datetime");
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

            modelBuilder.Entity<Dim_SaleRoomDAO>(entity =>
            {
                entity.HasKey(e => e.SaleRoomId);

                entity.ToTable("Dim_SaleRoom", "SAP");

                entity.Property(e => e.SaleRoomName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_UnitMappingDAO>(entity =>
            {
                entity.HasKey(e => e.Unit_MappingId)
                    .HasName("PK_Dim_Unit_Mapping");

                entity.ToTable("Dim_UnitMapping", "SAP");
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

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student", "dbo");

                entity.Property(e => e.StudentID).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Age).HasColumnType("bigint");

                entity.Property(e => e.GPA).HasColumnType("bigint");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
