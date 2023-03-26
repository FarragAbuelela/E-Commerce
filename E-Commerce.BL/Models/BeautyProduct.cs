using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.BL.Models
{
    public class BeautyProduct : Product
    {
        public string Brand { get; set; }
        public string SkinType { get; set; }
        public int VolumeInMilliliters { get; set; }
    }
}
