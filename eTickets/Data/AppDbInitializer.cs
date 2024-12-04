using eTickets.Models;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuiler)
        {
            using (var serviceScope = applicationBuiler.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {

                        new Cinema()
                        {
                            name = "Cinema 1",
                            logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            description = "This is the description of cinema 1"
                        },
                        new Cinema()
                        {
                            name = "Cinema 2",
                            logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            description = "This is the description of cinema 2"
                        },
                        new Cinema()
                        {
                            name = "Cinema 3",
                            logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            description = "This is the description of cinema 3"
                        },
                        new Cinema()
                        {
                            name = "Cinema 4",
                            logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            description = "This is the description of cinema 4"
                        },
                        new Cinema()
                        {
                            name = "Cinema 5",
                            logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            description = "This is the description of cinema 5"
                        },
                    });
                    context.SaveChanges();

                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            fullName = "Actor 1",
                            bio = "This is bio of actor 1",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 2",
                            bio = "This is bio of actor 2",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 3",
                            bio = "This is bio of actor 3",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 4",
                            bio = "This is bio of actor 4",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            fullName = "Actor 5",
                            bio = "This is bio of actor 5",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        },

                    });
                    context.SaveChanges();

                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            fullName = "Prducer 1",
                            bio = "This is bio of producer 1",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Prducer 2",
                            bio = "This is bio of producer 2",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Prducer 3",
                            bio = "This is bio of producer 3",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Prducer 4",
                            bio = "This is bio of producer 4",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            fullName = "Prducer 5",
                            bio = "This is bio of producer 5",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },

                    });
                    context.SaveChanges();

                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {

                        new Movie()
                        {
                            name = "Scoob",
                            description = "This is Scoob movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-2),
                            cinemaId = 3,
                            producerId = 3,
                            MovieCategory = enums.MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            name = "Race",
                            description = "This is Race movie description",
                            price = 37.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            startDate = DateTime.Now.AddDays(-12),
                            endDate = DateTime.Now.AddDays(-5),
                            cinemaId = 1,
                            producerId = 2,
                            MovieCategory = enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "Ghost",
                            description = "This is Ghost movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(7),
                            cinemaId = 4,
                            producerId = 4,
                            MovieCategory = enums.MovieCategory.Horror
                        },
                        new Movie()
                        {
                            name = "The Shawshank Redemption",
                            description = "This is The Shawshank Redemption movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(3),
                            cinemaId = 2,
                            producerId = 3,
                            MovieCategory = enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            name = "Life",
                            description = "This is Life movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(10),
                            cinemaId = 3,
                            producerId = 3,
                            MovieCategory = enums.MovieCategory.Cartoon
                        },new Movie()
                        {
                            name = "Cold Soles",
                            description = "This is Cold Soles movie description",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            startDate = DateTime.Now.AddDays(3),
                            endDate = DateTime.Now.AddDays(20),
                            cinemaId = 1,
                            producerId = 1,
                            MovieCategory = enums.MovieCategory.Drama
                        }


                    });
                    context.SaveChanges();

                }

                //Actors & Movies
                context.Actors_Movies.AddRange(new List<Actor_Movie>()
                {
                    new Actor_Movie()
                    {
                        actorId = 5,
                        movieId = 2
                    },
                    new Actor_Movie()
                    {
                        actorId = 3,
                        movieId = 2
                    },
                    new Actor_Movie()
                    {
                        actorId = 4,
                        movieId = 2
                    },
                    new Actor_Movie()
                    {
                        actorId = 1,
                        movieId = 3
                    },
                    new Actor_Movie()
                    {
                        actorId = 3,
                        movieId = 3
                    },
                    new Actor_Movie()
                    {
                        actorId = 2,
                        movieId = 4
                    },
                    new Actor_Movie()
                    {
                        actorId = 3,
                        movieId = 4
                    },
                    new Actor_Movie()
                    {
                        actorId = 5,
                        movieId = 4
                    },
                    new Actor_Movie()
                    {
                        actorId = 1,
                        movieId = 5
                    },
                    new Actor_Movie()
                    {
                        actorId = 4,
                        movieId = 5
                    },
                    new Actor_Movie()
                    {
                        actorId = 3,
                        movieId = 5
                    }

                });
                context.SaveChanges();

            }

        }

    }
}
