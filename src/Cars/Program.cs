using Core.Commands;
using Core.Entity;
using Core.Queries;
using DAL;
using DAL.Commands.CarsCommand;
using DAL.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CarsContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<IQueryHandler<GetAllCarsQuery, IList<Car>>, GetAllCarsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllOwnersQuery, IList<Owner>>, GetAllOwnersQueryHandler>();

builder.Services.AddScoped<ICommandHandler<CarsCommand>, CarsCommandHandler>();
builder.Services.AddScoped<ICommandHandler<CarsCommand>, DeleteCarsCommandHandler>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
