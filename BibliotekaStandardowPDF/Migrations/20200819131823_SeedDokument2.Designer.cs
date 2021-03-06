﻿// <auto-generated />
using BibliotekaStandardowPDF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BibliotekaStandardowPDF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200819131823_SeedDokument2")]
    partial class SeedDokument2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BibliotekaStandardowPDF.Models.Dokument", b =>
                {
                    b.Property<int>("Id_dokumentu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Temat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tresc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_dokumentu");

                    b.ToTable("Dokument");
                });
#pragma warning restore 612, 618
        }
    }
}
