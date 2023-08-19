using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
            Reviews = new HashSet<Review>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
        public bool hasDiscount { get; set; }
        public string Discriminator { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
