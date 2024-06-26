﻿// <auto-generated />
using System;
using LuftbornCodeTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LuftbornCodeTest.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domains.TodoListTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("Deadline")
                        .HasColumnType("date");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ToDoListTasks", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreationDate = new DateTime(2024, 4, 21, 21, 58, 23, 223, DateTimeKind.Local).AddTicks(5020),
                            Deadline = new DateOnly(2024, 4, 23),
                            Discription = "Finish this ASP.NET Core migration",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreationDate = new DateTime(2024, 4, 21, 21, 58, 23, 223, DateTimeKind.Local).AddTicks(5087),
                            Deadline = new DateOnly(2024, 4, 22),
                            Discription = "Groceries shopping",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreationDate = new DateTime(2024, 4, 21, 21, 58, 23, 223, DateTimeKind.Local).AddTicks(5093),
                            Deadline = new DateOnly(2024, 4, 21),
                            Discription = "Review code for pull request",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreationDate = new DateTime(2024, 4, 21, 21, 58, 23, 223, DateTimeKind.Local).AddTicks(5098),
                            Deadline = new DateOnly(2024, 4, 24),
                            Discription = "Team meeting",
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
