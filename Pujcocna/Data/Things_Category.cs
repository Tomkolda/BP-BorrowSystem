namespace Půjčovna.Data
{
    public class Things_Category
    {
        public int Id { get; set; }

        public required int Things_To_BorrowID { get; set; }

        public required int CategoryId { get; set; }

        public virtual Category? category { get; set; }

       public virtual Things_To_Borrow? things_to_borrow { get; set; }
    }
}
