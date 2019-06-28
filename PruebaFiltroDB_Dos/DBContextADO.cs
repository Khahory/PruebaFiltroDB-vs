namespace PruebaFiltroDB_Dos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBContextADO : DbContext
    {
        public DBContextADO()
            : base("name=DBContextADO")
        {
        }

        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productos>()
                .Property(e => e.nombre_producto)
                .IsFixedLength();

            modelBuilder.Entity<Productos>()
                .Property(e => e.descripcion_producto)
                .IsFixedLength();

            modelBuilder.Entity<Productos>()
                .Property(e => e.refe_producto)
                .IsFixedLength();

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.nombre_proveedor)
                .IsFixedLength();

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.apellido_proveedor)
                .IsFixedLength();
        }
    }
}
