using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data

{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.actorId,
                am.movieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actor_movies).HasForeignKey(m => m.movieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.actor_movies).HasForeignKey(m => m.actorId);




            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }


    }
}
