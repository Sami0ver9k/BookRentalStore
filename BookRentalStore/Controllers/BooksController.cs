using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookRentalStore.Models;
using BookRentalStore.ViewModels;

namespace BookRentalStore.Controllers
{
    public class BooksController : Controller
    {
        //
        // GET: /Books/
        
       
        public ViewResult Index()
        {

            var books = GetBook();
            return View(books);


        }

        private IEnumerable<Book> GetBook()
        {
           return new List<Book>
            {
                new Book {id=1, name="cxpp"},
                 new Book {id=2, name="csapp"}
                



            };

        }
   


	}
}