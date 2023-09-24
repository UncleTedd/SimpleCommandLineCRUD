using System;
namespace ConsoleAppCRUD.Model;

public class Theater
{
	public Theater(int id, string name)
	{
		ID = id;
		Name = name;

	}

	public Theater()
	{
	}

	public int ID { get; set; }
	public string Name { get; set; }

}