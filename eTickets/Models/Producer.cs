using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string profilePictureURL { get; set; }


        [Display(Name = "Full Name")]
        public string fullName { get; set; }


        [Display(Name = "Biography")]
        public string bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
