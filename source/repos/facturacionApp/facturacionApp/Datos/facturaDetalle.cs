namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("facturaDetalle")]
    public partial class facturaDetalle
    {
        public int id { get; set; }

        [StringLength(100)]
        public string codigoProducto { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        public decimal? cantidad { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuestoTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public int? idFactura { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(1)]
        public string usuario { get; set; }
    }
}
