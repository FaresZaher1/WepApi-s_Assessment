using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.DTO_s
{
    public class CinemaDto
    {
        [Required]
        public string name { get; set; }
        public int placeholder { get; set; }
        public List<MovieDto> movieDtos { get; set; }
    }
}
