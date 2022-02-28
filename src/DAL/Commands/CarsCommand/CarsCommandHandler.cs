using Core.Commands;

namespace DAL.Commands.CarsCommand
{
    public class CarsCommandHandler : ICommandHandler<CarsCommand>
    {
        private readonly CarsContext _carsContext;
        public CarsCommandHandler(CarsContext carsContext)
        {
            _carsContext = carsContext;
        }
        public async Task HandleAsync(CarsCommand command, CancellationToken cancellationToken = default)
        {
            _carsContext.AddAsync(command.Car);
            await _carsContext.SaveChangesAsync();
        }
    }
}
