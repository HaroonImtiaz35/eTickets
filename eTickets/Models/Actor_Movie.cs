using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.PortableExecutable;

namespace eTickets.Models
{
    public class Actor_Movie
    {

        public int movieId { get; set; }

        public Movie movie { get; set; }

        public int actorId { get; set; }

        //Relationships
        public Actor actor { get; set; }


        //Cinema
        public int cinemaId { get; set; }
        [ForeignKey("cinemaId")]
        public Cinema cinema { get; set; }



        //Producer
        public int producerId { get; set; }
        [ForeignKey("producerId")]
        public Producer producer { get; set; }

    }
}
