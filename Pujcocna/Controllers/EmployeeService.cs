using Půjčovna.Data;

namespace Půjčovna.Controllers
{
    interface EmployeeService
    {
        Employee GetEmployeeByLogin(string login);
        IEnumerable<Employee> GetAll();
        Employee GetEmployee(int id);

        void AddEmployee(Employee employee);
        void DeleteEmployee(Employee employee);
    }
}
