using FaresMohamed_S1___0522031_.Models;
using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.DTO_s
{
    public class MovieDto
    {
        [Required]
        public string title { get; set; }
        public DateOnly ReleaseYear { get; set; }
        public List<DirectorDto> directorDtos { get; set; }
        public CategoryDto categoryDtos { get; set; }
        public cinematoaddmovie Cinema { get; set; }
       

    }
}
