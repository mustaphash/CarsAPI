using Cars.Models;
using Core.Commands;
using Core.Entity;
using Core.Queries;
using DAL.Commands.CarsCommand;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarController : ControllerBase
    {
        private readonly IQueryHandler<GetAllCarsQuery, IList<Car>> _getAllCarsQuery;
        private readonly ICommandHandler<CarsCommand> _crateCarsCommand;
        public CarController(
            IQueryHandler<GetAllCarsQuery, IList<Car>> getAllCarsQuery,
            ICommandHandler<CarsCommand> crateCarsCommand)
        {
            _getAllCarsQuery = getAllCarsQuery;
            _crateCarsCommand = crateCarsCommand;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            IList<Car> cars = await _getAllCarsQuery.HandleAsync(new GetAllCarsQuery());

            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCar(CarModel carModel)
        {
            var cars = carModel.ToCar();
            await _crateCarsCommand.HandleAsync(new CarsCommand(cars));

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCar(CarModel carModel)
        {
            var cars = carModel.ToDel();
            await _crateCarsCommand.HandleAsync(new CarsCommand(cars));

            return NoContent();
        }
    }
}
