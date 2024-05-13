using Microsoft.EntityFrameworkCore;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class CustomerController : CustomerService
    {
        private readonly BorrowDB db;

        public CustomerController(BorrowDB db)
        {
            this.db = db;
        }

        public IEnumerable<Customer> GetCustomers() {
            try
            {
                return db.Customers.ToList();
            }
            catch
            {
                throw;
            }
        }
        public void InsertCustomer (Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public int GetCustomerId(Customer customer)
        {
            try
            {
                return db.Customers.Where(x => x.Name == customer.Name).Select(x => x.Id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public Customer GetCustomerById(int id)
        {
            try
            {
                return db.Customers.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            try
            {
                var local = db.Set<Customer>().Local.FirstOrDefault(entry => entry.Id.Equals(customer.Id));
                // check if local is not null
                if (local != null)
                {
                    // detach
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch 
            { 
                throw;
            }
        }
    }
}
