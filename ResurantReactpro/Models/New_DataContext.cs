using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResurantReactpro.Models
{
    public class New_DataContext:DbContext

    {
        public New_DataContext(DbContextOptions<New_DataContext> options) : base(options) { }

        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderMasters> OrderMasters { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<FoodItems> FoodItems { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customers>().ToTable("Customers").HasKey(table => new {
                table.CustomerId

            });
            modelBuilder.Entity<OrderMasters>().ToTable("OrderMasters").HasKey(table => new {
                table.OrderMasterId

            });
            modelBuilder.Entity<OrderDetails>().ToTable("OrderDetails").HasKey(table => new {
                table.OrderDetailsId
            });
               modelBuilder.Entity<FoodItems>().ToTable("FoodItems").HasKey(table => new {
                table.FoodItemId
            });



        }
    }
}
