using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class ElectronicsProduct : Product
    {
        public string ModelNumber { get; set; }
        public string Brand { get; set; }
        public int WarrantyMonths { get; set; }
    }
}
