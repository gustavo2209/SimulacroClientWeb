namespace SimulacroClientWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class examenes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public examenes()
        {
            preguntas = new HashSet<preguntas>();
        }

        [Key]
        public int idexamen { get; set; }

        [Required]
        [StringLength(200)]
        public string titulo { get; set; }

        public string descripcion { get; set; }

        public int duracion { get; set; }

        [Column(TypeName = "date")]
        public DateTime publicacion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal minimanota { get; set; }

        [StringLength(1)]
        public string activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<preguntas> preguntas { get; set; }
    }
}
