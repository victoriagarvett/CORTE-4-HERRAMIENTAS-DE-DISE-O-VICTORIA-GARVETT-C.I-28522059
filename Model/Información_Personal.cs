namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Información_Personal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InformaciónP_id { get; set; }

        [StringLength(50)]
        public string Nombre_Apellido { get; set; }

        [StringLength(70)]
        public string Carrera { get; set; }

        [Column(TypeName = "text")]
        public string Descripción { get; set; }
    }
}
