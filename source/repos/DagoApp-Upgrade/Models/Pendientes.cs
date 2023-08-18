namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pendientes
    {
        public int Id { get; set; }

        [Column(TypeName = "money")]
        public decimal? CantidadEsperado { get; set; }

        [Column(TypeName = "money")]
        public decimal? CantidadRecibido { get; set; }

        [Column(TypeName = "money")]
        public decimal? Saldo { get; set; }

        public int? IdTransaction { get; set; }
    }
}
