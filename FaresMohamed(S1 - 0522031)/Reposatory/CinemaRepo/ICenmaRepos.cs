using FaresMohamed_S1___0522031_.DTO_s;

namespace FaresMohamed_S1___0522031_.Reposatory.CinemaRepo
{
    public interface ICenmaRepos
    {
        public void put(int id , CinemaDto cinemaDto);
        public void post(CinemaDto cinemaDto);
        public List<CinemaDto> getall();

            // one to meny between cinema and movie 

    }
}
