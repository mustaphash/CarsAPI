using Core.Entity;
using Core.Queries;
using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Cars.Controllers
{
    [ApiController]
    [Route("owners")]
    public class OwnerController : ControllerBase
    {
        private readonly IQueryHandler<GetAllOwnersQuery, IList<Owner>> _getAllOwnerQuery;
        public OwnerController(
            IQueryHandler<GetAllOwnersQuery, IList<Owner>> getAllOwnerQuery)
        {
            _getAllOwnerQuery = getAllOwnerQuery;
        }

        [HttpGet(Name = "GetAllOwners")]
        public async Task<IActionResult> GetAllOwners()
        {
            IList<Owner> owners = await _getAllOwnerQuery.HandleAsync(new GetAllOwnersQuery());

            return Ok(owners);
        }
    }
}
