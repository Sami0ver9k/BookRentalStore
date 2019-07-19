﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookRentalStore.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
       
        public string author { get; set; }
        public int price { get; set; }
        public Genre genre { get; set; }




    }
}