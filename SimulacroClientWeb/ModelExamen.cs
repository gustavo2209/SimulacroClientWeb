using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SimulacroClientWeb
{
    public partial class ModelExamen : DbContext
    {
        public ModelExamen()
            : base("name=ModelExamen")
        {
        }

        public virtual DbSet<examenes> examenes { get; set; }
        public virtual DbSet<preguntas> preguntas { get; set; }
        public virtual DbSet<respuestas> respuestas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<examenes>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<examenes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<examenes>()
                .Property(e => e.minimanota)
                .HasPrecision(12, 2);

            modelBuilder.Entity<examenes>()
                .Property(e => e.activo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<preguntas>()
                .Property(e => e.pregunta)
                .IsUnicode(false);

            modelBuilder.Entity<respuestas>()
                .Property(e => e.respuesta)
                .IsUnicode(false);

            modelBuilder.Entity<respuestas>()
                .Property(e => e.puntaje)
                .HasPrecision(8, 2);
        }
    }
}
