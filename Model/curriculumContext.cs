using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    public partial class curriculumContext : DbContext
    {
        public curriculumContext()
            : base("name=curriculumContext")
        {
        }

        public virtual DbSet<Contactos> Contactos { get; set; }
        public virtual DbSet<Experiencia_Profesional> Experiencia_Profesional { get; set; }
        public virtual DbSet<Formación_Académica> Formación_Académica { get; set; }
        public virtual DbSet<Habilidades_Conocimientos> Habilidades_Conocimientos { get; set; }
        public virtual DbSet<Información_Personal> Información_Personal { get; set; }
        public virtual DbSet<Redes_Sociales> Redes_Sociales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contactos>()
                .Property(e => e.Contacto_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contactos>()
                .Property(e => e.Contacto_descripción)
                .IsUnicode(false);

            modelBuilder.Entity<Experiencia_Profesional>()
                .Property(e => e.Lugar_de_trabajo)
                .IsUnicode(false);

            modelBuilder.Entity<Experiencia_Profesional>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Formación_Académica>()
                .Property(e => e.Entidad)
                .IsUnicode(false);

            modelBuilder.Entity<Formación_Académica>()
                .Property(e => e.Año_salida)
                .IsUnicode(false);

            modelBuilder.Entity<Habilidades_Conocimientos>()
                .Property(e => e.Descripción_habilidades)
                .IsUnicode(false);

            modelBuilder.Entity<Información_Personal>()
                .Property(e => e.Nombre_Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Información_Personal>()
                .Property(e => e.Carrera)
                .IsUnicode(false);

            modelBuilder.Entity<Información_Personal>()
                .Property(e => e.Descripción)
                .IsUnicode(false);

            modelBuilder.Entity<Redes_Sociales>()
                .Property(e => e.Redes_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Redes_Sociales>()
                .Property(e => e.Redes_enlace)
                .IsUnicode(false);
        }
    }
}
