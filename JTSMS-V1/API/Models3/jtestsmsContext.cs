using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models3
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

        public virtual DbSet<Requestdetail> Requestdetail { get; set; }

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
            modelBuilder.Entity<Requestdetail>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PRIMARY");

                entity.ToTable("requestdetail");

                entity.HasIndex(e => e.Filehash)
                    .HasName("file_hash_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ReqId)
                    .HasName("reqId_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.ReqNumber)
                    .HasName("reqNumber_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.Scriptid)
                    .HasName("script_id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.ReqId)
                    .HasColumnName("reqId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AssemblyNumber)
                    .HasColumnName("assemblyNumber")
                    .HasMaxLength(45);

                entity.Property(e => e.AssemblyRevision)
                    .HasColumnName("assemblyRevision")
                    .HasMaxLength(45);

                entity.Property(e => e.ChangeDetail)
                    .HasColumnName("changeDetail")
                    .HasMaxLength(45);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(10);

                entity.Property(e => e.CreatedEmail)
                    .HasColumnName("createdEmail")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedName)
                    .HasColumnName("createdName")
                    .HasMaxLength(100);

                entity.Property(e => e.CustId)
                    .HasColumnName("custId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255);

                entity.Property(e => e.EncriptedFileName)
                    .HasColumnName("encriptedFileName")
                    .HasMaxLength(255);

                entity.Property(e => e.Filehash)
                    .HasColumnName("filehash")
                    .HasMaxLength(255);

                entity.Property(e => e.Firmware)
                    .HasColumnName("firmware")
                    .HasMaxLength(255);

                entity.Property(e => e.FirmwareRevision)
                    .HasColumnName("firmwareRevision")
                    .HasMaxLength(255);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.PcnorDevNumber)
                    .HasColumnName("PCNorDevNumber")
                    .HasMaxLength(45);

                entity.Property(e => e.PlatformId)
                    .HasColumnName("platformId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ReqNumber)
                    .HasColumnName("reqNumber")
                    .HasMaxLength(45);

                entity.Property(e => e.RouteStepId)
                    .HasColumnName("routeStepId")
                    .HasMaxLength(45);

                entity.Property(e => e.ScriptFileName)
                    .HasColumnName("scriptFileName")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptid)
                    .HasColumnName("scriptid")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptname)
                    .HasColumnName("scriptname")
                    .HasMaxLength(255);

                entity.Property(e => e.Scriptrev)
                    .HasColumnName("scriptrev")
                    .HasMaxLength(45);

                entity.Property(e => e.StationId)
                    .HasColumnName("stationId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeId)
                    .HasColumnName("typeId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedEmail)
                    .HasColumnName("updatedEmail")
                    .HasMaxLength(45);

                entity.Property(e => e.UpdatedName)
                    .HasColumnName("updatedName")
                    .HasMaxLength(45);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
