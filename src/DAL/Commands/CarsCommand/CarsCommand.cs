using Core.Commands;
using Core.Entity;

namespace DAL.Commands.CarsCommand
{
    public class CarsCommand : ICommand
    {
        public CarsCommand(Car car)
        {
            Car = car;
        }
        public Car Car { get; set; }
    }
}
