using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DW_Test.Models
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<Dim_DateDAO> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMappingDAO> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_ItemDAO> Dim_Item { get; set; }
        public virtual DbSet<Dim_Item_Group_Level_1DAO> Dim_Item_Group_Level_1 { get; set; }
        public virtual DbSet<Dim_Item_Group_Level_2DAO> Dim_Item_Group_Level_2 { get; set; }
        public virtual DbSet<Dim_Item_Group_Level_3DAO> Dim_Item_Group_Level_3 { get; set; }
        public virtual DbSet<Dim_Item_Led_Smart_GroupDAO> Dim_Item_Led_Smart_Group { get; set; }
        public virtual DbSet<Dim_Item_Main_GroupDAO> Dim_Item_Main_Group { get; set; }
        public virtual DbSet<Dim_Item_New_Item_GroupDAO> Dim_Item_New_Item_Group { get; set; }
        public virtual DbSet<Dim_Item_Type_GroupDAO> Dim_Item_Type_Group { get; set; }
        public virtual DbSet<Dim_Item_VAT_GroupDAO> Dim_Item_VAT_Group { get; set; }
        public virtual DbSet<Dim_MonthDAO> Dim_Month { get; set; }
        public virtual DbSet<Dim_QuarterDAO> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_YearDAO> Dim_Year { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_Customer_RepDAO> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Item_RepDAO> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Plan_RevenueDAO> Raw_Plan_Revenue { get; set; }
        public virtual DbSet<Raw_Product_GroupDAO> Raw_Product_Group { get; set; }

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

            modelBuilder.Entity<Dim_Item_Group_Level_1DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel1Id);

                entity.ToTable("Dim_Item_Group_Level_1", "SAP");

                entity.Property(e => e.ItemGroupLevel1Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_Group_Level_2DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel2Id);

                entity.ToTable("Dim_Item_Group_Level_2", "SAP");

                entity.Property(e => e.ItemGroupLevel2Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_Group_Level_3DAO>(entity =>
            {
                entity.HasKey(e => e.ItemGroupLevel3Id);

                entity.ToTable("Dim_Item_Group_Level_3", "SAP");

                entity.Property(e => e.ItemGroupLevel3Name).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_Led_Smart_GroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemLedSmartGroupId);

                entity.ToTable("Dim_Item_Led_Smart_Group", "SAP");

                entity.Property(e => e.ItemLedSmartGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_Main_GroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemMainGroupId);

                entity.ToTable("Dim_Item_Main_Group", "SAP");

                entity.Property(e => e.ItemMainGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_New_Item_GroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemNewItemGroupId);

                entity.ToTable("Dim_Item_New_Item_Group", "SAP");

                entity.Property(e => e.ItemNewItemGroupName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_Type_GroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemTypeId);

                entity.ToTable("Dim_Item_Type_Group", "SAP");

                entity.Property(e => e.ItemTypeName).HasMaxLength(500);
            });

            modelBuilder.Entity<Dim_Item_VAT_GroupDAO>(entity =>
            {
                entity.HasKey(e => e.ItemVATGroupId);

                entity.ToTable("Dim_Item_VAT_Group", "SAP");

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

            modelBuilder.Entity<Dim_YearDAO>(entity =>
            {
                entity.ToTable("Dim_Year", "SAP");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.EndAt).HasColumnType("datetime");

                entity.Property(e => e.StartAt).HasColumnType("datetime");
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

                entity.Property(e => e.GTGT_Endate).HasColumnType("datetime");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
