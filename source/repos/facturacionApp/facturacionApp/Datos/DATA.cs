using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace facturacionApp.Datos
{
    public partial class DATA : DbContext
    {
        public DATA()
            : base("name=DATA")
        {
        }

        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<cotizaciones> cotizaciones { get; set; }
        public virtual DbSet<cotizacionesDetalle> cotizacionesDetalle { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<facturaDetalle> facturaDetalle { get; set; }
        public virtual DbSet<facturas> facturas { get; set; }
        public virtual DbSet<ordenCompra> ordenCompra { get; set; }
        public virtual DbSet<ordenCompraDetalle> ordenCompraDetalle { get; set; }
        public virtual DbSet<productos> productos { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<usuarios> usuarios { get; set; }
        public virtual DbSet<vauchers> vauchers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<clientes>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.correoE)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.departamento)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.municipio)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.rtn)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.precioSugerido)
                .HasPrecision(19, 4);

            modelBuilder.Entity<clientes>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.nombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.rtn)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.correoE)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizaciones>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.impuestoTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<cotizacionesDetalle>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 4);

            modelBuilder.Entity<empleados>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<empleados>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<empleados>()
                .Property(e => e.identidad)
                .IsUnicode(false);

            modelBuilder.Entity<empleados>()
                .Property(e => e.puesto)
                .IsUnicode(false);

            modelBuilder.Entity<empleados>()
                .Property(e => e.sueldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<empleados>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<empleados>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.codigoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.cantidad)
                .HasPrecision(5, 2);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.impuestoTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturaDetalle>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.numeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.cai)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.rangoAutorizado)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.nombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.rtn)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.metodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.descripcionEstadoPago)
                .IsUnicode(false);

            modelBuilder.Entity<facturas>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<facturas>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.numeroOC)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.nombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.nota)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.numeroReferenciaFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompra>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.codigoProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.descripcionProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.cantidad)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ordenCompraDetalle>()
                .Property(e => e.impuestoTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<productos>()
                .Property(e => e.codigo)
                .IsUnicode(false);

            modelBuilder.Entity<productos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<productos>()
                .Property(e => e.cantidadExistencia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<productos>()
                .Property(e => e.costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<productos>()
                .Property(e => e.impuesto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<productos>()
                .Property(e => e.precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<productos>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.correoE)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.departamento)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.municipio)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.rtn)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.correoE)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.creadoPor)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios>()
                .Property(e => e.modificadoPor)
                .IsUnicode(false);

            modelBuilder.Entity<vauchers>()
                .Property(e => e.horasTrabajadas)
                .HasPrecision(2, 2);

            modelBuilder.Entity<vauchers>()
                .Property(e => e.precioHora)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vauchers>()
                .Property(e => e.horasExtras)
                .HasPrecision(2, 2);

            modelBuilder.Entity<vauchers>()
                .Property(e => e.bonificacion)
                .HasPrecision(19, 4);
        }
    }
}
