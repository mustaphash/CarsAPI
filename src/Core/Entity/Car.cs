namespace Core.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Kilometers { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public DateTime DateOfManufacture { get; set; }

        public int OwnerId { get; set; }
        public Owner Owners { get; set; }
    }
}
