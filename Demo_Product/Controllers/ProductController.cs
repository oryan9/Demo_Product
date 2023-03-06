using BusinessLayer.Concreate;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        
        public IActionResult Index()
        {
            var values = productManager.TGetAll();
            return View(values);
        }



        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }



        [HttpPost]
        public IActionResult AddProduct(Product p)
        {




            ProductValidation validationRules = new ProductValidation();
            ValidationResult result = validationRules.Validate(p);
            if (! result.IsValid)
            {
                productManager.TInsert(p);
                return RedirectToAction("Index");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteProduct(int id)
        {
            var value = productManager.TGetById(id);
            productManager.TDelete(value);
            return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var value = productManager.TGetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product p)
        {

            productManager.TUbdate(p);
            return RedirectToAction("Index");
        }


    }
}
