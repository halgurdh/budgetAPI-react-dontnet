﻿// <auto-generated />
using System;
using BudgetApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BudgetApi.Migrations.ExpensesDB
{
    [DbContext(typeof(ExpensesDBContext))]
    [Migration("20220911105435_income")]
    partial class income
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BudgetApi.Data.Expenses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6215),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6256),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6259),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6261),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6263),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 6,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6264),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 7,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6266),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 8,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6268),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 9,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6269),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 10,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6271),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 11,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6273),
                            Name = "testExpense",
                            Value = 0.0
                        },
                        new
                        {
                            Id = 12,
                            Date = new DateTime(2022, 9, 11, 12, 54, 35, 302, DateTimeKind.Local).AddTicks(6275),
                            Name = "testExpense",
                            Value = 0.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
