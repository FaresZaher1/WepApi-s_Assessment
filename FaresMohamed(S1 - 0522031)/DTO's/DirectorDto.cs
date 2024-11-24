using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.DTO_s
{
    public class DirectorDto
    {
        [Required]
        public string Name { get; set; }
        [Phone(ErrorMessage = "Phone Not Valid")]
        public string Contact { get; set; }
        [EmailAddress(ErrorMessage = "Email Not Valid")]
        public string email { get; set; }
        public NationalityDto nationalityDtos { get; set; }
    }
}
