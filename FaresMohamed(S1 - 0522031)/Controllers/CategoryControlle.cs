using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Reposatory.CategotyRepo;
using Microsoft.AspNetCore.Mvc;

namespace FaresMohamed_S1___0522031_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CategoryController : ControllerBase
    {
        protected readonly ICategoryRepos _repo;
        public CategoryController(ICategoryRepos categoryDto)
        {
            _repo = categoryDto;
        }
        [HttpPost]
        public IActionResult post(CategoryDto categoryDto)
        { 
            _repo.post(categoryDto);
            return Ok();
        }
        [HttpPut]
        public IActionResult put(CategoryDto categoryDto , int id)
        {
            _repo.put(categoryDto, id);
            return Ok();
        }
    }
}
