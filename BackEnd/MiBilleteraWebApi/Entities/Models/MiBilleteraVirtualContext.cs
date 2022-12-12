using System;
using System.Collections.Generic;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MiBilleteraWebApi.Models
{
    public partial class MiBilleteraVirtualContext : DbContext
    {
        public MiBilleteraVirtualContext()
        {
        }

        public MiBilleteraVirtualContext(DbContextOptions<MiBilleteraVirtualContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Provincia> Provincia { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-T03AKJJ; Database=MiBilleteraVirtual; User=sa; Password=1234; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>(entity =>
            {
                entity.HasKey(e => e.IdCuenta)
                    .HasName("PK__Cuenta__BBC6DF320DA72A4F");

                entity.Property(e => e.IdCuenta)
                    .ValueGeneratedNever()
                    .HasColumnName("idCuenta");

                entity.Property(e => e.Cvu)
                    .IsUnicode(false)
                    .HasColumnName("CVU");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cuenta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__Cuenta__idUsuari__1DE57479");
            });

            modelBuilder.Entity<Localidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PK__Localida__548E364ECEE697A3");

                entity.ToTable("Localidad");

                entity.Property(e => e.IdLocalidad)
                    .ValueGeneratedNever()
                    .HasColumnName("idLocalidad");

                entity.Property(e => e.Domicilio).IsUnicode(false);

                entity.Property(e => e.IdProvincia).HasColumnName("idProvincia");

                entity.Property(e => e.NombreLocalidad)
                    .IsUnicode(false)
                    .HasColumnName("NombreLocalidad");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Localidad)
                    .HasForeignKey(d => d.IdProvincia)
                    .HasConstraintName("FK__Localidad__idPro__1B0907CE");
            });

            modelBuilder.Entity<Moneda>(entity =>
            {
                entity.HasKey(e => e.IdMoneda)
                    .HasName("PK__Moneda__E14012F4179EEF23");

                entity.Property(e => e.IdMoneda)
                    .ValueGeneratedNever()
                    .HasColumnName("idMoneda");

                entity.Property(e => e.idUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Moneda)
                    .HasForeignKey(d => d.idUsuario)
                    .HasConstraintName("FK__Moneda__idUsuari__1ED998B2");
            });

            modelBuilder.Entity<Operacion>(entity =>
            {
                entity.HasKey(e => e.IdOperacion)
                    .HasName("PK__Operacio__E7EB69881FC3A349");

                entity.ToTable("Operacion");

                entity.Property(e => e.IdOperacion)
                    .ValueGeneratedNever()
                    .HasColumnName("idOperacion");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.IdCuenta).HasColumnName("idCuenta");

                entity.HasOne(d => d.IdCuentaNavigation)
                    .WithMany(p => p.Operacion)
                    .HasForeignKey(d => d.IdCuenta)
                    .HasConstraintName("FK__Operacion__idCue__1CF15040");
            });

            modelBuilder.Entity<Provincia>(entity =>
            {
                entity.HasKey(e => e.Idprovincia)
                    .HasName("PK__Provinci__1AF96EE8D169DBE1");

                entity.Property(e => e.Idprovincia)
                    .ValueGeneratedNever()
                    .HasColumnName("idprovincia");

                entity.Property(e => e.NombreProvincia)
                    .IsUnicode(false)
                    .HasColumnName("NombreProvincia");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__645723A66B22906A");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario)
                    .ValueGeneratedNever()
                    .HasColumnName("idUsuario");

                entity.Property(e => e.Apellido).IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Cuil).HasColumnName("cuil");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.Nombre).IsUnicode(false);

                entity.Property(e => e.NombreUsuario).IsUnicode(false);

                entity.HasOne(d => d.IdLocalidadNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdLocalidad)
                    .HasConstraintName("FK__Usuario__idLocal__1BFD2C07");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
