﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project_ef;

#nullable disable

namespace project_ef.Migrations
{
    [DbContext(typeof(TareasContext))]
    [Migration("20240828003817_SeedersTasksAndCategories")]
    partial class SeedersTasksAndCategories
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("project_ef.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Categories' description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Categories' name");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                            CreationAt = new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9981),
                            Description = "Descripcion 001",
                            Name = "Category 001",
                            UpdateAt = new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9981)
                        },
                        new
                        {
                            CategoryId = new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                            CreationAt = new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9990),
                            Description = "Descripcion 002",
                            Name = "Category 001",
                            UpdateAt = new DateTime(2024, 8, 28, 0, 38, 16, 982, DateTimeKind.Utc).AddTicks(9991)
                        });
                });

            modelBuilder.Entity("project_ef.Models.Task", b =>
                {
                    b.Property<Guid>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("task description");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasComment("Task title");

                    b.Property<DateTime>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("TaskId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Task", (string)null);

                    b.HasData(
                        new
                        {
                            TaskId = new Guid("0003ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                            CategoryId = new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c65c"),
                            CreationAt = new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1662),
                            Description = "Tarea 001",
                            PrioridadTarea = 2,
                            Titulo = "Titulo 001",
                            UpdateAt = new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1663)
                        },
                        new
                        {
                            TaskId = new Guid("1003ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                            CategoryId = new Guid("2103ffd7-67e4-48b2-b7c6-f5fcaf14c601"),
                            CreationAt = new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1668),
                            Description = "Tarea 002",
                            PrioridadTarea = 2,
                            Titulo = "Titulo 002",
                            UpdateAt = new DateTime(2024, 8, 28, 0, 38, 16, 983, DateTimeKind.Utc).AddTicks(1669)
                        });
                });

            modelBuilder.Entity("project_ef.Models.Task", b =>
                {
                    b.HasOne("project_ef.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("project_ef.Models.Category", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
