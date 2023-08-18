namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Clientes
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string NOTarjeta { get; set; }

        public DateTime? FechaVencimientoTarjeta { get; set; }

        [Required]
        [StringLength(40)]
        public string Pin { get; set; }

        [Required]
        [StringLength(40)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(40)]
        public string CorreoElectronico { get; set; }

        public int? IdEmpresa { get; set; }

        public int? IdCobrador { get; set; }

        public int? TipoCliente { get; set; }

        [StringLength(40)]
        public string dni { get; set; }

        [Column(TypeName = "money")]
        public decimal? tasainteres { get; set; }

        public int? estado { get; set; }
    }
}
