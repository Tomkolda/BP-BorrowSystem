using Microsoft.AspNetCore.Components;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    interface CustomerService
    {
        IEnumerable<Customer> GetCustomers();
        void InsertCustomer (Customer customer);
        
        int GetCustomerId(Customer customer);

        Customer GetCustomerById(int id);

        void UpdateCustomer (Customer customer);
    }
}
