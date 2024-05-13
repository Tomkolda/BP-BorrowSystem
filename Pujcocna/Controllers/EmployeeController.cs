using Microsoft.EntityFrameworkCore;
using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    public class EmployeeController : EmployeeService
    {
        private readonly BorrowDB db;

        public EmployeeController(BorrowDB db)
        {
            this.db = db;
        }

        public void DeleteEmployee(Employee employee)
        {
            employee.Is_Deleted = true;
            try
            {
                var local = db.Set<Employee>().Local.FirstOrDefault(entry => entry.Id.Equals(employee.Id));
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch
            {
                throw;
            }

        }

        public IEnumerable<Employee> GetAll()
        {
            try
            {
                return db.Employees.ToList().Where(x => x.Is_Deleted == false);
            }
            catch
            {
                throw;
            }
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                return db.Employees.Where(x => x.Id == id).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public Employee GetEmployeeByLogin(string login)
        {
            try
            {
                return db.Employees.Where(x => x.Login == login).FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.Add(employee);
                db.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
