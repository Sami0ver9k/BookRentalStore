using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookRentalStore.Models
{
    public class Customer
    {
        [Required]
       public int id { get; set; }
     
      public  string name { get; set; }
        [Required]
      public bool isSubscribedToNews { get; set; }
        [Display(Name="Membership package")]
        [Required]
      public MembershipType membershiptype { get; set; }
      //public byte MembershipTypeId { get; set; }


    }
}