namespace DollarComputers.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ProductsModel : DbContext
    {
        public ProductsModel()
            : base("name=ProductsModelConnection")
        {
        }

        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
