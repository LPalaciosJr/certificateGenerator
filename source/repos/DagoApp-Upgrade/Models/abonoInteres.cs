namespace DagoApp_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abonoInteres
    {
        public int id { get; set; }

        [Column(TypeName = "money")]
        public decimal? cantidadAbonada { get; set; }

        public DateTime? fecha { get; set; }

        public int? idtransaction { get; set; }
    }
}
