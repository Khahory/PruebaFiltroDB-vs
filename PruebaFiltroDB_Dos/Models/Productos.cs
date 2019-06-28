namespace PruebaFiltroDB_Dos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion_producto { get; set; }

        [Required]
        [StringLength(50)]
        public string refe_producto { get; set; }

        public int id_proveedor { get; set; }
    }
}
