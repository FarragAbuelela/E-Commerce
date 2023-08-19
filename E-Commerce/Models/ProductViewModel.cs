using E_Commerce.BL.Models;

namespace E_Commerce.Models
{
    public class ProductViewModel
    {
        public ClothesProduct ClothingProduct { get; set; }
        public BabyAndKidsProduct babyAndKids { get; set; }
        public BeautyProduct BeautyProduct { get; set; }
        public ElectronicsProduct ElectronicsProduct { get; set; }
    }
}
