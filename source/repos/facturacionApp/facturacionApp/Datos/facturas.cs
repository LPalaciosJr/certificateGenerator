namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class facturas
    {
        public int id { get; set; }

        [StringLength(100)]
        public string numeroFactura { get; set; }

        [StringLength(100)]
        public string cai { get; set; }

        [StringLength(100)]
        public string rangoAutorizado { get; set; }

        public int? codigoCliente { get; set; }

        [StringLength(100)]
        public string nombreCliente { get; set; }

        [StringLength(100)]
        public string rtn { get; set; }

        public DateTime? fechaLimite { get; set; }

        public DateTime? fechaEmision { get; set; }

        public DateTime? fechaVencimiento { get; set; }

        public DateTime? fechaVenta { get; set; }

        [StringLength(100)]
        public string metodoPago { get; set; }

        public int? estadoPago { get; set; }

        [StringLength(100)]
        public string descripcionEstadoPago { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        public int? estado { get; set; }
    }
}
