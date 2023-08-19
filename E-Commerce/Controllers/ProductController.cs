using E_Commerce.BL;
using E_Commerce.BL.Models;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Add()
        {
            return View();
        }
        public async Task<IActionResult> AddClothes()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddClothes(ClothesProduct product)
        {
            if (ModelState.IsValid)
            {
                Console.Write(product.Name);
            }
            return View();
        }
        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                return Content("model valid farrag");
            }
            return View();
        }


        public IActionResult SelectCategory()
        {
            return View(_unitOfWork.Category.GetAll());
        }
        public ActionResult ClothesProduct()
        {
            return View();

        }
        public ActionResult ElectronicsProduct()
        {
            return View();
        }
        public IActionResult CkeckCategory(int catId)
        {
            var category = _unitOfWork.Category.GetById(catId);
            TempData["CategoryId"] = catId;
            if (category != null && category.Name == "Clothes")
            {
                return RedirectToAction("ClothesProduct");
            }
            
            else return View("Test1");
        }
        public IActionResult SaveProduct(ProductViewModel p)
        {
            if(p.ClothingProduct is not null)
            {
                ClothesProduct cp = p.ClothingProduct;

                cp.CategoryId = (int)TempData["CategoryId"];
                _unitOfWork.Product.Add(cp);
                return View("ClothesProduct");
            }
            else if(p.ElectronicsProduct is not null)
            {
                ClothesProduct cp = p.ClothingProduct;

                cp.CategoryId = (int)TempData["CategoryId"];
                _unitOfWork.Product.Add(cp);
                return View("ClothesProduct");

            }
            
            return View("ClothesProduct");
        }
        public IActionResult AllProduct()
        {
            List<Product>ans = _unitOfWork.Product.GetAll().ToList();
            return View(ans);
        }

    }
}
