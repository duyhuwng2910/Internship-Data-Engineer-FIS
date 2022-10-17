using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DW_Test.Models
{
    public partial class DataContext : DbContext
    {
        public virtual DbSet<Dim_DateDAO> Dim_Date { get; set; }
        public virtual DbSet<Dim_DateMappingDAO> Dim_DateMapping { get; set; }
        public virtual DbSet<Dim_MonthDAO> Dim_Month { get; set; }
        public virtual DbSet<Dim_QuarterDAO> Dim_Quarter { get; set; }
        public virtual DbSet<Dim_YearDAO> Dim_Year { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }
        public virtual DbSet<Raw_Customer_RepDAO> Raw_Customer_Rep { get; set; }
        public virtual DbSet<Raw_Item_RepDAO> Raw_Item_Rep { get; set; }
        public virtual DbSet<Raw_Plan_RevenueDAO> Raw_Plan_Revenue { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
