namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class productos
    {
        public int id { get; set; }

        [StringLength(100)]
        public string codigo { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public decimal? cantidadExistencia { get; set; }

        [Column(TypeName = "money")]
        public decimal? costo { get; set; }

        [Column(TypeName = "money")]
        public decimal? impuesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? precio { get; set; }

        public int? idProveedor { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        public int? inactive { get; set; }
    }
}
