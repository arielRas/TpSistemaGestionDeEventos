namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SERVICIO")]
    public partial class SERVICIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO()
        {
            SERVICIO_PUBLICADO = new HashSet<SERVICIO_PUBLICADO>();
        }

        [Key]
        public int ID_SERVICIO { get; set; }

        [Column("SERVICIO")]
        [StringLength(30)]
        public string SERVICIO1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SERVICIO_PUBLICADO> SERVICIO_PUBLICADO { get; set; }
    }
}
