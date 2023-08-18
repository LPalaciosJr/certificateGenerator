namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("adelantosalario")]
    public partial class adelantosalario
    {
        [Key]
        public int IdAds { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidad { get; set; }

        public DateTime? fechai { get; set; }

        public DateTime? fechaf { get; set; }

        [Required]
        [StringLength(40)]
        public string comentario { get; set; }

        public int? IdPrestamo { get; set; }

        public bool? estado { get; set; }
    }
}
