namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vauchers
    {
        [Key]
        public int idvaucher { get; set; }

        public DateTime? fechaRegistro { get; set; }

        public DateTime? fechaDesde { get; set; }

        public DateTime? fechaHasta { get; set; }

        public decimal? horasTrabajadas { get; set; }

        [Column(TypeName = "money")]
        public decimal? precioHora { get; set; }

        public decimal? horasExtras { get; set; }

        [Column(TypeName = "money")]
        public decimal? bonificacion { get; set; }

        public int? idEmpleado { get; set; }
    }
}
