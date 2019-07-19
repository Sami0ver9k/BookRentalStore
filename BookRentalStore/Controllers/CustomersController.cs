using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentalStore.Models;
using System.Data.Entity;
using BookRentalStore.ViewModels;
using System.Data.Entity.Validation;

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
         

            //var pack= _context.Member
            var customer = _context.customers.Include(c => c.membershiptype).SingleOrDefault(c => c.id == id);
             
            if (customer == null)
                return HttpNotFound();
            return View(customer);

        }


        public ActionResult Edit(int id)
        {


            //var pack= _context.Member
            var customer = _context.customers.SingleOrDefault(c => c.id == id);

            var viewModel= new NewCustomerViewModel
            {
                customer= customer,
                
                membershiptypes=_context.membershiptypes.ToList()

            };


            if (customer == null)
                return HttpNotFound();
            return View("newCustomer",viewModel );

        }


        public ActionResult newCustomer ()
        {
            var membershiptypes = _context.membershiptypes.ToList();
            var viewModel = new NewCustomerViewModel
            {


                membershiptypes=membershiptypes

            };

            return View(viewModel);

        }

        [HttpPost]
        public ActionResult Create(Customer newCustomer)
        {
            //Mapper.Map(Customer,cusindb) using custom DTO class
            if(!ModelState.IsValid)
            {

                var newViewmodel = new NewCustomerViewModel
                {

                    customer = newCustomer,
                    membershiptypes = _context.membershiptypes


                };

                return View("newCustomer", newViewmodel);


            }
            if(newCustomer.id==0)
            {//adds new customer if not found
                _context.customers.Add(newCustomer);


            }
            else
            {
                var customerInDb = _context.customers.Single(c => c.id == newCustomer.id);
               // TryUpdateModel(customerInDb);
                //updates every thing vut shouldnt be used

                customerInDb.name = newCustomer.name;
                customerInDb.isSubscribedToNews = newCustomer.isSubscribedToNews;
                customerInDb.membershiptype = newCustomer.membershiptype;

            }

            try
            {
                _context.SaveChanges();
            }

            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
               
            }



          return  RedirectToAction("Index", "Customers");


        }




	}
}