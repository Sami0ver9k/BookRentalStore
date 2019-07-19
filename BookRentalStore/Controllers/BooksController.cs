using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentalStore.Models;
using BookRentalStore.ViewModels;
using System.Data.Entity;

namespace BookRentalStore.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/

        
        public ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

       

        public ViewResult Index()
        {

            var books = _context.books.Include(b=>b.genre).ToList();
            return View(books);


        }

 



        public ActionResult Details(int id)
        {
            var books = _context.books.Include(c=> c.genre).SingleOrDefault(c => c.id == id);
           
            return View(books);
        }

      


	}
}