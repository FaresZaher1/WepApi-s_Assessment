using FaresMohamed_S1___0522031_.Data;
using FaresMohamed_S1___0522031_.DTO_s;
using FaresMohamed_S1___0522031_.Models;

namespace FaresMohamed_S1___0522031_.Reposatory.DirectorRepo
{
    public class DirectorRepos : IDirectorRepos
    {
        protected readonly ApplecationDbContext _context;
        public DirectorRepos(ApplecationDbContext applecationDbContext)
        { 
        _context = applecationDbContext;
        }
        public void delete( int id)
        {
            var x = _context.directorModels.FirstOrDefault(x => x.DirectorModelId == id);
            if (x != null)
            {
                _context.Remove(x);
            }
            else
            {
                throw null;
            }
        }

        public void post(DirectorDto directorDto)
        {
            var x = new DirectorModel
            {
                Name = directorDto.Name,
                Contact = directorDto.Contact,
                email = directorDto.email,
                nationalityModels = new NationalityModel
                { 
                Name = directorDto.nationalityDtos.Name
                }
            };
            _context.Add(x);
            _context.SaveChanges();
        }

        public void update(DirectorDto directorDto, int id)
        {
            var userfinder = _context.directorModels.FirstOrDefault(x => x.DirectorModelId == id);
            if (userfinder != null)
            {
                userfinder.Name = directorDto.Name;
                userfinder.email = directorDto.email;
                userfinder.Contact = directorDto.Contact;
                userfinder.nationalityModels = new NationalityModel
                {
                    Name = userfinder.nationalityModels.Name
                };
                _context.Update(userfinder);
                _context.SaveChanges();
            }
            else
            {
                throw null;
            }
        }
    }
}
