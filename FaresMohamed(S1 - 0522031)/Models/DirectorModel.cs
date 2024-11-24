using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaresMohamed_S1___0522031_.Models
{
    public class DirectorModel
    {
        [Key]
        public int DirectorModelId { get; set; }
        [Required]
        public string Name { get; set; }
        [Phone(ErrorMessage = "Phone Not Valid")]
        public string Contact { get; set; }
        [EmailAddress(ErrorMessage = "Email Not Valid")]
        public string email { get; set; }
        public int NationalityModelId { get; set; }
        public List<MovieModel> movieModels { get; set; }
        public NationalityModel nationalityModels { get; set; }
    }
}
