using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Do;

public partial class PhotographyContext : DbContext
{
    public PhotographyContext()
    {
    }

    public PhotographyContext(DbContextOptions<PhotographyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Photographer> Photographers { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\‏‏RabinskyPhotography\\Dal\\DB\\RabinskyPhotographyDB.mdf\";Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__customer__3214EC079FE9B62D");

            entity.ToTable("customers");

            entity.Property(e => e.ChatanName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Hall)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.KalaName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.Photographer).WithMany(p => p.Customers)
                .HasForeignKey(d => d.PhotographerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_customers_to_Photographers");
        });

        modelBuilder.Entity<Photographer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Photogra__3214EC07FA8ABDBA");

            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.PriceCodeNavigation).WithMany(p => p.Photographers)
                .HasForeignKey(d => d.PriceCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Photographers_to_Prices");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Prices__A25C5AA626F32925");

            entity.Property(e => e.PriceFor320Photos).HasColumnName("Price_for_320_photos");
            entity.Property(e => e.PriceForAnAdditionalHourAfter1Am).HasColumnName("Price_for_an_additional_hour_after_1_am");
            entity.Property(e => e.PriceForAnAdditionalHourBeyond7Hours).HasColumnName("Price_for_an_additional_hour_beyond_7_hours");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
