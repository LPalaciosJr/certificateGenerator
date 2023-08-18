namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoOperacion")]
    public partial class TipoOperacion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string Descripcion { get; set; }
    }
}
