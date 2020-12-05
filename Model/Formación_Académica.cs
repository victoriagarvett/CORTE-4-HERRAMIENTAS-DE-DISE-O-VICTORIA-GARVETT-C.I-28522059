namespace Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Formación_Académica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FAcadémica_id { get; set; }

        [StringLength(60)]
        public string Entidad { get; set; }

        public short? Año_entrada { get; set; }

        [StringLength(12)]
        public string Año_salida { get; set; }
    }
}
