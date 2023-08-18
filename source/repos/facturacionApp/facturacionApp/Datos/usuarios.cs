namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(50)]
        public string apellidos { get; set; }

        [StringLength(50)]
        public string correoE { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        public int? inactive { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [StringLength(50)]
        public string clave { get; set; }

        public DateTime? fechaRegistro { get; set; }

        public int? nivelSeguridad { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        [StringLength(100)]
        public string creadoPor { get; set; }

        [StringLength(100)]
        public string modificadoPor { get; set; }
    }
}
