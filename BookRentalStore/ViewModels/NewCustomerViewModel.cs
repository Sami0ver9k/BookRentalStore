using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookRentalStore.Models;


namespace BookRentalStore.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> membershiptypes { get; set; }
        public Customer customer { get;  set; }
    }
}