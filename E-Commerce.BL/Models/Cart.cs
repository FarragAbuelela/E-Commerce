using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class Cart
    {
        public Cart()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
