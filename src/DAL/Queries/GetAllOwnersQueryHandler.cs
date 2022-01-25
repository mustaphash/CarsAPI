using Core.Entity;
using Core.Queries;
using Microsoft.EntityFrameworkCore;

namespace DAL.Queries
{
    public class GetAllOwnersQueryHandler : IQueryHandler<GetAllOwnersQuery, IList<Owner>>
    {
        private readonly CarsContext _carsContext;
        public GetAllOwnersQueryHandler(CarsContext carsContext)
        {
            _carsContext = carsContext;
        }
        public async Task<IList<Owner>> HandleAsync(GetAllOwnersQuery query, CancellationToken cancellationToken = default)
        {
            List<Owner> owners = await _carsContext.Owners.ToListAsync(cancellationToken);

            return owners;
        }
    }
}
