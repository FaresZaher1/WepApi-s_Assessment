using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Reposatory.NationalityRepo;
using Microsoft.AspNetCore.Mvc;

namespace FaresMohamed_S1___0522031_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationalityController : ControllerBase
    {
        protected readonly INationalityRepo _naturalityRepo;
        public NationalityController(INationalityRepo naturalityRepo)
        {
            _naturalityRepo = naturalityRepo;
        }
        [HttpPost]
        public IActionResult post(NationalityDto nationalityDto)
        {
            _naturalityRepo.post(nationalityDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult delete(int id) 
        {
            _naturalityRepo.delete(id);
            return Ok();
        }
    }
}
