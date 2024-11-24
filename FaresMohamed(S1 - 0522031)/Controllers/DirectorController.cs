using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Reposatory.DirectorRepo;
using Microsoft.AspNetCore.Mvc;

namespace FaresMohamed_S1___0522031_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        protected readonly IDirectorRepos directorRepos;
        public DirectorController(IDirectorRepos directorRepos)
        {
            this.directorRepos = directorRepos;
        }
        [HttpPost]
        public IActionResult post(DirectorDto directorDto)
        { 
        directorRepos.post(directorDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult put(DirectorDto directorDto, int id)
        {
            directorRepos.update(directorDto, id);
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete(int id) 
        {
            directorRepos.delete(id);
            return Ok();
        }

    }
}
