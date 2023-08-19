using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class ClothesProduct : Product
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
    }
}
