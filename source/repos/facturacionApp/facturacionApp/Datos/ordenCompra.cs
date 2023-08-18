namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ordenCompra")]
    public partial class ordenCompra
    {
        public int id { get; set; }

        [StringLength(100)]
        public string numeroOC { get; set; }

        public int? idProveedor { get; set; }

        [StringLength(100)]
        public string nombreProveedor { get; set; }

        [StringLength(100)]
        public string nota { get; set; }

        public DateTime? fechaRegistro { get; set; }

        public DateTime? fechaCierre { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        [StringLength(100)]
        public string numeroReferenciaFactura { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public int? estado { get; set; }

        public DateTime? fechaActualizacion { get; set; }
    }
}
