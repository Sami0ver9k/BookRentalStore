using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentalStore.Models;
using System.Data.Entity;

namespace BookRentalStore.Controllers
{
    public class CustomersController : Controller
    {
        //
        // GET: /Cumstomers/

        ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var customers = _context.customers.Include(c => c.membershiptype).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.customers.SingleOrDefault(c => c.id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);

        }



	}
}