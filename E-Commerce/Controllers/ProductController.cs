using E_Commerce.BL;
using E_Commerce.BL.Models;
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
            if (category != null && category.Name == "Clothes")
            {
                return RedirectToAction("ClothesProduct");
            }
            else return View("Test1");
        }
    }
}
