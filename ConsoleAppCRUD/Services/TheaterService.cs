using System;
using ConsoleAppCRUD.DB;
using ConsoleAppCRUD.Model;


namespace ConsoleAppCRUD.Services;

public class TheaterService
{
    public TheaterService()
    {
    }

    private readonly DataBase _db = new();

    public List<Theater> getListOfTheaters()
    {
        return _db.GetListofTheaters();
    }

    public void UpdateTheater(string theaterToUpdate, string newName)
    {
        _db.UpdateTheater(theaterToUpdate, newName);
    }

    public void DeleteTheaterById(int id)
    {
        _db.DeleteTheaterById(id);
    }


    public Theater GetTheaterById(int id)
    {
        return _db.GetTheaterById(id);
    }


    public void CreateTheater(Theater theater)
    {
        _db.CreateTheater(theater);
    }
}