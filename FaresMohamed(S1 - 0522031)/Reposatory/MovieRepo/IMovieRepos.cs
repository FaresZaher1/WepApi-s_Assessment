using FaresMohamed_S1___0522031_.DTO_s;

namespace FaresMohamed_S1___0522031_.Reposatory.MovieRepo
{
    public interface IMovieRepos
    {
        public List<MovieDto> Getall();
        MovieDto GetById(int id);
        void post(MovieDto movieDto);
    }
}
