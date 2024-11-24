using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Models;
using Microsoft.EntityFrameworkCore;

namespace FaresMohamed_S1___0522031_.Reposatory.MovieRepo
{
    public class MovieRepos : IMovieRepos
    {
        protected readonly ApplecationDbContext _Context;
        public MovieRepos(ApplecationDbContext context)
        {
            _Context = context;
        }

        public List<MovieDto> Getall()
        {
            var z = _Context.movieModels.Include(x => x.directorModels).ThenInclude(x => x.nationalityModels).Include(x => x.CinemaModel).Include(x => x.CategoryModelz).Select(x => new MovieDto
            {
                title = x.title,
                ReleaseYear = x.ReleaseYear,
                Cinema = new cinematoaddmovie
                { 
                name = x.CinemaModel.name,
                placeholder = x.CinemaModel.placeholder
                },
                categoryDtos = new CategoryDto
                { 
                CategoryName = x.CategoryModelz.CategoryName,
                },
                directorDtos = x.directorModels.Select(x => new DirectorDto
                {
                    Name = x.Name,
                    Contact = x.Contact,
                    email = x.email,
                    nationalityDtos = new NationalityDto
                    { 
                    Name = x.nationalityModels.Name
                    }
                } 
                ).ToList(),
            }).ToList();
            return z;
        }
        public MovieDto GetById(int id)
        {
            var user = _Context.movieModels.Include(x => x.CinemaModel).Include(x => x.CategoryModelz).Include(x => x.directorModels).ThenInclude(x => x.nationalityModels).FirstOrDefault(x => x.movieId == id);
           
                var pop = new MovieDto
                {
                    title = user.title,
                    ReleaseYear = user.ReleaseYear,
                    categoryDtos = new CategoryDto
                    {
                        CategoryName = user.CategoryModelz.CategoryName,
                    },
                    directorDtos = user.directorModels.Select(x => new DirectorDto
                    {
                        Name = x.Name,
                        Contact = x.Contact,
                        email = x.email,
                        nationalityDtos = new NationalityDto 
                        {
                        Name = x.nationalityModels.Name,
                        }
                    }).ToList(),
                    Cinema = new cinematoaddmovie
                    { 
                    name = user.CinemaModel.name,
                    placeholder = user.CinemaModel.placeholder,
                    }
                };
                return pop;
            }
        

        public void post(MovieDto movieDto)
        {
            var x = new MovieModel
            {
                title = movieDto.title,
                ReleaseYear = movieDto.ReleaseYear,

                CategoryModelz = new CategoryModel
                {

                CategoryName = movieDto.categoryDtos.CategoryName,
                },
                directorModels = movieDto.directorDtos.Select(x => new DirectorModel
                {
                    Name = x.Name,
                    Contact = x.Contact,
                    email = x.email,
                    nationalityModels = new NationalityModel
                    { 
                    Name = x.nationalityDtos.Name,
                    }
                }
                ).ToList(),
                CinemaModel = new Cinema
                { 
                name = movieDto.Cinema.name,
                placeholder = movieDto.Cinema.placeholder,
                }
            };
            _Context.Add(x);
            _Context.SaveChanges();
        }
    }
}