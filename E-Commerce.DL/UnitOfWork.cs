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

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Address = new BaseRepository<Address>(context);
            Category = new BaseRepository<Category>(context);
            Customer = new BaseRepository<Customer>(context);
            Order = new BaseRepository<Order>(context);
            OrderItem = new BaseRepository<OrderItem>(context);
            Product = new BaseRepository<Product>(context);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
