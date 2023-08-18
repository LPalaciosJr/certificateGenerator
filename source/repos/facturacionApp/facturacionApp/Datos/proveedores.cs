namespace facturacionApp.Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class proveedores
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(100)]
        public string telefono { get; set; }

        [StringLength(100)]
        public string correoE { get; set; }

        [StringLength(100)]
        public string departamento { get; set; }

        [StringLength(100)]
        public string municipio { get; set; }

        [StringLength(100)]
        public string contacto { get; set; }

        [StringLength(100)]
        public string rtn { get; set; }

        [StringLength(100)]
        public string usuario { get; set; }

        public DateTime? fechaCreacion { get; set; }

        public DateTime? fechaActualizacion { get; set; }

        public int? inactive { get; set; }
    }
}
