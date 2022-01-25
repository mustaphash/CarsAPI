namespace Core.Entity
{
    public class Owner
    {
        public Owner()
        {
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public DateTime PurchaseDate { get; set; }

        public int CarId { get; set; }
        public Car Cars { get; set; }
    }
}
