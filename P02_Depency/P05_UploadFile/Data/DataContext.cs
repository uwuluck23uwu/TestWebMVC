namespace P05_UploadFile.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-M71R1CT\\SQLEXPRESS; Database=TestUpFile66; Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Product> Products { get; set; }
    }
}
