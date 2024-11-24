using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FaresMohamed_S1___0522031_.Reposatory.CinemaRepo
{
    public class CinemaRepos : ICenmaRepos
    {
        private readonly ApplecationDbContext _context;
        public CinemaRepos(ApplecationDbContext context) 
        {
            _context =context ;
        }
        public List<CinemaDto> getall()
        {
            var x = _context.cinemas.Include(x=> x.Models).ThenInclude(x=> x.CategoryModelz).Select(x=>  new CinemaDto
            { 
            name = x.name,
            movieDtos = x.Models.Select(x=> new MovieDto
            {
                title = x.title,
                ReleaseYear = x.ReleaseYear,
                categoryDtos = new CategoryDto
                { 
                CategoryName = x.CategoryModelz.CategoryName,
                }
            }).ToList()
            }).ToList();
            return x;

        }

        public void  post(CinemaDto cinemaDto)
        {
            var x = new Cinema
            {
                name = cinemaDto.name,
                placeholder = cinemaDto.placeholder,
                Models = cinemaDto.movieDtos.Select(x => new MovieModel
                {
                    title = x.title,
                    ReleaseYear = x.ReleaseYear,
                    CategoryModelz = new CategoryModel
                    { 
                    CategoryName = x.categoryDtos.CategoryName,
                    }
                }).ToList()
            };
            _context.Add(x);
            _context.SaveChanges();
        }

        public void put(int id, CinemaDto cinemaDto)
        {
            var find = _context.cinemas.Include(x => x.Models).ThenInclude(x => x.CategoryModelz).FirstOrDefault(x => x.Id == id);
            if (find != null)
            {
                find.name = cinemaDto.name;
                find.placeholder = cinemaDto.placeholder;
                find.Models = cinemaDto.movieDtos.Select(x => new MovieModel
                {
                    title = x.title,
                    ReleaseYear = x.ReleaseYear,
                    CategoryModelz = new CategoryModel
                    {
                        CategoryName = x.categoryDtos.CategoryName,
                    }
                }).ToList();
                _context.Update(find);
                _context.SaveChanges();
            }
            
        }
    }
}
