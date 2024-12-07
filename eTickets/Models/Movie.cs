using eTickets.Data.enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        // Relationships
        public List<Actor_Movie> actor_movies { get; set; }

        // Correct Foreign Key for Cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")] // Match the property name exactly
        public Cinema cinema { get; set; }

        // Correct Foreign Key for Producer
        public int producerId { get; set; }
        [ForeignKey("producerId")] // Match the property name exactly
        public Producer producer { get; set; }
    }
}