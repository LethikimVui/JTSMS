using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models2
{
    public partial class jtestsmsContext : DbContext
    {
        public jtestsmsContext()
        {
        }

        public jtestsmsContext(DbContextOptions<jtestsmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Watchdogconfig> Watchdogconfig { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Data Source=vnhcmm0teapp03;Initial Catalog=jtestsms;User Id=hcm_vui_usr;Password=hcm_vui_usr;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Watchdogconfig>(entity =>
            {
                entity.HasKey(e => e.WdconfigId)
                    .HasName("PRIMARY");

                entity.ToTable("watchdogconfig");

                entity.Property(e => e.WdconfigId)
                    .HasColumnName("wdconfigId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssyNumber)
                    .HasColumnName("assyNumber")
                    .HasMaxLength(45);

                entity.Property(e => e.AssyRev)
                    .HasColumnName("assyRev")
                    .HasMaxLength(45);

                entity.Property(e => e.CustId)
                    .HasColumnName("custId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipmentId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EquipmentName)
                    .HasColumnName("equipmentName")
                    .HasMaxLength(45);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsDmz)
                    .HasColumnName("isDMZ")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IsWatchDogTrigger)
                    .HasColumnName("isWatchDogTrigger")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PlatFormId)
                    .HasColumnName("platFormId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ProcessStep)
                    .HasColumnName("processStep")
                    .HasMaxLength(45);

                entity.Property(e => e.RouteStep)
                    .HasColumnName("routeStep")
                    .HasMaxLength(45);

                entity.Property(e => e.TestTime)
                    .HasColumnName("testTime")
                    .HasColumnType("int(8)");

                entity.Property(e => e.TesterName)
                    .HasColumnName("testerName")
                    .HasMaxLength(45);

                entity.Property(e => e.TesterPcname)
                    .HasColumnName("testerPCName")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
