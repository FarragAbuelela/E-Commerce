using E_Commerce.BL.Interfaces;
using E_Commerce.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Address> Address { get; }
        IBaseRepository<Category> Category { get; }
        IBaseRepository<Customer> Customer { get; }
        IBaseRepository<Order> Order { get; }
        IBaseRepository<OrderItem> OrderItem { get; }
        IBaseRepository<Product> Product { get; }
    }
}
