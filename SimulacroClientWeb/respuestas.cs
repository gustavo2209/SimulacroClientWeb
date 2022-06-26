namespace SimulacroClientWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class respuestas
    {
        [Key]
        public int idrespuesta { get; set; }

        public int idpregunta { get; set; }

        [Required]
        public string respuesta { get; set; }

        [Column(TypeName = "numeric")]
        public decimal puntaje { get; set; }

        public virtual preguntas preguntas { get; set; }
    }
}
