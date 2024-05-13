namespace Půjčovna.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Login { get; set; }
        public required string Password { get; set; }
        public required string Signature { get; set; }
        public Boolean Is_Deleted { get; set; }
        public int role { get; set; }
    }
}
