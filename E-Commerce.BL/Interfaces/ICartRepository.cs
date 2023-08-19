using E_Commerce.BL.Models;

namespace E_Commerce.BL.Interfaces
{
    public interface ICartRepository : IBaseRepository<Cart>
    {
        IEnumerable<Product> AddProductToCart(int CartId, Product product);
        IEnumerable<Product> GetCartProduct(int CartId);
        void DeleteCartProduct(int CartId, int productId);
    }
}
