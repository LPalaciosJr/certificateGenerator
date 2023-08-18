namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empleados
    {
        [Key]
        public int idempleado { get; set; }

        [Required]
        [StringLength(100)]
        public string nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string apellidos { get; set; }

        [Required]
        [StringLength(100)]
        public string identidad { get; set; }

        public DateTime? fechanac { get; set; }

        public DateTime? fechaIngreso { get; set; }

        [StringLength(100)]
        public string puesto { get; set; }

        [Column(TypeName = "money")]
        public decimal? sueldo { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        public int? inactive { get; set; }
    }
}
