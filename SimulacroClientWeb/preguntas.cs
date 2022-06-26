namespace SimulacroClientWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class preguntas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public preguntas()
        {
            respuestas = new HashSet<respuestas>();
        }

        [Key]
        public int idpregunta { get; set; }

        public int idexamen { get; set; }

        [Required]
        public string pregunta { get; set; }

        public int prioridad { get; set; }

        public virtual examenes examenes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<respuestas> respuestas { get; set; }
    }
}
