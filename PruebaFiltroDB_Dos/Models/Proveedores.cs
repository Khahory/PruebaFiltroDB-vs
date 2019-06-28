namespace PruebaFiltroDB_Dos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_proveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_proveedor { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_proveedor { get; set; }
    }
}
