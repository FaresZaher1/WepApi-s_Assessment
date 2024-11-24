using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryModelId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public List<MovieModel> movieModels { get; set; }

    }
}
