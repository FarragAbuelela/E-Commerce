using E_Commerce.BL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DL
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=FARRAGABUELELA;Initial Catalog=E-Commerce;Integrated Security=True;TrustServerCertificate=true;");
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasDiscriminator<string>("Discriminator")
                .HasValue<ClothingProduct>("ClothingProduct")
                .HasValue<ElectronicsProduct>("ElectronicsProduct")
                .HasValue<SportsAndOutdoorsProduct>("SportsAndOutdoorsProducts")
                .HasValue<BabyAndKidsProduct>("BabyAndKidsProduct")
                .HasValue<BeautyProduct>("BeautyProduct");
        }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Review> review { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<BabyAndKidsProduct> babyAndKids { get; set; }
        public DbSet<BeautyProduct> beauty { get; set; }
        public DbSet<SportsAndOutdoorsProduct> sportsAndOutdoors { get; set; }
        public DbSet<ClothingProduct> clothing { get; set; }
        public DbSet<ElectronicsProduct> electronics { get; set; }



    }
}
