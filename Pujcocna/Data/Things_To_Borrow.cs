namespace Půjčovna.Data
{
    public class Things_To_Borrow
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required int Inventory_number { get; set; }

        public Boolean Is_Deleted { get; set; }


    }
}
