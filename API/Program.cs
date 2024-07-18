using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//register services here when application needs

builder.Services.AddControllers();//service to add the controller and register them so that we can use the API endpoint
//register DataContext Service and what sservices we are using
builder.Services.AddDbContext<DataContext>(opt => {
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//stuff here considered as middleware
// we can put things here that allows us to to do 
//something with the HTTP request on its way into out
//api service or its way out of out API service.
//example we can check user is authorized to access an API endpoint then we've got middleware
// such as Authorization
// for redirect then we can use UseHttpsRedirection middleware

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// app.UseHttpsRedirection();

// app.UseAuthorization();

app.MapControllers(); //middleware to map controller endpoints

app.Run();
