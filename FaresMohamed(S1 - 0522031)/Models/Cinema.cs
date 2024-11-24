using System.ComponentModel.DataAnnotations;

namespace FaresMohamed_S1___0522031_.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public int placeholder { get; set; }
        public List<MovieModel> Models { get; set; }
    }
}
 