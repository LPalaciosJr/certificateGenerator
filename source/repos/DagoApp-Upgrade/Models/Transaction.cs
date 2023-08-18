namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [Key]
        public int IdTransaction { get; set; }

        public int? tipoOperacion { get; set; }

        [Column(TypeName = "money")]
        public decimal? Cantidad { get; set; }

        public DateTime? Desde { get; set; }

        public DateTime? Hasta { get; set; }

        public int? IDPrestamo { get; set; }

        [StringLength(20)]
        public string comments { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidadesperada { get; set; }

        [Column(TypeName = "money")]
        public decimal? diferencia { get; set; }

        [StringLength(50)]
        public string estado { get; set; }

        public DateTime? fechamodificacion { get; set; }
    }
}
