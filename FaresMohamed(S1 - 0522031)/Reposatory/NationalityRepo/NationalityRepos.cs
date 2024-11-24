using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Models;

namespace FaresMohamed_S1___0522031_.Reposatory.NationalityRepo
{
    public class NationalityRepos : INationalityRepo
    {
        protected readonly ApplecationDbContext _applecationDbContext;
        public NationalityRepos(ApplecationDbContext applecationDbContext)
        {
            _applecationDbContext = applecationDbContext;
        }

        public void delete(int id)
        {
            var x = _applecationDbContext.nationalityModels.FirstOrDefault(x => x.NationalityModelId == id);
            if (x != null)
            {
                _applecationDbContext.Remove(x);
                _applecationDbContext.SaveChanges();
            }
            else
            {
                throw null;
            }
        }

        public void post(NationalityDto nationalityDto)
        {
            var x = new NationalityModel
            {
                Name = nationalityDto.Name,
            };
            _applecationDbContext.Add(x);
            _applecationDbContext.SaveChanges();
        }
    }
}
