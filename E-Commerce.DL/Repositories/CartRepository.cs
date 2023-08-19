using E_Commerce.BL.Interfaces;
using E_Commerce.BL.Models;
using System.Data.SqlTypes;

namespace E_Commerce.DL.Repositories
{
    public class CartRepository : BaseRepository<Cart>, ICartRepository
    {
        private readonly ApplicationDbContext _context;
        public CartRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Product> AddProductToCart(int CartId, Product product)
        {
            var cart = _context.Carts.FirstOrDefault(cart => cart.Id == CartId);
            if (cart is null)
            {  
                throw new SqlNullValueException();
            }
            cart.Products.Add(product);
            _context.SaveChanges();
            return cart.Products;
        }

        public IEnumerable<Product> GetCartProduct(int CartId)
        {
            var cart = _context.Carts.FirstOrDefault(cart => cart.Id == CartId);
            if (cart is null)
            {
                throw new SqlNullValueException("there is no cart has this id");
            }
            return cart.Products;
        }

        public void DeleteCartProduct(int CartId, int productId)
        {
            var cart = _context.Carts.FirstOrDefault(cart => cart.Id == CartId);
            if (cart is null)
            {
                throw new SqlNullValueException("there is no cart has this id");
            }
            var product = cart.Products.FirstOrDefault(product => product.Id == productId);
            if (product is null)
            {
                throw new SqlNullValueException($"there is no product in this cart id {cart.Id} has this id");
            }
            cart.Products.Remove(product);
        }
    }
}
