using E_Commerce.BL;
using E_Commerce.BL.Interfaces;
using E_Commerce.BL.Models;
using E_Commerce.DL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Address> Address {get; private set;}

        public IBaseRepository<Category> Category { get; private set; }

        public IBaseRepository<Customer> Customer { get; private set; }

        public IBaseRepository<Order> Order { get; private set; }

        public IBaseRepository<OrderItem> OrderItem { get; private set; }

        public IBaseRepository<Product> Product { get; private set; }
        public IBaseRepository<Review> Review { get; private set; }
        public IBaseRepository<BabyAndKidsProduct> BabyAndKids { get; private set; }
        public IBaseRepository<ClothingProduct> Clothing { get; private set; }
        public IBaseRepository<SportsAndOutdoorsProduct> SportAndOutdoors { get; private set; }

        public IBaseRepository<BeautyProduct> Beauty { get; private set; }

        public IBaseRepository<ElectronicsProduct> Electronics { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Address = new BaseRepository<Address>(context);
            Category = new BaseRepository<Category>(context);
            Customer = new BaseRepository<Customer>(context);
            Order = new BaseRepository<Order>(context);
            OrderItem = new BaseRepository<OrderItem>(context);
            Product = new BaseRepository<Product>(context);
            Review = new BaseRepository<Review>(context);
            BabyAndKids = new BaseRepository<BabyAndKidsProduct>(context);
            Beauty = new BaseRepository<BeautyProduct>(context);
            Clothing = new BaseRepository<ClothingProduct>(context);
            Electronics = new BaseRepository<ElectronicsProduct>(context);
            SportAndOutdoors = new BaseRepository<SportsAndOutdoorsProduct>(context);
        }

        public void Dispose()
        {
            Console.WriteLine("test");
        }
    }
}
