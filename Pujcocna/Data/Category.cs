namespace Půjčovna.Data
{
    public class Category
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required int Default_deposit { get; set; }

    }
}
