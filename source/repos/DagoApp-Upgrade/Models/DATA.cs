using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DagoApp_.Models
{
    public partial class DATA : DbContext
    {
        public DATA()
            : base("name=DATA")
        {
        }

        public virtual DbSet<abonoInteres> abonoInteres { get; set; }
        public virtual DbSet<adelantosalario> adelantosalario { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Cobradores> Cobradores { get; set; }
        public virtual DbSet<DetalleVarios> DetalleVarios { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<Pendientes> Pendientes { get; set; }
        public virtual DbSet<Prestamos> Prestamos { get; set; }
        public virtual DbSet<TipoOperacion> TipoOperacion { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<abonoInteres>()
                .Property(e => e.cantidadAbonada)
                .HasPrecision(19, 4);

            modelBuilder.Entity<adelantosalario>()
                .Property(e => e.cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<adelantosalario>()
                .Property(e => e.comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.NOTarjeta)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Pin)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.dni)
                .IsUnicode(false);

            modelBuilder.Entity<Clientes>()
                .Property(e => e.tasainteres)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Cobradores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleVarios>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleVarios>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Pendientes>()
                .Property(e => e.CantidadEsperado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pendientes>()
                .Property(e => e.CantidadRecibido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Pendientes>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Prestamos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Cantidad)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.cantidadesperada)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.diferencia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.clave)
                .IsUnicode(false);
        }
    }
}
