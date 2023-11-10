namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PAGO")]
    public partial class PAGO
    {
        [Key]
        [Column(Order = 0)]
        public int ID_PAGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_EVENTO { get; set; }

        [Column(TypeName = "date")]
        public DateTime FECHA_PAGO { get; set; }

        public decimal? TOTAL { get; set; }

        public virtual EVENTO EVENTO { get; set; }
    }
}
