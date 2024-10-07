using BootCamp.Services;
using Bootcamp2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace BootCamp2024.Controllers
{
    public class CustomerController : Controller
    {
        public CustomerController()
        {

        }

        public IActionResult Index()
        {
            CustomerService customerService = new CustomerService();

            List<Customer> customers = customerService.GetCustomers();

            return View(customers);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            CustomerService service = new CustomerService();
            service.AddCustomers(customer);
            return RedirectToAction("index");
        }


        public IActionResult Detail(int id)
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            CustomerService service = new CustomerService();
            Customer customer = service.GetCustomer(id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            CustomerService service = new CustomerService();
            service.EditCustomers(customer);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            CustomerService service = new CustomerService();
            service.DeleteCustomers(id);
            return RedirectToAction("Index");
        }


    }
}
