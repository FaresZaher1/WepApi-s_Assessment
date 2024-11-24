using FaresMohamed_S1___0522031_.Models;
using Microsoft.EntityFrameworkCore;

namespace FaresMohamed_S1___0522031_.Data
{
    public class ApplecationDbContext : DbContext
    {
        public ApplecationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DirectorModel>().HasOne(x => x.nationalityModels).WithOne(x => x.DirectorModel);
        }
        public DbSet<MovieModel> movieModels { get; set; }
        public DbSet<CategoryModel> categoryModels { get; set; }
        public DbSet<NationalityModel> nationalityModels { get; set; }
        public DbSet<DirectorModel> directorModels { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
    }
}
