using BusinessLayer.Concreate;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


        public IActionResult Index()
        {
            var values = customerManager.GetCustomerListWithJob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            JobManager jobManager = new JobManager(new EfJobDal());
            List<SelectListItem> values = (from x in jobManager.TGetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.JobID.ToString()
                                           }).ToList();

            ViewBag.v = values;

            return View();
        }


        [HttpPost]

        public IActionResult AddCustomer(Customer p)
        {
            CustomerValidation validationRules = new CustomerValidation();
            ValidationResult result = validationRules.Validate(p);

            if (!result.IsValid)
            {
                customerManager.TInsert(p);
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

        public IActionResult DeleteCustomer(int id)
        {
            var value = customerManager.TGetById(id);
            customerManager.TDelete(value);
            return RedirectToAction("Index");
        }



        [HttpGet]

        public IActionResult UpdateCustomer(int id)
        {

            var value = customerManager.TGetById(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateCustomer(Customer p)
        {
            customerManager.TUbdate(p);
            return RedirectToAction("Index");
        }
    }
}
