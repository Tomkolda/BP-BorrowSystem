namespace Půjčovna.Data
{
    public class Contact_Person
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Surname { get; set; }

        public required string Phone { get; set; }

        public required string Email { get; set; }

        public required string IDcard_number { get; set; }
        public Boolean Is_Deleted { get; set; }
        public int CustomerId { get; set; }
    }
}
