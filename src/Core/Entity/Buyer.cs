namespace Core.Entity
{
    public class Buyer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public ICollection<Buyer> Buyers { get; set; }
    }
}
