namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DetalleVarios
    {
        public int Id { get; set; }

        public int? idCliente { get; set; }

        [Required]
        [StringLength(40)]
        public string Cliente { get; set; }

        public int? Pin { get; set; }

        [Required]
        [StringLength(40)]
        public string Empresa { get; set; }

        public int? Cobrador { get; set; }

        public DateTime? Desde { get; set; }

        public DateTime? Hasta { get; set; }

        public double? ADS { get; set; }

        public double? InteresMora { get; set; }

        public double? MontoEsperado { get; set; }

        public double? Entregado { get; set; }

        public double? Saldo { get; set; }
    }
}
