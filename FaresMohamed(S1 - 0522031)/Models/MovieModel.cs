using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.Models
{
    public class MovieModel
    {
        [Key]
        public int movieId { get; set; }
        [Required]
        public string title { get; set; }
        public DateOnly ReleaseYear { get; set; }
        public List<DirectorModel> directorModels { get; set; }
        public CategoryModel CategoryModelz { get; set; }
        public Cinema CinemaModel { get; set; } 



    }
}
