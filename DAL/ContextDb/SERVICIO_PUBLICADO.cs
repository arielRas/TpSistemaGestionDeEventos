namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVICIO_PUBLICADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SERVICIO_PUBLICADO()
        {
            EVENTO_SERVICIO = new HashSet<EVENTO_SERVICIO>();
        }

        [Key]
        public Guid ID_PUBLICACION { get; set; }

        public int? ID_PROVEEDOR { get; set; }

        public int? ID_SERVICIO { get; set; }

        public decimal PRECIO { get; set; }

        [Required]
        public string DESCRIPCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EVENTO_SERVICIO> EVENTO_SERVICIO { get; set; }

        public virtual SERVICIO SERVICIO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
