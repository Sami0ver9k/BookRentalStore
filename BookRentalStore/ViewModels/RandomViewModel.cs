using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookRentalStore.Models;

namespace BookRentalStore.ViewModels
{
    public class RandomViewModel
    {
        public int a = 0;
        public Book book { get; set; }
        public List<Customer> customers { get; set; } 




    }
}