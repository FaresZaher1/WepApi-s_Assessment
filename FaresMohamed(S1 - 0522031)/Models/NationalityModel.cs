using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FaresMohamed_S1___0522031_.Models
{
    public class NationalityModel
    {
        [Key]
        public int NationalityModelId { get; set; }
        [Required]
        public string Name { get; set; }        
        public DirectorModel DirectorModel { get; set; }
    }
}
