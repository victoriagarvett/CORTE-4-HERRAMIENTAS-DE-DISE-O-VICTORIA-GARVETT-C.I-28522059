namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Habilidades_Conocimientos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Habilidades_id { get; set; }

        [Column(TypeName = "text")]
        public string Descripción_habilidades { get; set; }
    }
}
