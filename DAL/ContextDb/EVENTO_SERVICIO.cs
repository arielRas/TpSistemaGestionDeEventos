namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVENTO_SERVICIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_EVENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid ID_PUBLICACION { get; set; }

        public int? ID_SERVICIO { get; set; }

        public int? ID_PROVEEDOR { get; set; }

        public decimal SUBTOTAL { get; set; }

        public virtual EVENTO EVENTO { get; set; }

        public virtual SERVICIO_PUBLICADO SERVICIO_PUBLICADO { get; set; }
    }
}
