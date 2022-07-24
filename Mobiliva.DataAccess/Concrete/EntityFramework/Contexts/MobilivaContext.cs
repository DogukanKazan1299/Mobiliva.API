using Microsoft.EntityFrameworkCore;
using Mobiliva.DataAccess.Concrete.EntityFramework.Mappings;
using Mobiliva.DataAccess.Configurations;
using Mobiliva.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MobilivaContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new ProductDetailMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}
