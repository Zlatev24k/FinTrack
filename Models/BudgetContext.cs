﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FinTrack.Models;

public partial class BudgetContext : DbContext
{
    public BudgetContext()
    {
    }

    public BudgetContext(DbContextOptions<BudgetContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Balance> Balances { get; set; }

    public virtual DbSet<Expense> Expenses { get; set; }

    public virtual DbSet<Income> Incomes { get; set; }

    public virtual DbSet<TypeOfExpense> TypeOfExpenses { get; set; }

    public virtual DbSet<TypeOfIncome> TypeOfIncomes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=Budget;Integrated Security=True;Encrypt=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Balance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Balance__3214EC07F63DD201");

            entity.ToTable("Balance");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Expense).WithMany(p => p.Balances)
                .HasForeignKey(d => d.ExpenseId)
                .HasConstraintName("FK__Balance__Expense__46E78A0C");

            entity.HasOne(d => d.Income).WithMany(p => p.Balances)
                .HasForeignKey(d => d.IncomeId)
                .HasConstraintName("FK__Balance__IncomeI__45F365D3");
        });

        modelBuilder.Entity<Expense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Expense__3214EC07377308FB");

            entity.ToTable("Expense");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.TypeOfExpenseId).HasColumnName("TypeOfExpenseID");

            entity.HasOne(d => d.TypeOfExpense).WithMany(p => p.Expenses)
                .HasForeignKey(d => d.TypeOfExpenseId)
                .HasConstraintName("FK__Expense__TypeOfE__4316F928");
        });

        modelBuilder.Entity<Income>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Income__3214EC074248F29A");

            entity.ToTable("Income");

            entity.Property(e => e.Amount).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.TypeOfIncomeId).HasColumnName("TypeOfIncomeID");

            entity.HasOne(d => d.TypeOfIncome).WithMany(p => p.Incomes)
                .HasForeignKey(d => d.TypeOfIncomeId)
                .HasConstraintName("FK__Income__TypeOfIn__3F466844");
        });

        modelBuilder.Entity<TypeOfExpense>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeOfEx__3214EC07E44072B0");

            entity.ToTable("TypeOfExpense");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<TypeOfIncome>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeOfIn__3214EC07CBAE16F6");

            entity.ToTable("TypeOfIncome");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}