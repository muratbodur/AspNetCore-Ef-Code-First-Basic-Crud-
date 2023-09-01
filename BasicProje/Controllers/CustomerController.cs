using BasicProje.Entity;
using BasicProje.ProjeContext;
using Microsoft.AspNetCore.Mvc;

namespace BasicProje.Controllers
{
    public class CustomerController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.customers.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer c)
        {
            context.Add(c);   
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DeleteCustomer(int id)
        {
            var value = context.customers.Where(x=> x.Id == id).FirstOrDefault();
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        {
            var value = context.customers.Where(x=>x.Id == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateCustomer(Customer c)
        {
            var value = context.customers.Where(x => x.Id == c.Id).FirstOrDefault();
            value.Name = c.Name;
            value.City = c.City;
            context.SaveChanges();
            return RedirectToAction("Index");

        }


    }
}
