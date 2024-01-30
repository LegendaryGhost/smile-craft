using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using smile_craft.Models;

namespace smile_craft.Data;

public partial class SmilecraftContext : DbContext
{
    public SmilecraftContext()
    {
    }

    public SmilecraftContext(DbContextOptions<SmilecraftContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<Operation> Operations { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Perform> Performs { get; set; }

    public virtual DbSet<Price> Prices { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Tooth> Teeth { get; set; }

    public virtual DbSet<ToothPriority> ToothPriorities { get; set; }

    public virtual DbSet<ToothStateHistory> ToothStateHistories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.IdCategory).HasName("category_pkey");

            entity.ToTable("category");

            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.Designation)
                .HasMaxLength(50)
                .HasColumnName("designation");
        });

        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasKey(e => e.IdMark).HasName("mark_pkey");

            entity.ToTable("mark");

            entity.HasIndex(e => e.Mark1, "mark_mark_key").IsUnique();

            entity.Property(e => e.IdMark).HasColumnName("id_mark");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .HasColumnName("description");
            entity.Property(e => e.Mark1).HasColumnName("mark");
        });

        modelBuilder.Entity<Operation>(entity =>
        {
            entity.HasKey(e => e.IdOperation).HasName("operation_pkey");

            entity.ToTable("operation");

            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasKey(e => e.IdPatient).HasName("patient_pkey");

            entity.ToTable("patient");

            entity.Property(e => e.IdPatient).HasColumnName("id_patient");
            entity.Property(e => e.Birthday).HasColumnName("birthday");
            entity.Property(e => e.Firstname)
                .HasMaxLength(50)
                .HasColumnName("firstname");
            entity.Property(e => e.Lastname)
                .HasMaxLength(50)
                .HasColumnName("lastname");
        });

        modelBuilder.Entity<Perform>(entity =>
        {
            entity.HasKey(e => e.IdPerform).HasName("perform_pkey");

            entity.ToTable("perform");

            entity.Property(e => e.IdPerform).HasColumnName("id_perform");
            entity.Property(e => e.DateOperation)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnName("date_operation");
            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.IdPatient).HasColumnName("id_patient");
            entity.Property(e => e.IdTooth).HasColumnName("id_tooth");

            entity.HasOne(d => d.IdOperationNavigation).WithMany(p => p.Performs)
                .HasForeignKey(d => d.IdOperation)
                .HasConstraintName("perform_id_operation_fkey");

            entity.HasOne(d => d.IdPatientNavigation).WithMany(p => p.Performs)
                .HasForeignKey(d => d.IdPatient)
                .HasConstraintName("perform_id_patient_fkey");

            entity.HasOne(d => d.IdToothNavigation).WithMany(p => p.Performs)
                .HasForeignKey(d => d.IdTooth)
                .HasConstraintName("perform_id_tooth_fkey");
        });

        modelBuilder.Entity<Price>(entity =>
        {
            entity.HasKey(e => new { e.IdOperation, e.IdCategory }).HasName("price_pkey");

            entity.ToTable("price");

            entity.Property(e => e.IdOperation).HasColumnName("id_operation");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.Price1).HasColumnName("price");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Prices)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("price_id_category_fkey");

            entity.HasOne(d => d.IdOperationNavigation).WithMany(p => p.Prices)
                .HasForeignKey(d => d.IdOperation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("price_id_operation_fkey");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => new { e.IdPatient, e.IdTooth }).HasName("state_pkey");

            entity.ToTable("state");

            entity.Property(e => e.IdPatient).HasColumnName("id_patient");
            entity.Property(e => e.IdTooth).HasColumnName("id_tooth");
            entity.Property(e => e.IdMark).HasColumnName("id_mark");

            entity.HasOne(d => d.IdMarkNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.IdMark)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("state_id_mark_fkey");

            entity.HasOne(d => d.IdPatientNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.IdPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("state_id_patient_fkey");

            entity.HasOne(d => d.IdToothNavigation).WithMany(p => p.States)
                .HasForeignKey(d => d.IdTooth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("state_id_tooth_fkey");
        });

        modelBuilder.Entity<Tooth>(entity =>
        {
            entity.HasKey(e => e.IdTooth).HasName("tooth_pkey");

            entity.ToTable("tooth");

            entity.Property(e => e.IdTooth).HasColumnName("id_tooth");
            entity.Property(e => e.IdCategory).HasColumnName("id_category");
            entity.Property(e => e.Location)
                .HasMaxLength(5)
                .HasColumnName("location");

            entity.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.Teeth)
                .HasForeignKey(d => d.IdCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tooth_id_category_fkey");
        });

        modelBuilder.Entity<ToothPriority>(entity =>
        {
            entity.HasKey(e => e.IdPriority).HasName("tooth_priority_pkey");

            entity.ToTable("tooth_priority");

            entity.Property(e => e.IdPriority).HasColumnName("id_priority");
            entity.Property(e => e.PriorityName)
                .HasMaxLength(255)
                .HasColumnName("priority_name");
        });

        modelBuilder.Entity<ToothStateHistory>(entity =>
        {
            entity.HasKey(e => e.IdHistory).HasName("tooth_state_history_pkey");

            entity.ToTable("tooth_state_history");

            entity.Property(e => e.IdHistory).HasColumnName("id_history");
            entity.Property(e => e.DateHistory)
                .HasDefaultValueSql("now()")
                .HasColumnName("date_history");
            entity.Property(e => e.IdNewMark).HasColumnName("id_new_mark");
            entity.Property(e => e.IdOldMark).HasColumnName("id_old_mark");
            entity.Property(e => e.IdPatient).HasColumnName("id_patient");
            entity.Property(e => e.IdTooth).HasColumnName("id_tooth");

            entity.HasOne(d => d.IdNewMarkNavigation).WithMany(p => p.ToothStateHistoryIdNewMarkNavigations)
                .HasForeignKey(d => d.IdNewMark)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tooth_state_history_id_new_mark_fkey");

            entity.HasOne(d => d.IdOldMarkNavigation).WithMany(p => p.ToothStateHistoryIdOldMarkNavigations)
                .HasForeignKey(d => d.IdOldMark)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tooth_state_history_id_old_mark_fkey");

            entity.HasOne(d => d.IdPatientNavigation).WithMany(p => p.ToothStateHistories)
                .HasForeignKey(d => d.IdPatient)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tooth_state_history_id_patient_fkey");

            entity.HasOne(d => d.IdToothNavigation).WithMany(p => p.ToothStateHistories)
                .HasForeignKey(d => d.IdTooth)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tooth_state_history_id_tooth_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
