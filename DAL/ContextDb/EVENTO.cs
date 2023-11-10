namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EVENTO")]
    public partial class EVENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EVENTO()
        {
            EVENTO_SERVICIO = new HashSet<EVENTO_SERVICIO>();
            INVITADO = new HashSet<INVITADO>();
            PAGO1 = new HashSet<PAGO>();
        }

        [Key]
        public int ID_EVENTO { get; set; }

        public int ID_USUARIO { get; set; }

        public DateTime FECHA_HORA { get; set; }

        [StringLength(100)]
        public string LUGAR { get; set; }

        public bool? PAGO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTO_SERVICIO> EVENTO_SERVICIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVITADO> INVITADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PAGO> PAGO1 { get; set; }
    }
}
