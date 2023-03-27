using DEMO_UNITOFWORK.Models;
using DEMO_UNITOFWORK.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DEMO_UNITOFWORK.Controllers
{
    public class ProductController : Controller
    {
        private IUnitOfWork unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var ListProduct = unitOfWork.Products.GetProducts();
            return View(ListProduct);
        }
        [HttpGet]
        public IActionResult Create()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    unitOfWork.Products.AddProduct(product);
                    unitOfWork.SaveChange();
                    return RedirectToAction("Index");   
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
           
            return View();
        }
    }
}
