﻿// <auto-generated />
using System;
using BudgetApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetApi.Migrations
{
    [DbContext(typeof(IncomeDBContext))]
    [Migration("20220922165751_category")]
    partial class category
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BudgetApi.Data.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<int>("ExpenseId")
                        .HasColumnType("int");

                    b.Property<int>("ExpensesId")
                        .HasColumnType("int");

                    b.Property<int>("IncomeId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("ExpensesId");

                    b.HasIndex("IncomeId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("BudgetApi.Data.Expenses", b =>
                {
                    b.Property<int>("ExpensesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExpensesId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("ExpensesId");

                    b.ToTable("Expenses");
                });

            modelBuilder.Entity("BudgetApi.Data.Income", b =>
                {
                    b.Property<int>("IncomeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IncomeId"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("IncomeId");

                    b.ToTable("Income");

                    b.HasData(
                        new
                        {
                            IncomeId = 1,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2789),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 2,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2830),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 3,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2832),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 4,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2833),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 5,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2835),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 6,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2836),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 7,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2838),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 8,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2839),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 9,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2841),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 10,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2842),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 11,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2843),
                            Name = "testIncome",
                            Value = 0.0
                        },
                        new
                        {
                            IncomeId = 12,
                            Date = new DateTime(2022, 9, 22, 18, 57, 51, 93, DateTimeKind.Local).AddTicks(2845),
                            Name = "testIncome",
                            Value = 0.0
                        });
                });

            modelBuilder.Entity("BudgetApi.Data.Category", b =>
                {
                    b.HasOne("BudgetApi.Data.Expenses", "Expenses")
                        .WithMany("Categories")
                        .HasForeignKey("ExpensesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BudgetApi.Data.Income", "Income")
                        .WithMany("Categories")
                        .HasForeignKey("IncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Expenses");

                    b.Navigation("Income");
                });

            modelBuilder.Entity("BudgetApi.Data.Expenses", b =>
                {
                    b.Navigation("Categories");
                });

            modelBuilder.Entity("BudgetApi.Data.Income", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
