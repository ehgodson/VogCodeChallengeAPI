﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VogCodeChallenge.API;

namespace VogCodeChallenge.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("VogCodeChallenge.API.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Sales"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Marketing"
                        });
                });

            modelBuilder.Entity("VogCodeChallenge.API.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "2267 Water Street, Kitchener, ON N2H 5A5",
                            DepartmentId = 1,
                            FirstName = "Arthur",
                            JobTitle = "Sales Manager",
                            LastName = "Parker"
                        },
                        new
                        {
                            Id = 2,
                            Address = "1884 Jasper Ave, Edmonton, AB T5J 3N6",
                            DepartmentId = 2,
                            FirstName = "Steve",
                            JobTitle = "Administrative assistant",
                            LastName = "Padilla"
                        },
                        new
                        {
                            Id = 3,
                            Address = "",
                            DepartmentId = 1,
                            FirstName = "Joe",
                            JobTitle = "Associate manager",
                            LastName = "Lukens"
                        },
                        new
                        {
                            Id = 4,
                            Address = "154 Carling Avenue, Ottawa, ON K1Z 7B5",
                            DepartmentId = 2,
                            FirstName = "Richard",
                            JobTitle = "Project Coordinator",
                            LastName = "McCormick"
                        });
                });

            modelBuilder.Entity("VogCodeChallenge.API.Employee", b =>
                {
                    b.HasOne("VogCodeChallenge.API.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK_Employees_Departments")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
