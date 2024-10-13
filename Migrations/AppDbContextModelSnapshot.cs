﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST10355869_PROG6212_Part2.Data;

#nullable disable

namespace ST10355869_PROG6212_Part2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ST10355869_PROG6212_Part2.Models.Lecturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalNotes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("DocumentContent")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("DocumentContentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HourlyRate")
                        .HasColumnType("float");

                    b.Property<double>("HoursWorked")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Lecturers");
                });
#pragma warning restore 612, 618
        }
    }
}
