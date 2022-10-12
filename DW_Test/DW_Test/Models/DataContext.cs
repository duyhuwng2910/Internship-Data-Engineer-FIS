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
        public virtual DbSet<Dim_WeekDAO> Dim_Week { get; set; }
        public virtual DbSet<Dim_YearDAO> Dim_Year { get; set; }
        public virtual DbSet<Raw_B1_5_ActualExportReport_RepDAO> Raw_B1_5_ActualExportReport_Rep { get; set; }

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
