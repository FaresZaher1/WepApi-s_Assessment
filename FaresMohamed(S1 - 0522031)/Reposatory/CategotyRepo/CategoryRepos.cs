using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Models;

namespace FaresMohamed_S1___0522031_.Reposatory.CategotyRepo
{
    public class CategoryRepos : ICategoryRepos
    {
        protected readonly ApplecationDbContext _context;
        public CategoryRepos(ApplecationDbContext context) 
        {
        _context = context;
        }
        public void post(CategoryDto categoryDto)
        {
            var x = _context.categoryModels.FirstOrDefault(x => x.CategoryName == categoryDto.CategoryName);
            if (x == null)
            {
                var z = new CategoryModel
                {
                    CategoryName = categoryDto.CategoryName,
                };
                _context.Add(z);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("That Name Is Already Has been here before ");
            }
          
        }

        public void put(CategoryDto categoryDto, int id)
        {
            var usercheck = _context.categoryModels.FirstOrDefault(x => x.CategoryModelId == id);
            if (usercheck != null)
            {
                usercheck.CategoryName = categoryDto.CategoryName;
                _context.Update(usercheck);
                _context.SaveChanges();
            }
            else
            {
                throw null;
            }
        }
    }
}
