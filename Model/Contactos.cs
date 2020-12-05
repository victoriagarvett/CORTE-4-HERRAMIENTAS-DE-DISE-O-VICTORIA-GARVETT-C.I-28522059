namespace Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contactos

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Contactos_id { get; set; }

        [StringLength(50)]
        public string Contacto_nombre { get; set; }

        [StringLength(60)]
        public string Contacto_descripción { get; set; }

        public Contactos MostrarMiContacto(int Contactos_id)
        {
            var contacto = new Contactos();

            using (var context = new curriculumContext())
            {
               contacto = context.Contactos.Where(x => x.Contactos_id == Contactos_id)
                                           .SingleOrDefault();
            }
            return contacto;
        }
    }
}
