using BLL.AbstractServices;
using BLL.ConcreteServices;
using BLL.MappingsProfile;
using DAL.AbstractRepositories;
using DAL.ConcreteRepositories;
using DAL.Data;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IAuthorRepository), typeof(AuthorRepository));
builder.Services.AddScoped(typeof(IBookRepository), typeof(BookRepository));
builder.Services.AddScoped(typeof(IAuthorService), typeof(AuthorService));
builder.Services.AddScoped(typeof(IBookService), typeof(BookService));


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(AutoMapperProfile));
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
