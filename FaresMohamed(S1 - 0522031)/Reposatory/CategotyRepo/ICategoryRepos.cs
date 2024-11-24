using FaresMohamed_S1___0522031_.DTO_s;

namespace FaresMohamed_S1___0522031_.Reposatory.CategotyRepo
{
    public interface ICategoryRepos
    {
        public void post(CategoryDto categoryDto);
        public void put(CategoryDto categoryDto,int id);
    }
}
