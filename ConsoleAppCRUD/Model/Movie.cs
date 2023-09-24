using System;

namespace ConsoleAppCRUD.Model;

public class Movie
{
    public Movie(int id, string name, string producer, string theaterName)
    {
        ID = id;
        Name = name;
        Producer = producer;
        TheaterName = theaterName;
    }

    public Movie()
    {
    }

    public override string? ToString()
    {
        return ID + ": " + Name + "; " + Producer + "; " + TheaterName;
    }

    public int ID { get; set; }
    public string Name { get; set; }
    public string Producer { get; set; }
    public string TheaterName { get; set; }
}