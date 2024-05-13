namespace Půjčovna.Data
{
    public class Borrow_things
    {
        public int Id { get; set; }
        public required int Things_To_BorrowID { get; set; }

        public required int BorrowsId { get; set; }

        public required int Real_Deposit {  get; set; }

        public required int Prize {  get; set; }

        public required int CategoryID {  get; set; }

        public virtual Things_To_Borrow? things_to_borrow { get; set; }
        public virtual Borrows? borrows { get; set; }

        public virtual Category? category { get; set; }
    }
}
