
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Půjčovna.Data
{
    public class BorrowDB : IdentityDbContext
    {
        public BorrowDB()
        {

        }

        public BorrowDB(DbContextOptions<BorrowDB> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact_Person> Contact_Persons { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Things_To_Borrow> Things_To_Borrows { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Borrows> Borrows { get; set; }

        public DbSet<Borrow_things> Borrow_Things { get; set; }

        public DbSet<Things_Category> Things_Categories { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
        }

    }
}
