using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SistemaInventario.Modelos.ViewModels.EntidadesDB;
using SistemaInventarioAccesoDatos;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SistemaInventarioAccesoDatos.Data
{
    public partial class DbContextConnect : DbContext
    {
        public DbContextConnect()
        {
        }

        public DbContextConnect(DbContextOptions<DbContextConnect> options)
            : base(options)
        {
        }

        public virtual DbSet<Bodega> Bodega { get; set; }
        public virtual DbSet<BodegaProd> BodegaProd { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=INVENTARIO_DB;User ID=sa;Password=inginf98;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bodega>(entity =>
            {
                entity.HasKey(e => e.IdBodega)
                    .HasName("PK_IDB");

                entity.Property(e => e.DescripcionB).IsUnicode(false);

                entity.Property(e => e.NombreB).IsUnicode(false);
            });

            modelBuilder.Entity<BodegaProd>(entity =>
            {
                entity.HasKey(e => e.IdBp)
                    .HasName("PK_IDBP");

                entity.Property(e => e.IdBp).ValueGeneratedNever();

                entity.Property(e => e.Ubicacion).IsUnicode(false);

                entity.HasOne(d => d.FidBodegaNavigation)
                    .WithMany(p => p.BodegaProd)
                    .HasForeignKey(d => d.FidBodega)
                    .HasConstraintName("FK_IDB");

                entity.HasOne(d => d.FidProdNavigation)
                    .WithMany(p => p.BodegaProd)
                    .HasForeignKey(d => d.FidProd)
                    .HasConstraintName("FK_IDP");
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK_IDC");

                entity.Property(e => e.NombreC).IsUnicode(false);
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(e => e.IdMarca)
                    .HasName("PK_IDM");

                entity.Property(e => e.NombreM).IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProd)
                    .HasName("PK_IDP");

                entity.Property(e => e.DescripcionP).IsUnicode(false);

                entity.Property(e => e.NumSerie).IsUnicode(false);

                entity.HasOne(d => d.FidCategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.FidCategoria)
                    .HasConstraintName("FK_IDC");

                entity.HasOne(d => d.FidMarcaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.FidMarca)
                    .HasConstraintName("FK_IDM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
