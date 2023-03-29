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
            ClothingProduct cp = (ClothingProduct)p;

            p.CategoryId = (int)TempData["CategoryId"];
            _unitOfWork.Product.Add(p);
            return View("ClothesProduct");
        }
        public IActionResult AllProduct()
        {
            List<Product>ans = _unitOfWork.Product.GetAll().ToList();
            return View(ans);
        }

    }
}
