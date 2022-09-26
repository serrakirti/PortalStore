using Microsoft.EntityFrameworkCore;
using PortalStore.CoreLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalStore.DataAccessLayer
{
    public class PortalDbContext : DbContext
    {
        public PortalDbContext(DbContextOptions<PortalDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Adress>().HasOne(a => a.Customer).WithMany(a => a.Adresses)
                .HasForeignKey(e => e.CustomerId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>().HasOne(a => a.Adress).WithMany(a => a.Orders)
               .HasForeignKey(e => e.AdressId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>().HasOne(a => a.Customer).WithMany(a => a.Orders)
               .HasForeignKey(e => e.CustomerId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>().HasOne(a => a.Order).WithMany(a => a.OrderItems)
               .HasForeignKey(e => e.OrderId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<OrderItem>().HasOne(a => a.Product).WithMany(a => a.OrderItems)
               .HasForeignKey(e => e.ProductId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Product>().HasOne(a => a.Category).WithMany(a => a.Products)
               .HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.NoAction);

        }

    }
}
