namespace Půjčovna.Data.Shared
{
    public class MyEmployeeContainer
    {
        public Employee employee { get; set; }

        public void SetValue(Employee employee) { 
            this.employee = employee;
        }
    }
}
