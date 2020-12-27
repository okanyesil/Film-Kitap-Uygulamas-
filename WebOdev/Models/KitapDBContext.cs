using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebOdev.Models
{
    public partial class KitapDBContext : DbContext
    {
        public KitapDBContext()
        {
        }

        public KitapDBContext(DbContextOptions<KitapDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Kategori> Kategoris { get; set; }
        public virtual DbSet<Kitap> Kitaps { get; set; }
        public virtual DbSet<Yazar> Yazars { get; set; }
        public virtual DbSet<Yorum> Yorums { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Kategori>(entity =>
            {
                entity.ToTable("Kategori");

                entity.Property(e => e.KategoriId).HasColumnName("kategoriID");

                entity.Property(e => e.KategoriAdi)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("kategoriAdi");
            });

            modelBuilder.Entity<Kitap>(entity =>
            {
                entity.ToTable("Kitap");

                entity.Property(e => e.KitapId).HasColumnName("kitapID");

                entity.Property(e => e.KategoryId).HasColumnName("kategoryID");

                entity.Property(e => e.KitapAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("kitapAdi");

                entity.Property(e => e.Puan).HasColumnName("puan");

                entity.Property(e => e.YazarId).HasColumnName("yazarID");

                entity.Property(e => e.YorumId).HasColumnName("yorumID");

                entity.HasOne(d => d.Kategory)
                    .WithMany(p => p.Kitaps)
                    .HasForeignKey(d => d.KategoryId)
                    .HasConstraintName("FK_Kitap_Kategori");

                entity.HasOne(d => d.Yazar)
                    .WithMany(p => p.Kitaps)
                    .HasForeignKey(d => d.YazarId)
                    .HasConstraintName("FK_Kitap_Yazar");

                entity.HasOne(d => d.Yorum)
                    .WithMany(p => p.Kitaps)
                    .HasForeignKey(d => d.YorumId)
                    .HasConstraintName("FK_Kitap_Yorum");
            });

            modelBuilder.Entity<Yazar>(entity =>
            {
                entity.ToTable("Yazar");

                entity.Property(e => e.YazarId).HasColumnName("yazarID");

                entity.Property(e => e.YazarAdi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("yazarAdi");

                entity.Property(e => e.YazarSoyadi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("yazarSoyadi");
            });

            modelBuilder.Entity<Yorum>(entity =>
            {
                entity.ToTable("Yorum");

                entity.Property(e => e.YorumId).HasColumnName("yorumID");

                entity.Property(e => e.Yorum1)
                    .IsUnicode(false)
                    .HasColumnName("yorum");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
