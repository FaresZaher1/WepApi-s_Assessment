using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Reposatory.CinemaRepo;
using Microsoft.AspNetCore.Mvc;

namespace FaresMohamed_S1___0522031_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICenmaRepos _cenmaRepos;
        public CinemaController(ICenmaRepos cenmaRepos)
        {
            _cenmaRepos = cenmaRepos;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var x = _cenmaRepos.getall();
            return Ok(x);
        }
        [HttpPost]
        public IActionResult post(CinemaDto cinemaDto)
        {
            _cenmaRepos.post(cinemaDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult put(int id , CinemaDto cinemaDto) 
        {
           _cenmaRepos.put(id, cinemaDto);
            return Ok();
        }
    }
}
