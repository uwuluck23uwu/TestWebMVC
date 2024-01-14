using Microsoft.EntityFrameworkCore;
using MVC_Homework_1.Models;

namespace MVC_Homework_1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=10.103.0.17,1433;Database=Home_Work_Sumo;Trusted_Connection=false;MultipleActiveResultSets=true;TrustServerCertificate=True; User Id=student; Password=Pass@sql;Encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ComponentProduct>().HasKey(k => new { k.ProductId, k.ComponentId });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ComponentProduct> ComponentProducts { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
    }
}
