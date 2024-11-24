using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Reposatory.MovieRepo;
using Microsoft.AspNetCore.Mvc;

namespace FaresMohamed_S1___0522031_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        protected readonly IMovieRepos _movieRepos;
        public MovieController(IMovieRepos movieRepos)
        {
            _movieRepos = movieRepos;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var x = _movieRepos.Getall();
            return Ok(x);

        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var x = _movieRepos.GetById(id);
            return Ok(x);
        }
        [HttpPost]
        public IActionResult Post(MovieDto movieDto) 
        {
            _movieRepos.post(movieDto);
            return Ok();
        }

    }
}
