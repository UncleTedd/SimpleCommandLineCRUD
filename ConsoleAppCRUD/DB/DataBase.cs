using ConsoleAppCRUD.Model;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppCRUD.DB
{
    public class DataBase
    {
        private readonly MyDbContext _context;

        //GET LIST MOVIES

        public List<Movie> GetListOfMovies()
        {
            return _context.Movies.Select(x => new Movie(x.Id, x.Name, "", "")).ToList();
        }

        //GET MOVIE BY ID


        public Movie GetMovieById(int id)
        {
            return _context.Movies.Where(x => x.Id == id).Select(x => new Movie(x.Id, x.Name, "", "")).First();
        }

        /*
        public List<Theater> GetListOfTheatersByMovie(string nameOfTheMovie)
        {
            List<Theater> result = new()
            {
                new Theater()
            };
        }
        */

        //DELETE MOVIE BY ID	


        public void DeleteMovieById(int id)
        {
            var movieToDelete = _context.Movies.First(x => x.Id == id);
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();
        }


        //CREATE MOVIE


        public void CreateMovie(Movie movie)
        {
            _context.Movies.Add(new MovieEntity(movie.ID, movie.Name));
            _context.SaveChanges();
        }

        // public static s AsString( MovieEntity movieEntity)
        // {
        // 	return new Movie
        // 	{
        // 		ID = movieEntity.Id,
        // 		Name = movieEntity.Name,
        // 	};
        // }

        // public void UpdateMovie(string nameOfTheMovie, string dataToUpdate, string newData)
        // {
        // //	_movies.(x=>x.Name.Equals(nameOfTheMovie)).
        //
        //    // var movie =	_movies.Select(x=>x.Name.Equals(nameOfTheMovie)).
        //
        // 	foreach(Movie movie in _movies)
        // 	{
        // 		if (movie.Name.Equals(nameOfTheMovie, StringComparison.OrdinalIgnoreCase))
        // 		{
        // 			if (dataToUpdate.Equals(movie.Name, StringComparison.OrdinalIgnoreCase))
        // 			{
        // 				movie.Name = newData;
        // 			}
        // 			if (dataToUpdate.Equals(movie.Producer, StringComparison.OrdinalIgnoreCase))
        // 			{
        // 				movie.Producer = newData;
        // 			}
        // 			if (dataToUpdate.Equals(movie.TheaterName, StringComparison.OrdinalIgnoreCase))
        // 			{
        // 				movie.TheaterName = newData;
        // 			}
        // 		}
        // 	}
        // }


        //UpdateMovie


        public void UpdateMovie(string movieToUpdate, string newName)
        {
            //var toUpdate = _context.Movies.Where(x => x.Name.Equals(movieToUpdate));
            //Select(x => new MovieEntity(x.Id, x.Name)).First();


            _context.Movies.ForEachAsync(x => x.Name = newName);
            _context.SaveChanges();
        }


        //DeleteMovie
        public void DeleteMovie(string movieName)
        {
            var movieToDelete = _context.Movies.First(x => x.Name.Equals(movieName));
            _context.Movies.Remove(movieToDelete);
            _context.SaveChanges();
        }


        //UPDATE THEATER


        public void UpdateTheater(string theaterToUpdate, string newName)
        {
            //var toUpdate = _context.Movies.Where(x => x.Name.Equals(movieToUpdate));
            //Select(x => new MovieEntity(x.Id, x.Name)).First();


            _context.Theaters.ForEachAsync(x => x.Name = newName);
            _context.SaveChanges();
        }


        //DELETE THEATER ID


        public void DeleteTheaterById(int id)
        {
            var theaterToDelete = _context.Theaters.First(x => x.Id == id);
            _context.Theaters.Remove(theaterToDelete);
            _context.SaveChanges();
        }


        //GET THEATER ID

        public Theater GetTheaterById(int id)
        {
            return _context.Theaters.Where(x => x.Id == id).Select(x => new Theater(x.Id, x.Name)).First();
        }


        //CREATE THEATER


        public void CreateTheater(Theater theater)
        {
            _context.Theaters.Add(new TheaterEntity(theater.ID, theater.Name));
            _context.SaveChanges();
        }


        //GET LIST THEATERS

        public List<Theater> GetListofTheaters()
        {
            return _context.Theaters.Select(x => new Theater(x.Id, x.Name)).ToList();
        }
    }
}