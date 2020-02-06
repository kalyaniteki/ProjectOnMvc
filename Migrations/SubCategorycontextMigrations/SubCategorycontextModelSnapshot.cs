﻿// <auto-generated />
using MVCProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVCProject.Migrations.SubCategorycontextMigrations
{
    [DbContext(typeof(SubCategorycontext))]
    partial class SubCategorycontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVCProject.Models.SubCategory", b =>
                {
                    b.Property<int>("C_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Subid")
                        .HasColumnType("int");

                    b.Property<string>("Subname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("C_id");

                    b.ToTable("SubCategoriesDb");
                });
#pragma warning restore 612, 618
        }
    }
}
