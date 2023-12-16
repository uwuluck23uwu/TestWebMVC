﻿using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace P04_RelationDB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\sqlexpress; Database=TestProductSumo4; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ComponentProduct>().HasKey(k => new {k.ProductId, k.ComponentId});
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<ComponentProduct> ComponentProducts { get; set; }
        public DbSet<ProductDetail> ProductDetail {  get; set; }
    }
}