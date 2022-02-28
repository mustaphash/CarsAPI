using Core.Commands;
using Core.Entity;

namespace DAL.Commands.CarsCommand
{
    public class CreateCarsCommand : ICommand
    {
        public CreateCarsCommand(Car car)
        {
            Car = car;
        }
        public Car Car { get; set; }
    }
}
