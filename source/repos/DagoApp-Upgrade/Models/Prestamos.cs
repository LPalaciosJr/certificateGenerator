namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prestamos
    {
        [Key]
        public int IdPrestamo { get; set; }

        public int? Cantidad { get; set; }

        public int? Tipo { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }

        public float? Tasa { get; set; }

        public DateTime? Desde { get; set; }

        public int? IDCliente { get; set; }

        public int? status { get; set; }
    }
}
