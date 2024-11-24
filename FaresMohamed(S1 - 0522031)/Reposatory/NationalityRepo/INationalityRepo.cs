using FaresMohamed_S1___0522031_.DTO_s;

namespace FaresMohamed_S1___0522031_.Reposatory.NationalityRepo
{
    public interface INationalityRepo
    {
        public void post(NationalityDto nationalityDto);
        public void delete(int id);
    }
}
