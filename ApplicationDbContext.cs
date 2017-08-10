using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Collections;

namespace BookLibrary.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<Book> Books { get; set; }
        public IEnumerable ApplicationUsers { get; internal set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}