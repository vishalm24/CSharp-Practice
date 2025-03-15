using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApiPrac.Model;

namespace WebApiPrac.Data;

public partial class InvoiceDbContext : DbContext
{
    public InvoiceDbContext()
    {
    }

    public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblAddress> TblAddresses { get; set; }

    public virtual DbSet<TblAncillary> TblAncillaries { get; set; }

    public virtual DbSet<TblArea> TblAreas { get; set; }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

    public virtual DbSet<TblCustomer> TblCustomers { get; set; }

    public virtual DbSet<TblGenuineCustomer> TblGenuineCustomers { get; set; }

    public virtual DbSet<TblModel> TblModels { get; set; }

    public virtual DbSet<TblProduct> TblProducts { get; set; }

    public virtual DbSet<TblProductBackup> TblProductBackups { get; set; }

    public virtual DbSet<TblProductCustomer> TblProductCustomers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblAddress>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__tblAddre__091C2AFBDB2B92EE");

            entity.ToTable("tblAddress");

            entity.Property(e => e.AddressId).ValueGeneratedNever();
            entity.Property(e => e.Address1).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(100);

            entity.HasOne(d => d.Customer).WithMany(p => p.TblAddresses)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__tblAddres__Custo__48CFD27E");
        });

        modelBuilder.Entity<TblAncillary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tblAncil__3214EC07A519FA4B");

            entity.ToTable("tblAncillary");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AncillaryCost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AncillaryName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblArea>(entity =>
        {
            entity.HasKey(e => e.AreaId).HasName("PK__tblArea__70B82048BA7BB70C");

            entity.ToTable("tblArea");

            entity.Property(e => e.AreaId).ValueGeneratedNever();
            entity.Property(e => e.AreaName).HasMaxLength(100);
            entity.Property(e => e.CountryIdFk).HasColumnName("CountryId_fk");

            entity.HasOne(d => d.CountryIdFkNavigation).WithMany(p => p.TblAreas)
                .HasForeignKey(d => d.CountryIdFk)
                .HasConstraintName("FK__tblArea__Country__398D8EEE");
        });

        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__tblCount__10D1609F1CC01FF9");

            entity.ToTable("tblCountry");

            entity.Property(e => e.CountryId).ValueGeneratedNever();
            entity.Property(e => e.CountryName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblCustomer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__tblCusto__A4AE64D856F1D5D9");

            entity.ToTable("tblCustomer");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.CustomerPhoneNumber).HasMaxLength(15);
            entity.Property(e => e.CustomerReferenceIdFk).HasColumnName("CustomerReferenceId_fk");
            entity.Property(e => e.CustomerSsn)
                .HasMaxLength(11)
                .HasColumnName("CustomerSSN");
        });

        modelBuilder.Entity<TblGenuineCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblGenuineCustomer");

            entity.Property(e => e.CustomerName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblModel>(entity =>
        {
            entity.HasKey(e => e.ModelId).HasName("PK__tblModel__E8D7A12C8DC53E6B");

            entity.ToTable("tblModel");

            entity.Property(e => e.ModelId).ValueGeneratedNever();
            entity.Property(e => e.CountryIdFk).HasColumnName("CountryId_fk");
            entity.Property(e => e.ManufacturerName).HasMaxLength(100);
            entity.Property(e => e.ModelBrand).HasMaxLength(100);
            entity.Property(e => e.ModelName).HasMaxLength(100);

            entity.HasOne(d => d.CountryIdFkNavigation).WithMany(p => p.TblModels)
                .HasForeignKey(d => d.CountryIdFk)
                .HasConstraintName("FK__tblModel__Countr__3E52440B");
        });

        modelBuilder.Entity<TblProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tblProdu__B40CC6CDB144643D");

            entity.ToTable("tblProduct");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductCost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblProductBackup>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tblProdu__B40CC6CD23294279");

            entity.ToTable("tblProductBackup");

            entity.Property(e => e.ProductId).ValueGeneratedNever();
            entity.Property(e => e.ProductCost).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<TblProductCustomer>(entity =>
        {
            entity.HasKey(e => e.ProductCustomerId).HasName("PK__tblProdu__5D863CB9AD20AB41");

            entity.ToTable("tblProductCustomer");

            entity.Property(e => e.ProductCustomerId).ValueGeneratedNever();
            entity.Property(e => e.AncillaryIdFk).HasColumnName("AncillaryId_fk");
            entity.Property(e => e.CustomerIdFk).HasColumnName("CustomerId_fk");
            entity.Property(e => e.ModelIdFk).HasColumnName("ModelId_fk");
            entity.Property(e => e.ProductIdFk).HasColumnName("ProductId_fk");
            entity.Property(e => e.SalesDate).HasColumnType("datetime");

            entity.HasOne(d => d.AncillaryIdFkNavigation).WithMany(p => p.TblProductCustomers)
                .HasForeignKey(d => d.AncillaryIdFk)
                .HasConstraintName("FK__tblProduc__Ancil__4E88ABD4");

            entity.HasOne(d => d.CustomerIdFkNavigation).WithMany(p => p.TblProductCustomers)
                .HasForeignKey(d => d.CustomerIdFk)
                .HasConstraintName("FK__tblProduc__Custo__4BAC3F29");

            entity.HasOne(d => d.ModelIdFkNavigation).WithMany(p => p.TblProductCustomers)
                .HasForeignKey(d => d.ModelIdFk)
                .HasConstraintName("FK__tblProduc__Model__4D94879B");

            entity.HasOne(d => d.ProductIdFkNavigation).WithMany(p => p.TblProductCustomers)
                .HasForeignKey(d => d.ProductIdFk)
                .HasConstraintName("FK__tblProduc__Prouc__4CA06362");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
