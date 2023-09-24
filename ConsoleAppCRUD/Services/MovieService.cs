using ConsoleAppCRUD.DB;
using ConsoleAppCRUD.Model;

namespace ConsoleAppCRUD.Services;

public class MovieService
{
    private readonly DataBase _db = new();

    //Methods

    public List<Movie> GetListOfMovies()
    {
        return _db.GetListOfMovies();
    }

    public Movie GetMovieById(int id)
    {
        return _db.GetMovieById(id);
    }

    public void CreateMovie()
    {
        Console.WriteLine("please enter the name of the movie you want to add: ");
        string name = Console.ReadLine();
        Console.WriteLine("please enter the id: ");
        int id = int.Parse(Console.ReadLine());
        _db.CreateMovie(new Movie(id, name, " ", " "));


        // Console.WriteLine("Please write the name of the movie");
        // _db.CreateMovie(movie);
    }


    public void DeleteMovieById()
    {
        Console.WriteLine("Please write the ID of the movie you want to delete: ");
        int idOfMovieToDelete = int.Parse(Console.ReadLine());
        _db.DeleteMovieById(idOfMovieToDelete);
    }


    public void DeleteMovie()
    {
        Console.WriteLine("Please write the name of the movie you want to delete: ");
        string nameOfMovieToDelete = Console.ReadLine();
        _db.DeleteMovie(nameOfMovieToDelete);
    }


    public void UpdateMovie()
    {
        Console.WriteLine("please enter the name of the movie you want to update: ");
        string nameOfTheMovie = Console.ReadLine();
        Console.WriteLine("Please enter the new name of the movie: ");
        string newData = Console.ReadLine();
        _db.UpdateMovie(nameOfTheMovie, newData);
    }
}