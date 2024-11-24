using FaresMohamed_S1___0522031_.DTO_s;

namespace FaresMohamed_S1___0522031_.Reposatory.DirectorRepo
{
    public interface IDirectorRepos
    {
        public void post(DirectorDto directorDto);
        public void update(DirectorDto directorDto , int id);
        public void delete( int id);
    }
}
