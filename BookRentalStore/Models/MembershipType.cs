using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookRentalStore.Models
{
    public class MembershipType
    {
        public int id { get; set; }
        public string package { get; set; }
        public int signUpFee { get; set; }
        public int duration { get; set; }
        public int discount { get; set; }





    }
}