namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cotizaciones
    {
        [Key]
        public int idCotizacion { get; set; }

        public int? idCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string nombreCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(100)]
        public string rtn { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string correoE { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        public int? estado { get; set; }
    }
}
