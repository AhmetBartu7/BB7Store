using DataAccess.Concrete.Mapping;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class MyContext : DbContext
    {
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductsImages> ProductsImages { get; set; }
        public DbSet<Categories>Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrdersAddress> OrdersAddress { get; set; }
        public DbSet<TempBaskets> TempBaskets { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriesMap());
            modelBuilder.ApplyConfiguration(new CustomersMap());
            modelBuilder.ApplyConfiguration(new OrderAddressMap());
            modelBuilder.ApplyConfiguration(new OrderDetailsMap());
            modelBuilder.ApplyConfiguration(new OrdersMap());
            modelBuilder.ApplyConfiguration(new ProductsImagesMap());
            modelBuilder.ApplyConfiguration(new ProductsMap());
            modelBuilder.ApplyConfiguration(new TempBasketsMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2RR55EA\SQLEXPRESS;Database=BB7Store;Trusted_Connection=True;");



            
            //DESKTOP - 2RR55EA\
        }
    }
}
