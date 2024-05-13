namespace Půjčovna.Data.Shared;
    public class MyCustomerContainer
    {
        public Customer customer { get; set; }
        public Contact_Person contact { get; set; }
        public void SetValue(Customer cust, Contact_Person con)
        {
            this.customer = cust;
            this.contact = con;
    }
}
