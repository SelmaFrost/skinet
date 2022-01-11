using System;
using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infrastructure.Data
{
    public class StoreContex : DbContext

    {
        public StoreContex(DbContextOptions<StoreContex> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
