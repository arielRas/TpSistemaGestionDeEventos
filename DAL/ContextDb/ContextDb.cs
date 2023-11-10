using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public partial class ContextDb : DbContext
    {
        public ContextDb()
            : base("name=ContextDb")
        {
        }

        public virtual DbSet<EVENTO> EVENTO { get; set; }
        public virtual DbSet<EVENTO_SERVICIO> EVENTO_SERVICIO { get; set; }
        public virtual DbSet<INVITADO> INVITADO { get; set; }
        public virtual DbSet<PAGO> PAGO { get; set; }
        public virtual DbSet<SERVICIO> SERVICIO { get; set; }
        public virtual DbSet<SERVICIO_PUBLICADO> SERVICIO_PUBLICADO { get; set; }
        public virtual DbSet<TIPO_USUARIO> TIPO_USUARIO { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EVENTO>()
                .Property(e => e.LUGAR)
                .IsUnicode(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.EVENTO_SERVICIO)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVENTO>()
                .HasMany(e => e.INVITADO)
                .WithRequired(e => e.EVENTO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EVENTO_SERVICIO>()
                .Property(e => e.SUBTOTAL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<INVITADO>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<PAGO>()
                .Property(e => e.TOTAL)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SERVICIO>()
                .Property(e => e.SERVICIO1)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PUBLICADO>()
                .Property(e => e.PRECIO)
                .HasPrecision(10, 2);

            modelBuilder.Entity<SERVICIO_PUBLICADO>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<SERVICIO_PUBLICADO>()
                .HasMany(e => e.EVENTO_SERVICIO)
                .WithRequired(e => e.SERVICIO_PUBLICADO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_USUARIO>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.TIPO_USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.APELLIDO)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.PASSWORD)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.EVENTO)
                .WithRequired(e => e.USUARIO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.SERVICIO_PUBLICADO)
                .WithOptional(e => e.USUARIO)
                .HasForeignKey(e => e.ID_PROVEEDOR);
        }
    }
}
