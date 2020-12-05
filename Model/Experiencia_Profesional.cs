namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Experiencia_Profesional
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ExperiencaP_id { get; set; }

        [Column(TypeName = "text")]
        public string Lugar_de_trabajo { get; set; }

        public short? Años_de_actividad { get; set; }

        [StringLength(100)]
        public string Cargo { get; set; }
    }
}
