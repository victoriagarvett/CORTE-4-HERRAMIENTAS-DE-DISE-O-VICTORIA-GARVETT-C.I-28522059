namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Redes_Sociales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Redes_id { get; set; }

        [StringLength(30)]
        public string Redes_nombre { get; set; }

        [Column(TypeName = "text")]
        public string Redes_enlace { get; set; }
    }
}
