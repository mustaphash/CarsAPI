using Core.Commands;

namespace DAL.Commands.CarsCommand
{
    public class DeleteCarsCommandHandler : ICommandHandler<CarsCommand>
    {
        private readonly CarsContext _carsContext;
        public DeleteCarsCommandHandler(CarsContext carsContext)
        {
            _carsContext = carsContext;
        }
        public async Task HandleAsync(CarsCommand command, CancellationToken cancellationToken = default)
        {
            _carsContext.Remove(command.Car);
            await _carsContext.SaveChangesAsync();
        }
    }
}
