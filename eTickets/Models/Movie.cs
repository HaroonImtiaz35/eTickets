using eTickets.Data.enums;

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

    }
}
