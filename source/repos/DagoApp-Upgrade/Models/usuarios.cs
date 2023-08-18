namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string apellido { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        public int? nivelseguridad { get; set; }

        [StringLength(255)]
        public string clave { get; set; }
    }
}
