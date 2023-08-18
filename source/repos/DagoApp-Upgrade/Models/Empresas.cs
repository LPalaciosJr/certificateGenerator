namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empresas
    {
        [Key]
        public int IdEmpresa { get; set; }

        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(40)]
        public string Direccion { get; set; }
    }
}
