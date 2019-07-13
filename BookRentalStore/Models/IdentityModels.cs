using Microsoft.AspNet.Identity.EntityFramework;
using BookRentalStore.Models;
using System.Data.Entity;

namespace BookRentalStore.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Customer> customers { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection")
       {
        }

    }
}