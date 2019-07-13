using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookRentalStore.Models
{
    public class Customer
    {

       public int id { get; set; }
        [Required]
      public  string name { get; set; }
      public bool isSubscribedToNews { get; set; }
      public MembershipType membershiptype { get; set; }
      //public byte MembershipTypeId { get; set; }


    }
}