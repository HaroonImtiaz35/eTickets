using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; } 
        public string profilePictureURL { get; set; }
        
        public string fullName { get; set; }

        public string bio { get; set; }

        //Relationships

        public List<Actor_Movie> actor_movies { get; set; }

    }
}
