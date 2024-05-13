namespace Půjčovna.Data
{
    public class Borrows
    {
        public int Id { get; set; }

        public required int Borrow_Number { get; set; }

        public required DateTime Borrow_Date_From { get; set; }

        public required DateTime Borrow_Date_To { get; set; }

        public required int Total_Deposit { get; set; }

        public required int Total_Prize { get; set; }

        public required string Note { get; set; }

        public required string Signature { get; set; }

        public int Contact_PersonID { get; set; }

        public int EmployeeID { get; set; }

        public virtual Employee? employee { get; set; }

        public virtual Contact_Person? contact_Person { get; set; }
    }
}
