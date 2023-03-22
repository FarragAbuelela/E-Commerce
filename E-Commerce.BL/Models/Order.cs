using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class Order
    {
        public Order()
        {
            Items = new HashSet<OrderItem>();
        }
        public int Id { get; set; }
        public bool Approved { get; set; }
        public DateTime OrderDate { get; set; }
        public int ShippingAddressId { get; set; }
        public int CustomerId { get; set; }
        public Address ShippingAddress { get; set; }
        public Customer Customer { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; }
    }
}
