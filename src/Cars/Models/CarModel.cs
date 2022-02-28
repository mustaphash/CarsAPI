using Core.Entity;

namespace Cars.Models
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Kilometers { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string Fuel { get; set; }
        public DateTime DateOfManufacture { get; set; }

        public Car ToCar()
        {
            return new Car
            {
                Make = this.Make,
                Model = this.Model,
                Kilometers = this.Kilometers,
                Transmission = this.Transmission,
                Color = this.Color,
                Fuel = this.Fuel,
                DateOfManufacture = this.DateOfManufacture,
            };
        }
        public Car ToDel()
        {
            return new Car
            {
                Id = this.Id
            };
        }
    }
}
