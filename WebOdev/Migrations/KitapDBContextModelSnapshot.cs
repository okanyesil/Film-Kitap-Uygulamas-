﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebOdev.Models;

namespace WebOdev.Migrations
{
    [DbContext(typeof(KitapDBContext))]
    partial class KitapDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:Collation", "Turkish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("WebOdev.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("kategoriID")
                        .UseIdentityColumn();

                    b.Property<string>("KategoriAdi")
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)")
                        .HasColumnName("kategoriAdi");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("WebOdev.Models.Kitap", b =>
                {
                    b.Property<int>("KitapId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("kitapID")
                        .UseIdentityColumn();

                    b.Property<int?>("KategoryId")
                        .HasColumnType("int")
                        .HasColumnName("kategoryID");

                    b.Property<string>("KitapAdi")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("kitapAdi");

                    b.Property<short?>("Puan")
                        .HasColumnType("smallint")
                        .HasColumnName("puan");

                    b.Property<string>("ResimUrl")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("resimUrl");

                    b.Property<int?>("YazarId")
                        .HasColumnType("int")
                        .HasColumnName("yazarID");

                    b.Property<int?>("YorumId")
                        .HasColumnType("int")
                        .HasColumnName("yorumID");

                    b.HasKey("KitapId");

                    b.HasIndex("KategoryId");

                    b.HasIndex("YazarId");

                    b.HasIndex("YorumId");

                    b.ToTable("Kitap");
                });

            modelBuilder.Entity("WebOdev.Models.Yazar", b =>
                {
                    b.Property<int>("YazarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("yazarID")
                        .UseIdentityColumn();

                    b.Property<string>("YazarAdi")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("yazarAdi");

                    b.Property<string>("YazarSoyadi")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("yazarSoyadi");

                    b.HasKey("YazarId");

                    b.ToTable("Yazar");
                });

            modelBuilder.Entity("WebOdev.Models.Yorum", b =>
                {
                    b.Property<int>("YorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("yorumID")
                        .UseIdentityColumn();

                    b.Property<string>("Yorum1")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("yorum");

                    b.HasKey("YorumId");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("WebOdev.Models.Kitap", b =>
                {
                    b.HasOne("WebOdev.Models.Kategori", "Kategory")
                        .WithMany("Kitaps")
                        .HasForeignKey("KategoryId")
                        .HasConstraintName("FK_Kitap_Kategori");

                    b.HasOne("WebOdev.Models.Yazar", "Yazar")
                        .WithMany("Kitaps")
                        .HasForeignKey("YazarId")
                        .HasConstraintName("FK_Kitap_Yazar");

                    b.HasOne("WebOdev.Models.Yorum", "Yorum")
                        .WithMany("Kitaps")
                        .HasForeignKey("YorumId")
                        .HasConstraintName("FK_Kitap_Yorum");

                    b.Navigation("Kategory");

                    b.Navigation("Yazar");

                    b.Navigation("Yorum");
                });

            modelBuilder.Entity("WebOdev.Models.Kategori", b =>
                {
                    b.Navigation("Kitaps");
                });

            modelBuilder.Entity("WebOdev.Models.Yazar", b =>
                {
                    b.Navigation("Kitaps");
                });

            modelBuilder.Entity("WebOdev.Models.Yorum", b =>
                {
                    b.Navigation("Kitaps");
                });
#pragma warning restore 612, 618
        }
    }
}
