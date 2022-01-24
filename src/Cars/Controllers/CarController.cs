using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("cars")]
    public class CarController : ControllerBase
    {
        private readonly IQueryHandler<GetAllCarsQuery, IList<Car>> _getAllCarsQuery;
        public CarController(
            IQueryHandler<GetAllCarsQuery, IList<Car>> getAllCarsQuery)
        {
            _getAllCarsQuery = getAllCarsQuery;
        }

        [HttpGet(Name = "GetAllCars")]
        public async Task<IActionResult> GetAllCars()
        {
            IList<Car> cars = await _getAllCarsQuery.HandleAsync(new GetAllCarsQuery());

            return Ok(cars);
        }
    }
}
