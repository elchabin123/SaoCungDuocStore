﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaoCungDuocStore.Data;

#nullable disable

namespace SaoCungDuocStore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241105035853_SeedCategoryTable")]
    partial class SeedCategoryTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SaoCungDuocStore.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 1,
                            Name = "Cổ Tích"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 2,
                            Name = "Kinh Dị"
                        },
                        new
                        {
                            CategoryId = 4,
                            DisplayOrder = 3,
                            Name = "Trinh Thám"
                        },
                        new
                        {
                            CategoryId = 5,
                            DisplayOrder = 4,
                            Name = "Anime"
                        },
                        new
                        {
                            CategoryId = 6,
                            DisplayOrder = 5,
                            Name = "Thiếu Nhi"
                        },
                        new
                        {
                            CategoryId = 7,
                            DisplayOrder = 6,
                            Name = "Nấu Ăn"
                        },
                        new
                        {
                            CategoryId = 8,
                            DisplayOrder = 7,
                            Name = "Khoa Học"
                        },
                        new
                        {
                            CategoryId = 9,
                            DisplayOrder = 7,
                            Name = "Tâm Lí"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
