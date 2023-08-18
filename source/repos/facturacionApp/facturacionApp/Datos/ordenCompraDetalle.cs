namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordenCompraDetalle")]
    public partial class ordenCompraDetalle
    {
        public int id { get; set; }

        [StringLength(100)]
        public string codigoProducto { get; set; }

        [StringLength(100)]
        public string descripcionProducto { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        public decimal? cantidad { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public DateTime? fechaRegistro { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuestoTotal { get; set; }

        public int? IdOrdenCompra { get; set; }
    }
}
