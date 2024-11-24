 using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.Reposatory.CategotyRepo;
using FaresMohamed_S1___0522031_.Reposatory.CinemaRepo;
using FaresMohamed_S1___0522031_.Reposatory.DirectorRepo;
using FaresMohamed_S1___0522031_.Reposatory.MovieRepo;
using FaresMohamed_S1___0522031_.Reposatory.NationalityRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContext<ApplecationDbContext>(x => x.UseSqlServer(connection));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMovieRepos, MovieRepos>();
builder.Services.AddScoped<IDirectorRepos, DirectorRepos>();
builder.Services.AddScoped<ICategoryRepos, CategoryRepos>();
builder.Services.AddScoped<INationalityRepo, NationalityRepos>();
builder.Services.AddScoped<ICenmaRepos, CinemaRepos>();



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
