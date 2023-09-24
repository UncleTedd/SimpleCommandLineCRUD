using ConsoleAppCRUD.DB;
using ConsoleAppCRUD.Services;
using Microsoft.EntityFrameworkCore;


public class Program
{
    public static void Main(string[] args)
    {
        var context = new MyDbContext();
        MovieService movieService = new();
        context.Database.Migrate();

        Console.WriteLine("please enter what you want to do with the database: C for creating a movie," +
                          "U for updating the movie, D for deletion: ");
        string keyword = Console.ReadLine();


        // CREATE METHOD


        if (keyword is not null && keyword.Equals("C"))
        {
            movieService.CreateMovie();
        }

        context.SaveChanges();


        // UPDATE METHOD


        if (keyword is not null && keyword.Equals("U"))
        {
            movieService.UpdateMovie();
            context.Movies.ToList().ForEach(x => x.Id = 1);
            context.SaveChanges();
        }

        //READ METHOD

        if (keyword is not null && keyword.Equals("R"))
        {
            movieService.GetListOfMovies();
        }


        //DELETE METHOD

        if (keyword is not null && keyword.Equals("D"))
        {
            movieService.DeleteMovie();
        }

        //DELETE BY ID

        if (keyword is not null && keyword.Equals("DID"))
        {
            movieService.DeleteMovieById();
        }


        /*  List<Movie> movies = movie.GetListOfMovies();

          int movieCount = movies.Count;

          foreach(Movie movie1 in movies)
          {
              Console.WriteLine(movie1.Name);
          }
          Console.WriteLine("Please enter keyword: C for Creating, U for Updating, " +
              "R for Reading, D for Deleton");
          string keyword = Console.ReadLine();

          if (keyword is not null && keyword.Equals("C"))
          {
              Console.WriteLine("please enter the name of the movie you want to create: ");
              context.Movies.Add(new MovieEntity()
              {
                  Name = Console.ReadLine()

              });

          }
          */

        // CREATE METHOD

        /*  if (keyword is not null && keyword.Equals("C"))
          {
              Console.WriteLine("Please enter the name of the movie you want to add: ");
              var name = Console.ReadLine();
              Console.WriteLine("Please enter the name of the Producer of the movie: ");
              string producerName = Console.ReadLine();
              Console.WriteLine("Please enter the Theater Name: ");
              var theaterName = Console.ReadLine();

              var id = movies.Count;
              //movie.CreateMovie(id, name, producerName, theaterName); piece of shitE
              movie.CreateMovie(new Movie(id, name, producerName, theaterName));
              if(movies.Count> movieCount)
              {
                  Console.WriteLine("The movie was added to the library, " +
                      "here is the up to date list of movies: ");
                  foreach (Movie movie1 in movies)
                  {
                      Console.WriteLine(movie1.Name);
                  }

              }
              Console.ReadKey();

          } */

        //UPDATE METHOD

        /*  if ((keyword is not null) && keyword.Equals("U"))
          {
              Console.WriteLine("What movie do you want to change?");
              var movieToUpDate = Console.ReadLine();


              //if(movieToUpDate is null)
              //{
              //    Console.WriteLine("Oops, the input is null!");


              //}


              try
              {
                  foreach (Movie m in movies)
                  {
                      if ((m.Name).Equals(movieToUpDate))
                      {
                          Console.WriteLine("Movie found, What part of the movie you want to change? (ex: Name, Producer, Theater)");

                          string partOfTheMovie = Console.ReadLine();
                          switch (partOfTheMovie)
                          {
                              case "Name":
                                  Console.WriteLine("What would you want the new name to be?");
                                  string newName = Console.ReadLine();
                                  m.Name = newName;
                                  Console.WriteLine("The name of the Movie successfully changed");
                                  break;
                              case "Producer":
                                  string newProducer = Console.ReadLine();
                                  m.Producer = newProducer;
                                  Console.WriteLine("The name of the Producer successfully changed");
                                  break;
                              case "Theater":
                                  string newTheater = Console.ReadLine();
                                  m.TheaterName = newTheater;
                                  Console.WriteLine("The name of the Theater successfully changed");
                                  break;
                          }
                          Console.WriteLine("THE MOVIE WAS SUCCESSFULLY UPDATED, " +
                              "HERE IS THE UP TO DATE LIST OF MOVIES:");
                          foreach (Movie movie1 in movies)
                          {
                              Console.WriteLine(movie1.Name);
                          }
                          Console.ReadKey();

                      }


                  }


              }
              catch (Exception e) { Console.WriteLine(e.Message); }


          } */

        //READ METHOD

        /*   if ((keyword is not null) && keyword.Equals("R"))
           {
               Console.WriteLine("Here is the list of All the movies:");

               foreach (Movie movie1 in movies)
               {
                   Console.WriteLine(movie1.ID + " " +  "Title: " + movie1.Name + "Producer: " + movie1.Producer +
                       "Theater: "+ movie1.TheaterName);
               }
               Console.ReadKey();

           }

           //DELETE METHOD

           if ((keyword is not null) && keyword.Equals("D"))
           {
               Console.WriteLine("Please enter the Name of the movie you want to delete: ");
               string nameOfMovieToDelete = Console.ReadLine();

               for (int i = 0; i < movies.Count; i++)
               {
                   if (movies[i].Name.Equals(nameOfMovieToDelete))
                   {
                       movies.Remove(movies[i]);
                       Console.WriteLine("The movie " + nameOfMovieToDelete + " was succesfully removed." +
                           "Here is the up to date list of movies: ");
                       foreach (Movie movie1 in movies)
                       {
                           Console.WriteLine("Title: " + movie1.Name + "Producer: " + movie1.Producer +
                               "Theater: " + movie1.TheaterName);
                       }

                   }

               }
               Console.ReadKey();

           }
           */

        //    //movies.ForEach(Console.WriteLine);
        //    foreach (Movie m in movies)
        //{
        //    Console.WriteLine(m);
        //}
        //Console.ReadKey();
    }
}