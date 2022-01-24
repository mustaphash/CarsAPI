using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries
{
    public class GetAllCarsQueryHandler : IQueryHandler<GetAllCarsQuery, IList<Car>>
    {
        private readonly CarsContext _carContext;
        public GetAllCarsQueryHandler(CarsContext carsContext)
        {
            _carContext = carsContext;
        }
        public async Task<IList<Car>> HandleAsync(GetAllCarsQuery query, CancellationToken cancellationToken = default)
        {
            List<Car> cars = await _carContext.Cars.ToListAsync(cancellationToken);
            
            return cars;
        }
    }
}
