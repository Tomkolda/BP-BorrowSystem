namespace Půjčovna.Data.Shared
{
    public class MyBorrowContainer
    {
        public Borrows borrow { get; set; }

        public void SetValue(Borrows borrow)
        {
            this.borrow = borrow;
        }
    }
}
