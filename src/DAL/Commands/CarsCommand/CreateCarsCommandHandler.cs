using Core.Commands;

namespace DAL.Commands.CarsCommand
{
    public class CreateCarsCommandHandler : ICommandHandler<CreateCarsCommand>
    {
        private readonly CarsContext _carsContext;
        public CreateCarsCommandHandler(CarsContext carsContext)
        {
            _carsContext = carsContext;
        }
        public async Task HandleAsync(CreateCarsCommand command, CancellationToken cancellationToken = default)
        {
            _carsContext.AddAsync(command.Car);
            await _carsContext.SaveChangesAsync();
        }
    }
}
