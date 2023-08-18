namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cotizacionesDetalle")]
    public partial class cotizacionesDetalle
    {
        [Key]
        public int idCotizacionDetalle { get; set; }

        public int? idProducto { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [Column(TypeName = "money")]
        public decimal? subtotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuestoTotal { get; set; }

        [Column(TypeName = "money")]
        public decimal? total { get; set; }

        public int? idCotizacion { get; set; }

        public decimal? cantidad { get; set; }

        public DateTime? fechaActualizacion { get; set; }
    }
}
