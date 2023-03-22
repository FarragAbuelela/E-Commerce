using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class OrderItem
    {
        public OrderItem()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public int PurchasePrice { get; set; }
        public int Quantity { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
