using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class BabyAndKidsProduct : Product
    {
        public string AgeRange { get; set; }
        public string Gender { get; set; }
        public string Material { get; set; }
    }
}
